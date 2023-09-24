
namespace AnimeList
{
    partial class DescAnime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DescAnime));
            this.lbl_AnimeName = new System.Windows.Forms.Label();
            this.lbl_TituloOriginal = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Estado = new System.Windows.Forms.Label();
            this.lbl_Duracao = new System.Windows.Forms.Label();
            this.lbl_Generos = new System.Windows.Forms.Label();
            this.lbl_Ano = new System.Windows.Forms.Label();
            this.lbl_Completo = new System.Windows.Forms.Label();
            this.lbl_Tipo = new System.Windows.Forms.Label();
            this.lbl_Prudotor = new System.Windows.Forms.Label();
            this.lbl_Studio = new System.Windows.Forms.Label();
            this.lbl_Ep = new System.Windows.Forms.Label();
            this.pb_Visto = new System.Windows.Forms.PictureBox();
            this.pb_Favorito = new System.Windows.Forms.PictureBox();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Visto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Favorito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_AnimeName
            // 
            this.lbl_AnimeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnimeName.Location = new System.Drawing.Point(38, 73);
            this.lbl_AnimeName.Name = "lbl_AnimeName";
            this.lbl_AnimeName.Size = new System.Drawing.Size(657, 71);
            this.lbl_AnimeName.TabIndex = 1;
            this.lbl_AnimeName.Text = "Anime1";
            // 
            // lbl_TituloOriginal
            // 
            this.lbl_TituloOriginal.AutoSize = true;
            this.lbl_TituloOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloOriginal.Location = new System.Drawing.Point(41, 431);
            this.lbl_TituloOriginal.Name = "lbl_TituloOriginal";
            this.lbl_TituloOriginal.Size = new System.Drawing.Size(86, 16);
            this.lbl_TituloOriginal.TabIndex = 3;
            this.lbl_TituloOriginal.Text = "Original Title:";
            // 
            // txt_desc
            // 
            this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(44, 235);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_desc.Size = new System.Drawing.Size(573, 143);
            this.txt_desc.TabIndex = 4;
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(751, 385);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(375, 231);
            this.Media.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(901, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "PAUSE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Estado
            // 
            this.lbl_Estado.BackColor = System.Drawing.Color.Black;
            this.lbl_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Estado.ForeColor = System.Drawing.Color.White;
            this.lbl_Estado.Location = new System.Drawing.Point(751, 493);
            this.lbl_Estado.Name = "lbl_Estado";
            this.lbl_Estado.Size = new System.Drawing.Size(375, 25);
            this.lbl_Estado.TabIndex = 11;
            this.lbl_Estado.Text = "Loading...";
            this.lbl_Estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Estado.Visible = false;
            // 
            // lbl_Duracao
            // 
            this.lbl_Duracao.AutoSize = true;
            this.lbl_Duracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duracao.Location = new System.Drawing.Point(41, 43);
            this.lbl_Duracao.Name = "lbl_Duracao";
            this.lbl_Duracao.Size = new System.Drawing.Size(109, 16);
            this.lbl_Duracao.TabIndex = 12;
            this.lbl_Duracao.Text = "Anime - Duration:";
            // 
            // lbl_Generos
            // 
            this.lbl_Generos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Generos.Location = new System.Drawing.Point(41, 400);
            this.lbl_Generos.Name = "lbl_Generos";
            this.lbl_Generos.Size = new System.Drawing.Size(576, 31);
            this.lbl_Generos.TabIndex = 13;
            this.lbl_Generos.Text = "Genre: ";
            // 
            // lbl_Ano
            // 
            this.lbl_Ano.AutoSize = true;
            this.lbl_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ano.Location = new System.Drawing.Point(41, 481);
            this.lbl_Ano.Name = "lbl_Ano";
            this.lbl_Ano.Size = new System.Drawing.Size(40, 16);
            this.lbl_Ano.TabIndex = 14;
            this.lbl_Ano.Text = "Year:";
            // 
            // lbl_Completo
            // 
            this.lbl_Completo.AutoSize = true;
            this.lbl_Completo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Completo.Location = new System.Drawing.Point(41, 508);
            this.lbl_Completo.Name = "lbl_Completo";
            this.lbl_Completo.Size = new System.Drawing.Size(48, 16);
            this.lbl_Completo.TabIndex = 15;
            this.lbl_Completo.Text = "Status:";
            // 
            // lbl_Tipo
            // 
            this.lbl_Tipo.AutoSize = true;
            this.lbl_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipo.Location = new System.Drawing.Point(41, 535);
            this.lbl_Tipo.Name = "lbl_Tipo";
            this.lbl_Tipo.Size = new System.Drawing.Size(43, 16);
            this.lbl_Tipo.TabIndex = 17;
            this.lbl_Tipo.Text = "Type:";
            // 
            // lbl_Prudotor
            // 
            this.lbl_Prudotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prudotor.Location = new System.Drawing.Point(41, 561);
            this.lbl_Prudotor.Name = "lbl_Prudotor";
            this.lbl_Prudotor.Size = new System.Drawing.Size(704, 26);
            this.lbl_Prudotor.TabIndex = 18;
            this.lbl_Prudotor.Text = "Producer:";
            // 
            // lbl_Studio
            // 
            this.lbl_Studio.AutoSize = true;
            this.lbl_Studio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Studio.Location = new System.Drawing.Point(41, 587);
            this.lbl_Studio.Name = "lbl_Studio";
            this.lbl_Studio.Size = new System.Drawing.Size(49, 16);
            this.lbl_Studio.TabIndex = 19;
            this.lbl_Studio.Text = "Studio:";
            // 
            // lbl_Ep
            // 
            this.lbl_Ep.AutoSize = true;
            this.lbl_Ep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ep.Location = new System.Drawing.Point(41, 456);
            this.lbl_Ep.Name = "lbl_Ep";
            this.lbl_Ep.Size = new System.Drawing.Size(72, 16);
            this.lbl_Ep.TabIndex = 20;
            this.lbl_Ep.Text = "Episodes: ";
            // 
            // pb_Visto
            // 
            this.pb_Visto.Image = global::AnimeList.Properties.Resources.NaoVistos;
            this.pb_Visto.Location = new System.Drawing.Point(95, 156);
            this.pb_Visto.Name = "pb_Visto";
            this.pb_Visto.Size = new System.Drawing.Size(55, 36);
            this.pb_Visto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Visto.TabIndex = 6;
            this.pb_Visto.TabStop = false;
            this.pb_Visto.Click += new System.EventHandler(this.pb_Visto_Click);
            // 
            // pb_Favorito
            // 
            this.pb_Favorito.Image = global::AnimeList.Properties.Resources.NaoFavorito;
            this.pb_Favorito.Location = new System.Drawing.Point(44, 147);
            this.pb_Favorito.Name = "pb_Favorito";
            this.pb_Favorito.Size = new System.Drawing.Size(45, 45);
            this.pb_Favorito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Favorito.TabIndex = 5;
            this.pb_Favorito.TabStop = false;
            this.pb_Favorito.Click += new System.EventHandler(this.pb_Favorito_Click);
            // 
            // pb_Image
            // 
            this.pb_Image.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pb_Image.Location = new System.Drawing.Point(921, 30);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(205, 304);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            // 
            // DescAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 646);
            this.Controls.Add(this.lbl_Ep);
            this.Controls.Add(this.lbl_Studio);
            this.Controls.Add(this.lbl_Prudotor);
            this.Controls.Add(this.lbl_Tipo);
            this.Controls.Add(this.lbl_Completo);
            this.Controls.Add(this.lbl_Ano);
            this.Controls.Add(this.lbl_Generos);
            this.Controls.Add(this.lbl_Duracao);
            this.Controls.Add(this.lbl_Estado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_Visto);
            this.Controls.Add(this.pb_Favorito);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.lbl_TituloOriginal);
            this.Controls.Add(this.lbl_AnimeName);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(this.Media);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DescAnime";
            this.Text = "DescAnime";
            this.Load += new System.EventHandler(this.DescAnime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Visto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Favorito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Label lbl_AnimeName;
        private System.Windows.Forms.Label lbl_TituloOriginal;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.PictureBox pb_Favorito;
        private System.Windows.Forms.PictureBox pb_Visto;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Estado;
        private System.Windows.Forms.Label lbl_Duracao;
        private System.Windows.Forms.Label lbl_Generos;
        private System.Windows.Forms.Label lbl_Ano;
        private System.Windows.Forms.Label lbl_Completo;
        private System.Windows.Forms.Label lbl_Tipo;
        private System.Windows.Forms.Label lbl_Prudotor;
        private System.Windows.Forms.Label lbl_Studio;
        private System.Windows.Forms.Label lbl_Ep;
    }
}