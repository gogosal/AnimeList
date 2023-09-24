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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AnimeList
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();

            if (rbt_Local.Checked)
            {
                Globais.connect = 3306;
                menu.Show();
                this.Hide();
            }
            if (rbt_School.Checked)
            {
                Globais.connect = 3307;
                menu.Show();
                this.Hide();
            }
        }
    }
}
