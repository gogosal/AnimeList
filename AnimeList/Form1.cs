using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JikanDotNet;
using MySql.Data.MySqlClient;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AnimeList
{
    public partial class Form1 : Form
    {
        IJikan jikan = new Jikan();

        private Form activeForm;

        List<Anime> api = new List<Anime>();
        List<PictureBox> PicBox = new List<PictureBox>();
        List<Label> label = new List<Label>();
        List<string> nomes = new List<string>();
        List<long> ids = new List<long>();
        List<System.Drawing.Image> imagens = new List<System.Drawing.Image>();
        
        //Favoritos
        List<string> Fnomes = new List<string>();
        List<byte[]> Imagens = new List<byte[]>();
        List<Label> lbl = new List<Label>();
        List<PictureBox> pb = new List<PictureBox>();

        int id = 0;
        bool flag = true;

        public Form1()
        {
            InitializeComponent();
        }
        public async void Fetch(string search)
        {
            try
            {
                //Gera os titulos dos animes
                var AnimeSearchResult = await jikan.SearchAnimeAsync(search);

                //Lista com os banners e os nomes dos animes
                api = AnimeSearchResult.Data.ToList();

                //Cria a quantidade de banners e nomes
                Generate(api.Count);

                //Pega em todas as picturebox e label's
                PicBox = Layout.Controls.OfType<PictureBox>().ToList();
                label = Layout.Controls.OfType<Label>().ToList();

                //Nomes
                for (int i = 0; i < api.Count; i++)
                {
                    if (i < label.Count) 
                    {
                        label[i].Text = api[i].Title.ToString();
                        nomes.Add(label[i].Text);
                        ids.Add(api[i].MalId.Value);
                    }
                    else
                    {

                    }
                }
                //Banners
                for (int i = 0; i < api.Count; i++)
                {
                    if (i < PicBox.Count)
                    {
                        PicBox[i].Load(api[i].Images.JPG.ImageUrl);
                    }
                    else
                    {

                    }
                }
            }
            catch(Exception erro)
            {
                //Mosta um erro se não conseguir conectar ao servidor
                MessageBox.Show("Não foi possivel conectar ao servidor!\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Generate(int cont)
        {
            int row = 0;
            int column = 0;

            for (int i = 0; i < cont; i++)
            {
                //PictureBox
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(6 + column * 146, 3 + row * 281);
                pictureBox.Size = new Size(140, 185);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.BackColor = Color.Black;

                //Evento
                pictureBox.Click += (sender, EventArgs) =>
                {
                    if (flag)
                    {
                        int pictureBoxNumber = Layout.Controls.OfType<PictureBox>().ToList().IndexOf(pictureBox);
                        PictureBox Senderbutton = (PictureBox)sender;
                        Globais.Image = pictureBox.Image;
                        Globais.Name = nomes[pictureBoxNumber];
                        Globais.id = ids[pictureBoxNumber];
                    }
                    else
                    {
                        MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";database=animelist;uid=root;pwd=root");

                        connection.Open();

                        int pictureBoxNumber = Layout.Controls.OfType<PictureBox>().ToList().IndexOf(pictureBox);
                        Globais.Nome = lbl[pictureBoxNumber].Text;

                        string AnimeID = "SELECT idanime FROM favoritos WHERE nome = @nome";
                        MySqlCommand Animecommand = new MySqlCommand(AnimeID, connection);
                        Animecommand.Parameters.AddWithValue("@nome", Globais.Nome);

                        MySqlDataReader Animeexecute = Animecommand.ExecuteReader();
                        if (Animeexecute.Read())
                        {
                            Globais.Image = pictureBox.Image;
                            Globais.Name = lbl[pictureBoxNumber].Text;
                            Globais.id = Animeexecute.GetInt32("idanime");
                        }
                        connection.Close();
                    }


                    nomes.Clear();
                    ids.Clear();

                    DirectoryInfo di = new DirectoryInfo("Cache");
                    if (Directory.Exists("Cache"))
                    {
                        foreach (FileInfo file in di.GetFiles())
                        {
                            file.Delete();
                        }
                    }
                    txt_Search.Hide();
                    Layout.Controls.Clear();
                    OpenChildForm(new DescAnime(), sender);
                };

                // Adiciona a PictureBox ao formulário
                Layout.Controls.Add(pictureBox);

                //Label
                Label label = new Label();
                label.Location = new Point(6 + column * 146, 191 + row * 281);
                label.AutoSize = false;
                label.Size = new Size(140, 85);
                Font LargeFont = new Font("Microsoft Sans Serif", 10);
                label.Font = LargeFont;

                // Adiciona a Label ao formulário
                Layout.Controls.Add(label);

                column++;

                if (column == 8)
                {
                    column = 0;
                    row++;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";uid=root;pwd=root");
                connection.Open();
                string createDBCommand = "CREATE SCHEMA if not EXISTS `animelist`";
                MySqlCommand command = new MySqlCommand(createDBCommand, connection);
                string createUserTableCommand = "CREATE TABLE if NOT exists `animelist`.`users` (`id` INT NOT NULL AUTO_INCREMENT, `nomeconta` VARCHAR(45) NULL, `password` VARCHAR(45) NULL, `nomeutilizador` VARCHAR(45) NULL, `imagem` LONGBLOB NULL, `descr` LONGTEXT NULL, PRIMARY KEY (`id`));";
                string createFavoriteCommand = "CREATE TABLE if NOT exists `animelist`.`favoritos` (`idfavoritos` INT NOT NULL AUTO_INCREMENT, `imagem` LONGBLOB NULL, `nome` VARCHAR(45) NULL, `id` INT NOT NULL, `idanime` INT NOT NULL, PRIMARY KEY(`idfavoritos`), foreign key(id) references users(id) ON DELETE CASCADE);";
                string createViewedCommand = "CREATE TABLE if NOT exists `animelist`.`vistos` (`idvistos` INT NOT NULL AUTO_INCREMENT, `imagem` LONGBLOB NULL, `nome` VARCHAR(45) NULL, `id` INT NOT NULL,`idanime` INT NOT NULL, PRIMARY KEY(`idvistos`), foreign key(id) references users(id) ON DELETE CASCADE);";
                MySqlCommand Tucommand = new MySqlCommand(createUserTableCommand, connection);
                MySqlCommand Tfcommand = new MySqlCommand(createFavoriteCommand, connection);
                MySqlCommand Tvcommand = new MySqlCommand(createViewedCommand, connection);
                command.ExecuteNonQuery();
                Tucommand.ExecuteNonQuery();
                Tfcommand.ExecuteNonQuery();
                Tvcommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login: Irá aparecer um painel onde o utilizador poderá fazer login na conta ou criar um a conta nova!\n" +
                            "Profile: Será o local onde o utilizador poderá personalizar o seu perfil, mudar nome, mudar status!\n" +
                            "Favorite: Terá todos os animes que o utilizador favoritou!\n" +
                            "Viewed: Terá todos os animes que o utilizador já viu!\n" +
                            "Search: É um campo onde se pode pesquisar pelo nome de um anime, e ver as suas caractristicas!\n" +
                            "Exit: Serve para sair da aplicação!");
        }

        private void txt_Search_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                flag = true;
                pb_Icon.Hide();
                Fetch(txt_Search.Text);
                txt_Search.Text = "Search";
                Layout.Controls.Clear();
                nomes.Clear();
                ids.Clear();
            }
        }

        private void txt_Search_Click(object sender, EventArgs e)
        {
            txt_Search.Clear();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Layout.Controls.Add(childForm);
            Layout.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Layout.Controls.Clear();
            if (btn_Login.Text == "Logout")
            {
                Globais.NomeID = null;
                btn_Login.Text = "Login";
                pic_profile.Image = Properties.Resources.Profile;
            }
            txt_Search.Hide();
            Update.Start();
            OpenChildForm(new Login(), sender);
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            if (Globais.NomeID != null)
            {
                txt_Search.Hide();
                Update.Start();
                OpenChildForm(new Profile(), sender);
            }
            else
            {
                MessageBox.Show("Precisa de dar login para aceder ao seu prefil!");
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Layout.Controls.Clear();

                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(435, 144);
                pictureBox.Size = new Size(364, 364);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Image = Properties.Resources.Icon;
                Layout.Controls.Add(pictureBox);

                txt_Search.Show();
            }
        }

        private async void btn_Favorite_Click(object sender, EventArgs e)
        {
            flag = false;
            if (Globais.NomeID != null)
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";database=animelist;uid=root;pwd=root");
                txt_Search.Hide();
                Layout.Controls.Clear();
                Fnomes.Clear();
                Imagens.Clear();
                lbl.Clear();
                pb.Clear();

                connection.Open();
                string SelectID = "SELECT id FROM users WHERE nomeconta= '" + Globais.NomeID + "'";
                MySqlCommand command = new MySqlCommand(SelectID, connection);

                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32("id");
                    connection.Close();

                    //Contar quantas rows existem no respetivo id
                    connection.Open();
                    string CountBytId = "SELECT COUNT(*) FROM favoritos WHERE id = @id";
                    MySqlCommand Countcommand = new MySqlCommand(CountBytId, connection);
                    Countcommand.Parameters.AddWithValue("@id", userId);
                    int count = Convert.ToInt32(Countcommand.ExecuteScalar());
                    connection.Close();

                    connection.Open();

                    string SelectAll = "SELECT * FROM favoritos WHERE id = @id";
                    MySqlCommand Favcommand = new MySqlCommand(SelectAll, connection);
                    Favcommand.Parameters.AddWithValue("@id", userId);

                    MySqlDataReader execute = Favcommand.ExecuteReader();

                    while (execute.Read())
                    {
                        string nome = execute.GetString(2);
                        byte[] Blob = execute.GetValue(1) as byte[];
                        Fnomes.Add(nome);
                        Imagens.Add(Blob);

                        Generate(count);
                        pb = Layout.Controls.OfType<PictureBox>().ToList();
                        lbl = Layout.Controls.OfType<Label>().ToList();
                    }

                    imagens = byteArrayToImage(Imagens);

                    // Exibe as imagens e os nomes
                    for (int i = 0; i < Imagens.Count; i++)
                    {
                        //Banner
                        if (i < pb.Count)
                        {
                            pb[i].Image = imagens[i];
                        }

                        //Label
                        if (i < Fnomes.Count)
                        {
                            lbl[i].Text = Fnomes[i].ToString();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Precisa de dar login para aceder ao seu prefil!");
            }
        }
        public List<System.Drawing.Image> byteArrayToImage(List<byte[]> listaByteArrays)
        {
            List<System.Drawing.Image> listaImagens = new List<System.Drawing.Image>();

            foreach (byte[] byteArray in listaByteArrays)
            {
                using (MemoryStream stream = new MemoryStream(byteArray))
                {
                    System.Drawing.Image imagem = System.Drawing.Image.FromStream(stream);
                    listaImagens.Add(imagem);
                }
            }

            return listaImagens;
        }


        private void btn_Viewed_Click(object sender, EventArgs e)
        {
            if (Globais.NomeID != null)
            {
                MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";database=animelist;uid=root;pwd=root");
                txt_Search.Hide();
                Layout.Controls.Clear();
                Fnomes.Clear();
                Imagens.Clear();
                lbl.Clear();
                pb.Clear();

                connection.Open();
                string SelectID = "SELECT id FROM users WHERE nomeconta= '" + Globais.NomeID + "'";
                MySqlCommand command = new MySqlCommand(SelectID, connection);

                command.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32("id");
                    connection.Close();

                    //Contar quantas rows existem no respetivo id
                    connection.Open();
                    string CountBytId = "SELECT COUNT(*) FROM vistos WHERE id = @id";
                    MySqlCommand Countcommand = new MySqlCommand(CountBytId, connection);
                    Countcommand.Parameters.AddWithValue("@id", userId);
                    int count = Convert.ToInt32(Countcommand.ExecuteScalar());
                    connection.Close();

                    connection.Open();

                    string SelectAll = "SELECT * FROM vistos WHERE id = @id";
                    MySqlCommand Vistoscommand = new MySqlCommand(SelectAll, connection);
                    Vistoscommand.Parameters.AddWithValue("@id", userId);

                    MySqlDataReader execute = Vistoscommand.ExecuteReader();

                    while (execute.Read())
                    {
                        string nome = execute.GetString(2);
                        byte[] Blob = execute.GetValue(1) as byte[];
                        Fnomes.Add(nome);
                        Imagens.Add(Blob);

                        Generate(count);
                        pb = Layout.Controls.OfType<PictureBox>().ToList();
                        lbl = Layout.Controls.OfType<Label>().ToList();
                    }

                    imagens = byteArrayToImage(Imagens);

                    // Exibe as imagens e os nomes
                    for (int i = 0; i < Imagens.Count; i++)
                    {
                        //Banner
                        if (i < pb.Count)
                        {
                            pb[i].Image = imagens[i];
                        }

                        //Label
                        if (i < Fnomes.Count)
                        {
                            lbl[i].Text = Fnomes[i].ToString();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Precisa de dar login para aceder ao seu prefil!");
            }
        }

        private void Update_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Login>().Count() > 0 || Application.OpenForms.OfType<Profile>().Count() > 0)
            {

            }
            else
            {
                if (Globais.NomeID != null)
                {
                    btn_Login.Text = "Logout";
                    MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";database=animelist;uid=root;pwd=root");
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
                                pic_profile.Image = System.Drawing.Image.FromStream(stmBLOBData);
                            }
                        }
                    }
                    catch (Exception erro)
                    {
                        connection.Close();
                        //MessageBox.Show(erro.Message);
                    }
                }
                else
                {
                    pic_profile.Image = Properties.Resources.Profile;
                    btn_Login.Text = "Login";
                }
                txt_Search.Show();
                Update.Stop();
            }
        }
    }
}
