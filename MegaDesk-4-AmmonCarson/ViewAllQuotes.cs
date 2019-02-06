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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
            loadGrid();
        }

        private void loadGrid()
        {
            try
            {
                string[] deskQuotes = File.ReadAllLines(@"quotes.txt");
                foreach (string deskQuote in deskQuotes)
                {
                    string[] arrRow = deskQuote.Split(new char[] { ',' });
                    dataGridView1.Rows.Add(arrRow);
                }

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No quotes have been created.");
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
    }
}
