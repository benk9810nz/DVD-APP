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
    public partial class Form1 : Form
    {
        public DVD currentDVD { get; set; }
        List<DVD> dvds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateColumns();
            DB db = new DB();
            dvds = db.GetDVDs();
            
            foreach (DVD dvd in dvds) generateListViewItems(dvd);
            ColourRows();
        }

        private void generateListViewItems(DVD dVD)
        {
            ListViewItem line = new ListViewItem(dVD.Name);
            line.Tag = dVD;
            line.SubItems.Add(dVD.Genre);
            line.SubItems.Add(dVD.Rating.ToString());
            line.SubItems.Add(dVD.MaturityLevel);
            listView.Items.Add(line);
        }

        private void ColourRows()
        {
            for (int i = 0; i < listView.Items.Count; i++)
            {
                if (i % 2 == 0)
                {
                    listView.Items[i].BackColor = Color.Black;
                    listView.Items[i].ForeColor = Color.White;
                }
                else
                {
                    listView.Items[i].BackColor = Color.LightGray;
                    listView.Items[i].ForeColor = Color.Black;
                }
            }

        }

        private void GenerateColumns()
        {
            listView.Columns.Add("Name");
            listView.Columns[0].Width = 200;
            listView.Columns.Add("Genre");
            listView.Columns[1].Width = 100;
            listView.Columns.Add("Rating");
            listView.Columns[2].Width = 50;
            listView.Columns.Add("Maturity Level");
            listView.Columns[3].Width = 100;
        }

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem lvi = listView.SelectedItems[0];
            currentDVD = lvi.Tag as DVD;
            //MessageBox.Show(currentDVD.Name);

            using (AddDVD dvdForm = new AddDVD())
            {
                dvdForm.Dvd = currentDVD;
                if (dvdForm.ShowDialog() == DialogResult.OK)
                {
                    DVD returnedDVD = dvdForm.Dvd;
                    lvi.Tag = returnedDVD;
                    lvi.SubItems[0].Text = returnedDVD.Name;
                    lvi.SubItems[1].Text = returnedDVD.Genre;
                    lvi.SubItems[2].Text = returnedDVD.Rating.ToString();
                    lvi.SubItems[3].Text = returnedDVD.MaturityLevel;

                    for (int i = 0; i < dvds.Count; i++)
                    {
                        if (dvds[i].ID == returnedDVD.ID)
                        {
                            dvds[i] = returnedDVD;
                            //MessageBox.Show(dvds[i].Name);
                            int result = DB.UpdateDVD(returnedDVD);
                            MessageBox.Show(String.Format("{0} DVD Updated", result.ToString()));
                        }
                    }

                }
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            using (AddDVD addDVD = new AddDVD())
            {
                addDVD.currentCountFilms = dvds.Count();
                if (addDVD.ShowDialog() == DialogResult.OK)
                {
                    DVD newDVD = addDVD.Dvd;
                    generateListViewItems(newDVD);
                    int r = DB.AddDVD(newDVD);
                    if (r > 0)
                    {
                        MessageBox.Show(r.ToString() + " DVD Added");
                    }
                    else MessageBox.Show(r.ToString());
                }
            }
            ColourRows();
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            if (listView.CheckedItems.Count > 0)
            {
                foreach (ListViewItem listView in listView.CheckedItems)
                {
                    DB.DeleteDVD(listView.Tag as DVD);
                    listView.Remove();
                }
            }
            else MessageBox.Show("You need to tick at least 1 DVD Checkbox");
        }
    }
}