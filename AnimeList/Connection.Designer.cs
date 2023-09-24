namespace AnimeList
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.rbt_Local = new System.Windows.Forms.RadioButton();
            this.rbt_School = new System.Windows.Forms.RadioButton();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbt_Local
            // 
            this.rbt_Local.AutoSize = true;
            this.rbt_Local.Location = new System.Drawing.Point(109, 21);
            this.rbt_Local.Name = "rbt_Local";
            this.rbt_Local.Size = new System.Drawing.Size(49, 17);
            this.rbt_Local.TabIndex = 0;
            this.rbt_Local.TabStop = true;
            this.rbt_Local.Text = "3306";
            this.rbt_Local.UseVisualStyleBackColor = true;
            // 
            // rbt_School
            // 
            this.rbt_School.AutoSize = true;
            this.rbt_School.Location = new System.Drawing.Point(109, 44);
            this.rbt_School.Name = "rbt_School";
            this.rbt_School.Size = new System.Drawing.Size(49, 17);
            this.rbt_School.TabIndex = 1;
            this.rbt_School.TabStop = true;
            this.rbt_School.Text = "3307";
            this.rbt_School.UseVisualStyleBackColor = true;
            // 
            // btn_Ok
            // 
            this.btn_Ok.Location = new System.Drawing.Point(67, 70);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(75, 23);
            this.btn_Ok.TabIndex = 2;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Local:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "School:";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 105);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.rbt_School);
            this.Controls.Add(this.rbt_Local);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbt_Local;
        private System.Windows.Forms.RadioButton rbt_School;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}