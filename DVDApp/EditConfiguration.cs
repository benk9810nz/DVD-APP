using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVDApp
{
    public partial class EditConfiguration : Form
    {
        public EditConfiguration()
        {
            InitializeComponent();
        }

        private void EditConfiguration_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            MessageBox.Show("Unable to connect to the MYSQL Server. Please check the configuration Options", "Connection Error", MessageBoxButtons.OK);
            tb_dbe.Text = Properties.Settings.Default.Database;
            TB_IP.Text = Properties.Settings.Default.severaddress;
            TB_Username.Text = Properties.Settings.Default.username;
            TB_Password.Text = Properties.Settings.Default.password;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Database = tb_dbe.Text;
            Properties.Settings.Default.severaddress = TB_IP.Text;
            Properties.Settings.Default.password = TB_Password.Text;
            Properties.Settings.Default.username = TB_Username.Text;
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void BT_Discard_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Force Exit the Application
        }
    }
}
