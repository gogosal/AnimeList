using JikanDotNet;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Converter;
using Aspose.Imaging.ImageOptions;
using System.Drawing.Imaging;

namespace AnimeList
{
    public partial class DescAnime : Form
    {
        IJikan jikan = new Jikan();

        public DescAnime()
        {
            InitializeComponent();
            Fetch(Globais.id);
            Videos();
            Media.uiMode = "none";
            pb_Image.Image = Globais.Image;
            lbl_AnimeName.Text = Globais.Name;
        }

        public async void Fetch(long id)
        {
            var pesquisa = await jikan.GetAnimeAsync(id);

            foreach (var item in pesquisa.Data.Genres)
            {
                lbl_Generos.Text += item.Name.ToString() + "  ";
            }
            foreach (var item in pesquisa.Data.Producers)
            {
                lbl_Prudotor.Text += " " + item.Name;
            }
            foreach (var item in pesquisa.Data.Studios)
            {
                lbl_Studio.Text = "Studio: " + item.Name;
            }
            foreach (var item in pesquisa.Data.Titles)
            {
                lbl_TituloOriginal.Text = "Original Title: " + item.Title;
            }
            lbl_Ano.Text = "Year: " + pesquisa.Data.Year;
            lbl_Completo.Text = "Status: " + pesquisa.Data.Status;
            lbl_Duracao.Text = "Anime - Duration: " + pesquisa.Data.Duration;
            lbl_Tipo.Text = "Type: " + pesquisa.Data.Type;
            txt_desc.Text = pesquisa.Data.Synopsis;
            if (pesquisa.Data.Episodes == null)
            {
                lbl_Ep.Text = "Episodes: 0";
            }
            else
            {
                lbl_Ep.Text = "Episodes: " + pesquisa.Data.Episodes;
            }
        }

        public async void Videos()
        {
            try
            {
                var youtube = new YoutubeClient();
                var videos = await jikan.GetAnimeVideosAsync(Globais.id);

                if (videos.Data.PromoVideos.Count != 0)
                {
                    lbl_Estado.Visible = true;
                    foreach (var trailer in videos.Data.PromoVideos)
                    {
                        var videoUrl = trailer.Trailer.EmbedUrl;
                        await youtube.Videos.DownloadAsync(videoUrl, @"Cache\Cache.mp4", o => o
                                                    .SetContainer("webm") // override format
                                                    .SetPreset(ConversionPreset.UltraFast) // change preset
                                                    .SetFFmpegPath(@"ffmpeg\bin\ffmpeg.exe") // custom FFmpeg location
                                                     );
                        Media.URL = @"Cache\Cache.mp4";
                        lbl_Estado.Visible = false;
                    }
                }
                else
                {
                    lbl_Estado.Visible = true;
                    lbl_Estado.Text = "Trailer do not exist!";
                }
            }
            catch(Exception erro)
            {
                lbl_Estado.Text = "Trailer do not exist!";
                //MessageBox.Show(erro.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Media.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                button1.Text = "PAUSE";
                Media.Ctlcontrols.play();
            }
            else if (Media.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                button1.Text = "START";
                Media.Ctlcontrols.pause();
            }
        }

        int flag = 1;
        int flag2 = 1;

        MySqlConnection connection = new MySqlConnection("server=localhost;port=" + Globais.connect + ";database=animelist;uid=root;pwd=root");

        int id = 0;

        private void pb_Favorito_Click(object sender, EventArgs e)
        {
            if (Globais.NomeID != null)
            {
                //Adicionar na base de dados
                if (flag == 1)
                {
                    pb_Favorito.Image = Properties.Resources.Favorito;
                    flag = 2;

                    connection.Open();

                    string SelectID = "SELECT id FROM users WHERE nomeconta= '" + Globais.NomeID + "'";

                    MySqlCommand command = new MySqlCommand(SelectID, connection);

                    command.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = command.ExecuteReader(); 

                    if (reader.Read())
                    {
                        try
                        {
                            int userId = reader.GetInt32("id");
                            connection.Close();

                            connection.Open();

                            System.Drawing.Image image = pb_Image.Image;
                            image.Save(@"Cache\FavImageCache.jpg");
                            System.Drawing.Image img = System.Drawing.Image.FromFile(@"Cache\FavImageCache.jpg");
                            byte[] FBlob = ImageToByteArray(img);

                            string FNome = lbl_AnimeName.Text;

                            string InsertFav = "INSERT INTO favoritos(imagem, nome, id, idanime) VALUES (@imagem, @nome, @id, @idanime)";

                            MySqlCommand Favcommand = new MySqlCommand(InsertFav, connection);
                            Favcommand.Parameters.AddWithValue("@imagem", FBlob);
                            Favcommand.Parameters.AddWithValue("@nome", FNome);
                            Favcommand.Parameters.AddWithValue("@id", userId);
                            Favcommand.Parameters.AddWithValue("@idanime", Globais.id);

                            Favcommand.ExecuteNonQuery();

                            connection.Close();

                            try
                            {
                                DirectoryInfo di = new DirectoryInfo("Cache");
                                if (Directory.Exists("Cache"))
                                {
                                    foreach (FileInfo file in di.GetFiles())
                                    {
                                        file.Delete();
                                    }
                                }
                            }
                            catch
                            {

                            }
                        }
                        catch
                        {
                            connection.Close();
                        }
                    }
                }
                //Remover na base de dados
                else if (flag == 2)
                {
                    pb_Favorito.Image = Properties.Resources.NaoFavorito;
                    flag = 1;

                    connection.Open();
                    string deleteQuery = "DELETE FROM favoritos WHERE nome = @nome";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@nome", lbl_AnimeName.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Precisa de dar login para aceder ao seu prefil!");
            }
        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void pb_Visto_Click(object sender, EventArgs e)
        {
            if (Globais.NomeID != null)
            {
                //Adicionar na base de dados
                if (flag2 == 1)
                {
                    pb_Visto.Image = Properties.Resources.Visto;
                    flag = 2;

                    connection.Open();

                    string SelectID = "SELECT id FROM users WHERE nomeconta= '" + Globais.NomeID + "'";

                    MySqlCommand command = new MySqlCommand(SelectID, connection);

                    command.Parameters.AddWithValue("@id", id);

                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        try
                        {
                            int userId = reader.GetInt32("id");
                            connection.Close();

                            connection.Open();

                            System.Drawing.Image image = pb_Image.Image;
                            image.Save(@"Cache\VistoImageCache.jpg");
                            System.Drawing.Image img = System.Drawing.Image.FromFile(@"Cache\VistoImageCache.jpg");
                            byte[] VBlob = ImageToByteArray(img);

                            string VNome = lbl_AnimeName.Text;

                            string InsertVistos = "INSERT INTO vistos(imagem, nome, id, idanime) VALUES (@imagem, @nome, @id, @idanime)";

                            MySqlCommand Vistoscommand = new MySqlCommand(InsertVistos, connection);
                            Vistoscommand.Parameters.AddWithValue("@imagem", VBlob);
                            Vistoscommand.Parameters.AddWithValue("@nome", VNome);
                            Vistoscommand.Parameters.AddWithValue("@id", userId);
                            Vistoscommand.Parameters.AddWithValue("@idanime", Globais.id);

                            Vistoscommand.ExecuteNonQuery();

                            connection.Close();

                            try
                            {
                                DirectoryInfo di = new DirectoryInfo("Cache");
                                if (Directory.Exists("Cache"))
                                {
                                    foreach (FileInfo file in di.GetFiles())
                                    {
                                        file.Delete();
                                    }
                                }
                            }
                            catch
                            {

                            }
                        }
                        catch
                        {
                            connection.Close();
                        }
                    }
                }
                //Remover na base de dados
                else if (flag == 2)
                {
                    pb_Visto.Image = Properties.Resources.NaoVistos;
                    flag2 = 1;

                    connection.Open();
                    string deleteQuery = "DELETE FROM vistos WHERE nome = @nome";
                    MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@nome", lbl_AnimeName.Text);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Precisa de dar login para aceder ao seu prefil!");
            }
        }

        private void DescAnime_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string SelectID = "SELECT id FROM users WHERE nomeconta = @nomeconta";

                MySqlCommand command = new MySqlCommand(SelectID, connection);
                command.Parameters.AddWithValue("@nomeconta", Globais.NomeID);

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    int userId = reader.GetInt32("id");
                    connection.Close();

                    connection.Open();
                    string FavExists = "SELECT * FROM favoritos WHERE idanime = @idanime and id = @id";
                    MySqlCommand Fcommand = new MySqlCommand(FavExists, connection);
                    Fcommand.Parameters.AddWithValue("@idanime", Globais.id);
                    Fcommand.Parameters.AddWithValue("@id", userId);

                    MySqlDataReader FavReader = Fcommand.ExecuteReader();
                    if (FavReader.Read())
                    {
                        connection.Close();
                        pb_Favorito.Image = Properties.Resources.Favorito;
                    }
                    connection.Open();

                    string VistosExists = "SELECT * FROM vistos WHERE idanime = @idanime and id = @id";
                    MySqlCommand Vcommand = new MySqlCommand(VistosExists, connection);
                    Vcommand.Parameters.AddWithValue("@idanime", Globais.id);
                    Vcommand.Parameters.AddWithValue("@id", userId);

                    MySqlDataReader VistosReader = Vcommand.ExecuteReader();
                    if (VistosReader.Read())
                    {
                        connection.Close();
                        pb_Visto.Image = Properties.Resources.Visto;
                    }
                    flag = 2;
                    flag2 = 2;
                }
            }
            catch
            {
                connection.Close();
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
