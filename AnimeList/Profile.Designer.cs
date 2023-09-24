
namespace AnimeList
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nVistos = new System.Windows.Forms.Label();
            this.lbl_nFavoritos = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_changepass = new System.Windows.Forms.TextBox();
            this.lbl_changepass = new System.Windows.Forms.Label();
            this.pb_Mostrar = new System.Windows.Forms.PictureBox();
            this.pb_definicoes = new System.Windows.Forms.PictureBox();
            this.pb_Perfil = new System.Windows.Forms.PictureBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mostrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_definicoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(977, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Favoritos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(834, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vistos";
            // 
            // lbl_nVistos
            // 
            this.lbl_nVistos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nVistos.Location = new System.Drawing.Point(834, 153);
            this.lbl_nVistos.Name = "lbl_nVistos";
            this.lbl_nVistos.Size = new System.Drawing.Size(111, 37);
            this.lbl_nVistos.TabIndex = 4;
            this.lbl_nVistos.Text = "0";
            this.lbl_nVistos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nFavoritos
            // 
            this.lbl_nFavoritos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nFavoritos.Location = new System.Drawing.Point(977, 153);
            this.lbl_nFavoritos.Name = "lbl_nFavoritos";
            this.lbl_nFavoritos.Size = new System.Drawing.Size(158, 37);
            this.lbl_nFavoritos.TabIndex = 5;
            this.lbl_nFavoritos.Text = "0";
            this.lbl_nFavoritos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_desc
            // 
            this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desc.Location = new System.Drawing.Point(31, 303);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.Size = new System.Drawing.Size(1104, 311);
            this.txt_desc.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(984, 260);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(151, 37);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Red;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(774, 260);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(204, 37);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Delete Account";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // txt_name
            // 
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(304, 105);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(495, 149);
            this.txt_name.TabIndex = 12;
            this.txt_name.Text = "gogosal";
            // 
            // txt_changepass
            // 
            this.txt_changepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_changepass.Location = new System.Drawing.Point(509, 263);
            this.txt_changepass.Multiline = true;
            this.txt_changepass.Name = "txt_changepass";
            this.txt_changepass.Size = new System.Drawing.Size(198, 31);
            this.txt_changepass.TabIndex = 13;
            // 
            // lbl_changepass
            // 
            this.lbl_changepass.AutoSize = true;
            this.lbl_changepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_changepass.Location = new System.Drawing.Point(303, 266);
            this.lbl_changepass.Name = "lbl_changepass";
            this.lbl_changepass.Size = new System.Drawing.Size(200, 25);
            this.lbl_changepass.TabIndex = 14;
            this.lbl_changepass.Text = "Change password";
            // 
            // pb_Mostrar
            // 
            this.pb_Mostrar.Image = global::AnimeList.Properties.Resources.Mostrar;
            this.pb_Mostrar.Location = new System.Drawing.Point(713, 263);
            this.pb_Mostrar.Name = "pb_Mostrar";
            this.pb_Mostrar.Size = new System.Drawing.Size(55, 31);
            this.pb_Mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Mostrar.TabIndex = 15;
            this.pb_Mostrar.TabStop = false;
            this.pb_Mostrar.Click += new System.EventHandler(this.pb_Mostrar_Click);
            // 
            // pb_definicoes
            // 
            this.pb_definicoes.Image = ((System.Drawing.Image)(resources.GetObject("pb_definicoes.Image")));
            this.pb_definicoes.Location = new System.Drawing.Point(1103, 32);
            this.pb_definicoes.Name = "pb_definicoes";
            this.pb_definicoes.Size = new System.Drawing.Size(32, 32);
            this.pb_definicoes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_definicoes.TabIndex = 9;
            this.pb_definicoes.TabStop = false;
            this.pb_definicoes.Click += new System.EventHandler(this.pb_definicoes_Click);
            // 
            // pb_Perfil
            // 
            this.pb_Perfil.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pb_Perfil.Image = ((System.Drawing.Image)(resources.GetObject("pb_Perfil.Image")));
            this.pb_Perfil.Location = new System.Drawing.Point(31, 32);
            this.pb_Perfil.Name = "pb_Perfil";
            this.pb_Perfil.Size = new System.Drawing.Size(254, 225);
            this.pb_Perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Perfil.TabIndex = 0;
            this.pb_Perfil.TabStop = false;
            this.pb_Perfil.Click += new System.EventHandler(this.pb_Perfil_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(899, 32);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(142, 20);
            this.txt_Search.TabIndex = 16;
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(906, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search by user";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.pb_Mostrar);
            this.Controls.Add(this.lbl_changepass);
            this.Controls.Add(this.txt_changepass);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.pb_definicoes);
            this.Controls.Add(this.lbl_nFavoritos);
            this.Controls.Add(this.lbl_nVistos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_Perfil);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mostrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_definicoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Perfil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nVistos;
        private System.Windows.Forms.Label lbl_nFavoritos;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.PictureBox pb_definicoes;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_changepass;
        private System.Windows.Forms.Label lbl_changepass;
        private System.Windows.Forms.PictureBox pb_Mostrar;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label1;
    }
}