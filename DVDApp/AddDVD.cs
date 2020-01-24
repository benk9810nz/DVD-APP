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
    public partial class AddDVD : Form
    {
        public int currentCountFilms { get; set; }
       // int count;
        public DVD Dvd { get; set; }
        public AddDVD()
        {
            InitializeComponent();

        }

        private void AddDVD_Load(object sender, EventArgs e)
        {
            cb_mature.SelectedIndex = 1;
            if (Dvd != null)
            {
                tb_name.Text = Dvd.Name;
                tb_genre.Text = Dvd.Genre;
                nUD_rating.Value = Dvd.Rating;
                cb_mature.SelectedItem = Dvd.MaturityLevel;
            }
            //else
            //{
            //    bt_Save.Enabled = false;
            //}
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            if (Dvd == null)
            {
                Dvd = new DVD(currentCountFilms + 1, tb_name.Text, tb_genre.Text, (int)nUD_rating.Value, cb_mature.Text);
            }
            else
            {
                Dvd.Name = tb_name.Text;
                Dvd.Genre = tb_genre.Text;
                Dvd.Rating = (int) nUD_rating.Value;
                Dvd.MaturityLevel = cb_mature.Text;
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}