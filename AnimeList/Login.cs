using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btn_GoCreate.Show();
            txt_Password.PasswordChar = '\u25CF';
            AcceptButton = btn_Login;
        }

        private void btn_GoCreate_Click(object sender, EventArgs e)
        {
            btn_GoCreate.Hide();
            btn_Login.Text = "Create";
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Globais global = new Globais();

            global.NomeConta = txt_Username.Text;
            global.Password = txt_Password.Text;
            Globais.pass = txt_Password.Text;

            if (btn_Login.Text == "Login")
            {
                if (txt_Password.Text != "" && txt_Username.Text != "")
                {
                    MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";database=animelist;uid=root;pwd=root");
                    connection.Open();

                    string verifica = "select * from users where " +
                    "nomeconta = @nutilizador " +
                    "and password = @npalavrachave";

                    MySqlCommand comandosve = new MySqlCommand(verifica, connection);

                    comandosve.Parameters.AddWithValue("@nutilizador", global.NomeConta);
                    comandosve.Parameters.AddWithValue("@npalavrachave", global.Password);

                    MySqlDataAdapter dados = new MySqlDataAdapter(comandosve);

                    DataTable tabela = new DataTable();
                    dados.Fill(tabela);
                    comandosve.Dispose();

                    if (tabela.Rows.Count == 1)
                    {
                        Globais.NomeUtilizador = global.NomeConta;
                        Globais.NomeID = global.NomeConta;
                        MessageBox.Show("Login com sucesso!");
                        this.Close();
                    }
                    else if(tabela.Rows.Count == 0)
                    {
                        MessageBox.Show("Password ou Username Errado!");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!");
                }

            }
            if (btn_Login.Text == "Create")
            {
                try
                {
                    if (txt_Password.Text.Length < 8)
                    {
                        MessageBox.Show("Insira uma password com 8 ou mais caracteres!");
                    }
                    else
                    {
                        MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";database=animelist;uid=root;pwd=root");
                        connection.Open();

                        string verifica = "select * from users where " +
                            "nomeconta = @nutilizador " +
                            "and password = @npalavrachave";

                        MySqlCommand comandosve = new MySqlCommand(verifica, connection);

                        comandosve.Parameters.AddWithValue("@nutilizador", global.NomeConta);
                        comandosve.Parameters.AddWithValue("@npalavrachave", global.Password);

                        MySqlDataAdapter dados = new MySqlDataAdapter(comandosve);

                        DataTable tabela = new DataTable();
                        dados.Fill(tabela);
                        comandosve.Dispose();

                        if (tabela.Rows.Count == 1)
                        {
                            MessageBox.Show("Nome de Utilizador já existente!");
                        }
                        else
                        {
                            string inserir = "Insert into users(nomeconta, password, nomeutilizador) values('" + global.NomeConta + "','" + global.Password + "','"+ global.NomeConta + "')";
                            MessageBox.Show("Bem vindo " + global.NomeConta + "!\nFoste registrado com sucesso!");

                            MySqlCommand comandos = new MySqlCommand(inserir, connection);
                            comandos.ExecuteNonQuery();

                            connection.Close();
                            this.Close();
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Nao foi estabelecida ligação\n" + error);
                }
            }
        }
    }
}
