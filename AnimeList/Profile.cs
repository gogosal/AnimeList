using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeList
{
    public partial class Profile : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";database=animelist;uid=root;pwd=root");

        string pathdialog;
        Image image;
        public Profile()
        {
            InitializeComponent();

            try
            {
                MySqlDataReader mdr;
                string select = "SELECT * FROM users WHERE nomeconta = @nomeID";
                MySqlCommand command = new MySqlCommand(select, connection);
                command.Parameters.AddWithValue("@nomeID", Globais.NomeID);
                connection.Open();
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    txt_name.Text = mdr.GetString("nomeutilizador");
                    txt_desc.Text = mdr.GetString("descr");
                    Globais.desc = txt_desc.Text;
                    Globais.nfav = int.Parse(lbl_nFavoritos.Text);
                    Globais.nvistos = int.Parse(lbl_nVistos.Text);

                    //Retrieve BLOB from database into DataSet.
                    MySqlCommand cmd2 = new MySqlCommand("SELECT imagem FROM users where nomeconta='" + Globais.NomeID + "'", connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                    DataSet ds = new DataSet();
                    connection.Close();
                    da.Fill(ds, "mst_image");
                    int c = ds.Tables["mst_image"].Rows.Count;

                    if (c > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData = new Byte[0];
                        byteBLOBData = (Byte[])(ds.Tables["mst_image"].Rows[c - 1]["imagem"]);
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        pb_Perfil.Image = Image.FromStream(stmBLOBData);
                    }
                }
            }
            catch(Exception erro)
            {
                connection.Close();
                //MessageBox.Show(erro.Message);
            }

            btn_Delete.Hide();
            btn_Save.Hide();
            lbl_changepass.Hide();
            txt_changepass.Hide();
            pb_Mostrar.Hide();

            openFileDialog.FileName = "";
            openFileDialog.Filter = "Arquivos de Imagem (*.jpg;*.png)|*.jpg;*.png";
            openFileDialog.AutoUpgradeEnabled = true;
        }

        int flag = 1;
        private void pb_definicoes_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                btn_Delete.Show();
                btn_Save.Show();
                txt_name.ReadOnly = false;
                txt_desc.ReadOnly = false;
                lbl_changepass.Show();
                txt_changepass.Show();
                pb_Mostrar.Show();
                flag = 2;
            }
            else if (flag == 2)
            {
                btn_Delete.Hide();
                btn_Save.Hide();
                txt_name.ReadOnly = true;
                txt_desc.ReadOnly = true;
                lbl_changepass.Hide();
                txt_changepass.Hide();
                pb_Mostrar.Hide();
                flag = 1;
            }
        }

        private void pb_Perfil_Click(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathdialog = openFileDialog.FileName;
                    image = Image.FromFile(pathdialog);
                    pb_Perfil.Image = image;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_changepass.Text.Length < 8)
                {
                    MessageBox.Show("Insira uma password com 8 ou mais caracteres!");
                }
                else
                {
                    Image img = pb_Perfil.Image;
                    byte[] Image = ImageToByteArray(img);

                    connection.Open();

                    string updateQuery = "UPDATE users SET password = @password, nomeutilizador = @nomeutilizador, imagem = @imagem, descr = @descr WHERE nomeconta = @nomeconta";

                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@password", txt_changepass.Text);
                    command.Parameters.AddWithValue("@nomeutilizador", txt_name.Text);
                    command.Parameters.AddWithValue("@imagem", Image);
                    command.Parameters.AddWithValue("@descr", txt_desc.Text);
                    command.Parameters.AddWithValue("@nomeconta", Globais.NomeID);

                    command.ExecuteNonQuery();

                    connection.Close();

                    btn_Delete.Hide();
                    btn_Save.Hide();
                    txt_name.ReadOnly = true;
                    txt_desc.ReadOnly = true;
                    lbl_changepass.Hide();
                    txt_changepass.Hide();
                    pb_Mostrar.Hide();
                    flag = 1;
                    MessageBox.Show("Alterações salvas com sucesso!");
                }
            }
            catch(Exception erro)
            {
                connection.Close();
                MessageBox.Show("A imagem que escolheste não é suportada devido ao seu tamanho!");
                //MessageBox.Show(erro.Message);
            }
        }
        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string deleteQuery = "DELETE FROM users WHERE nomeconta = @nomeconta";
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@nomeconta", Globais.NomeID);
                command.ExecuteNonQuery();
                connection.Close();
                Globais.NomeID = null;
                this.Close();
                MessageBox.Show("A conta foi deletada com sucesso!");
            }
            catch (Exception erro)
            {
                connection.Close();
                MessageBox.Show(erro.Message);
            }
        }
        private void Profile_Load(object sender, EventArgs e)
        {
            txt_changepass.Text = Globais.pass;
            txt_changepass.PasswordChar = '\u25CF';
            connection.Open();
            string SelectID = "SELECT id FROM users WHERE nomeconta= @nomeconta";
            MySqlCommand command = new MySqlCommand(SelectID, connection);
            command.Parameters.AddWithValue("@nomeconta", Globais.NomeID);

            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                int userId = reader.GetInt32("id");
                connection.Close();

                //Contar quantas rows existem no respetivo id
                connection.Open();
                string CountFavBytId = "SELECT COUNT(*) FROM favoritos WHERE id = @id";
                string CountVistosById = "SELECT COUNT(*) FROM vistos WHERE id = @id";
                MySqlCommand FCountcommand = new MySqlCommand(CountFavBytId, connection);
                MySqlCommand VCountcommand = new MySqlCommand(CountVistosById, connection);
                FCountcommand.Parameters.AddWithValue("@id", userId);
                VCountcommand.Parameters.AddWithValue("@id", userId);
                int Fcount = Convert.ToInt32(FCountcommand.ExecuteScalar());
                int Vcount = Convert.ToInt32(VCountcommand.ExecuteScalar());
                connection.Close();

                lbl_nFavoritos.Text = Fcount.ToString();
                lbl_nVistos.Text = Vcount.ToString();

            }
        }
        bool flagmostrar = true;
        private void pb_Mostrar_Click(object sender, EventArgs e)
        {
            if (flagmostrar)
            {
                pb_Mostrar.Image = Properties.Resources.NãoMostrar;
                txt_changepass.PasswordChar = '\0';
                flagmostrar = false;
            }
            else
            {
                pb_Mostrar.Image = Properties.Resources.Mostrar;
                txt_changepass.PasswordChar = '\u25CF';
                flagmostrar = true;
            }
        }

        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pb_definicoes.Hide();
                connection.Open();
                string Search = "SELECT * FROM users WHERE nomeconta = @nomeconta";
                MySqlCommand command = new MySqlCommand(Search, connection);

                command.Parameters.AddWithValue("@nomeconta", txt_Search.Text);

                MySqlDataReader reader = command.ExecuteReader();

                try
                {
                    if (reader.Read())
                    {
                        pb_Perfil.Image = Properties.Resources.Profile;
                        txt_name.Text = Globais.NomeID;
                        txt_desc.Text = Globais.desc;
                        lbl_nFavoritos.Text = "0";
                        lbl_nVistos.Text = "0";

                        int userId = reader.GetInt32("id");
                        txt_name.Text = reader.GetString("nomeutilizador");
                        txt_desc.Text = reader.GetString("descr");

                        //Retrieve BLOB from database into DataSet.
                        MySqlCommand cmd2 = new MySqlCommand("SELECT imagem FROM users where nomeconta= @nomeconta", connection);
                        cmd2.Parameters.AddWithValue("@nomeconta", txt_Search.Text);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd2);
                        DataSet ds = new DataSet();
                        connection.Close();
                        da.Fill(ds, "mst_image");
                        int c = ds.Tables["mst_image"].Rows.Count;

                        if (c > 0)
                        {   //BLOB is read into Byte array, then used to construct MemoryStream,
                            //then passed to PictureBox.
                            Byte[] byteBLOBData = new Byte[0];
                            byteBLOBData = (Byte[])(ds.Tables["mst_image"].Rows[c - 1]["imagem"]);
                            MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                            pb_Perfil.Image = Image.FromStream(stmBLOBData);
                        }

                        //Contar quantas rows existem no respetivo id
                        connection.Open();
                        string CountFavBytId = "SELECT COUNT(*) FROM favoritos WHERE id = @id";
                        string CountVistosById = "SELECT COUNT(*) FROM vistos WHERE id = @id";
                        MySqlCommand FCountcommand = new MySqlCommand(CountFavBytId, connection);
                        MySqlCommand VCountcommand = new MySqlCommand(CountVistosById, connection);
                        FCountcommand.Parameters.AddWithValue("@id", userId);
                        VCountcommand.Parameters.AddWithValue("@id", userId);
                        int Fcount = Convert.ToInt32(FCountcommand.ExecuteScalar());
                        int Vcount = Convert.ToInt32(VCountcommand.ExecuteScalar());
                        connection.Close();

                        lbl_nFavoritos.Text = Fcount.ToString();
                        lbl_nVistos.Text = Vcount.ToString();
                    }
                    else
                    {
                        MessageBox.Show("O utilizador que pesquisou não existe!");
                        connection.Close();
                    }
                }
                catch
                {
                    connection.Close();
                }
            }
        }
    }
}
