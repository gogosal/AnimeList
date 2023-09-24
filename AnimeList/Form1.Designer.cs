
namespace AnimeList
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Info = new System.Windows.Forms.Button();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Viewed = new System.Windows.Forms.Button();
            this.btn_Favorite = new System.Windows.Forms.Button();
            this.btn_Profile = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.Layout = new System.Windows.Forms.Panel();
            this.pb_Icon = new System.Windows.Forms.PictureBox();
            this.Update = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.Layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pic_profile, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Exit, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btn_Info, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.txt_Search, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_Viewed, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_Favorite, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_Profile, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_Login, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Home, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.61616F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.38384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(104, 646);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pic_profile
            // 
            this.pic_profile.Image = global::AnimeList.Properties.Resources.Profile;
            this.pic_profile.Location = new System.Drawing.Point(3, 3);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(98, 58);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_profile.TabIndex = 0;
            this.pic_profile.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(3, 610);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(98, 33);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Info
            // 
            this.btn_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.Location = new System.Drawing.Point(3, 567);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(98, 37);
            this.btn_Info.TabIndex = 10;
            this.btn_Info.Text = "Info";
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // txt_Search
            // 
            this.txt_Search.BackColor = System.Drawing.Color.LightSlateGray;
            this.txt_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(3, 264);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(98, 22);
            this.txt_Search.TabIndex = 11;
            this.txt_Search.Text = "Search";
            this.txt_Search.Click += new System.EventHandler(this.txt_Search_Click);
            this.txt_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyDown_1);
            // 
            // btn_Viewed
            // 
            this.btn_Viewed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Viewed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Viewed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Viewed.Location = new System.Drawing.Point(3, 226);
            this.btn_Viewed.Name = "btn_Viewed";
            this.btn_Viewed.Size = new System.Drawing.Size(98, 32);
            this.btn_Viewed.TabIndex = 8;
            this.btn_Viewed.Text = "Viewed";
            this.btn_Viewed.UseVisualStyleBackColor = true;
            this.btn_Viewed.Click += new System.EventHandler(this.btn_Viewed_Click);
            // 
            // btn_Favorite
            // 
            this.btn_Favorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Favorite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Favorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Favorite.Location = new System.Drawing.Point(3, 184);
            this.btn_Favorite.Name = "btn_Favorite";
            this.btn_Favorite.Size = new System.Drawing.Size(98, 36);
            this.btn_Favorite.TabIndex = 7;
            this.btn_Favorite.Text = "Favorite";
            this.btn_Favorite.UseVisualStyleBackColor = true;
            this.btn_Favorite.Click += new System.EventHandler(this.btn_Favorite_Click);
            // 
            // btn_Profile
            // 
            this.btn_Profile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Profile.Location = new System.Drawing.Point(3, 144);
            this.btn_Profile.Name = "btn_Profile";
            this.btn_Profile.Size = new System.Drawing.Size(98, 34);
            this.btn_Profile.TabIndex = 6;
            this.btn_Profile.Text = "Profile";
            this.btn_Profile.UseVisualStyleBackColor = true;
            this.btn_Profile.Click += new System.EventHandler(this.btn_Profile_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(3, 107);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(98, 31);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btn_Home.Location = new System.Drawing.Point(3, 67);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(98, 34);
            this.btn_Home.TabIndex = 13;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // Layout
            // 
            this.Layout.AutoScroll = true;
            this.Layout.Controls.Add(this.pb_Icon);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(104, 0);
            this.Layout.Name = "Layout";
            this.Layout.Size = new System.Drawing.Size(1187, 646);
            this.Layout.TabIndex = 2;
            // 
            // pb_Icon
            // 
            this.pb_Icon.BackColor = System.Drawing.Color.Transparent;
            this.pb_Icon.Image = global::AnimeList.Properties.Resources.Icon;
            this.pb_Icon.Location = new System.Drawing.Point(435, 144);
            this.pb_Icon.Name = "pb_Icon";
            this.pb_Icon.Size = new System.Drawing.Size(364, 364);
            this.pb_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Icon.TabIndex = 0;
            this.pb_Icon.TabStop = false;
            // 
            // Update
            // 
            this.Update.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 646);
            this.ControlBox = false;
            this.Controls.Add(this.Layout);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimeList";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.Layout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Profile;
        private System.Windows.Forms.PictureBox pic_profile;
        private System.Windows.Forms.Button btn_Viewed;
        private System.Windows.Forms.Panel Layout;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Info;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Favorite;
        public System.Windows.Forms.Button btn_Login;
        public System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Timer Update;
        private System.Windows.Forms.PictureBox pb_Icon;
    }
}

