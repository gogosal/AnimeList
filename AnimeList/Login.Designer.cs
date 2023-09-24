
namespace AnimeList
{
    partial class Login
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
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_GoCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Username
            // 
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Location = new System.Drawing.Point(444, 193);
            this.txt_Username.Multiline = true;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(234, 30);
            this.txt_Username.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(444, 275);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(234, 30);
            this.txt_Password.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(444, 335);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(234, 42);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_GoCreate
            // 
            this.btn_GoCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GoCreate.Location = new System.Drawing.Point(444, 392);
            this.btn_GoCreate.Name = "btn_GoCreate";
            this.btn_GoCreate.Size = new System.Drawing.Size(234, 42);
            this.btn_GoCreate.TabIndex = 4;
            this.btn_GoCreate.Text = "Create Account";
            this.btn_GoCreate.UseVisualStyleBackColor = true;
            this.btn_GoCreate.Click += new System.EventHandler(this.btn_GoCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label1.Location = new System.Drawing.Point(439, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(439, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GoCreate);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_GoCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}