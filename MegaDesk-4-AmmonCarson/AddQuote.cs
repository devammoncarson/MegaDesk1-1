using System;
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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            //populate materials combobox
            // var materials = new List<Desk.Material>();
            var materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                .Cast<Desk.SurfaceMaterial>()
                .ToList();

            comboBoxMaterial.DataSource = materials;

            //set default to empty
            comboBoxMaterial.SelectedIndex = -1;
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
 
        }

        private void btnCancelQuote_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void numDepth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numWidth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmitQuote_Click(object sender, EventArgs e)
        {
            var Desk = new Desk()
            {
                Depth = numDepth.Value,
                Width = numWidth.Value,
                NumDrawers = (int)numDrawers.Value,
                Material = (Desk.SurfaceMaterial)comboBoxMaterial.SelectedItem
            };

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelShipping_Click(object sender, EventArgs e)
        {

        }
    }
}
