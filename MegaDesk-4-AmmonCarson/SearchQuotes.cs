using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_AmmonCarson
{
    public partial class SearchQuotes : Form
    {
        public string [] deskQuotes;
        public SearchQuotes()
        {
            InitializeComponent();
            loadGrid();

            var materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                            .Cast<Desk.SurfaceMaterial>()
                            .ToList();

            comSearchMaterials.DataSource = materials;

            comSearchMaterials.SelectedIndex = -1;
        }

        private void loadGrid()
        {
            try
            {
                deskQuotes = File.ReadAllLines(@"quotes.txt");
                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    dataGridView1.Rows.Add(arrRow);
                }

            }
            catch (FileNotFoundException)
            {

            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comSearchMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (string deskQuote in deskQuotes)
            {
                switch (comSearchMaterials.SelectedIndex)
                {
                    case 0:
                        if (deskQuote.Contains("Oak")) {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            dataGridView1.Rows.Add(arrRow);
                        }
                        break;
                    case 1:
                        if (deskQuote.Contains("Laminate"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            dataGridView1.Rows.Add(arrRow);
                        }
                        break;
                    case 2:
                        if (deskQuote.Contains("Pine"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            dataGridView1.Rows.Add(arrRow);
                        }
                        break;
                    case 3:
                        if (deskQuote.Contains("Rosewood"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            dataGridView1.Rows.Add(arrRow);
                        }
                        break;
                    case 4:
                        if (deskQuote.Contains("Veneer"))
                        {
                            string[] arrRow = deskQuote.Split(new char[] { ',' });
                            dataGridView1.Rows.Add(arrRow);
                        }
                        break;
                }
            }
        }
    }
}

