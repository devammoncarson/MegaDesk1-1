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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            //populate materials combobox
            var materials = Enum.GetValues(typeof(Desk.SurfaceMaterial))
                .Cast<Desk.SurfaceMaterial>()
                .ToList();

            comboBoxMaterial.DataSource = materials;
            comboBoxMaterial.SelectedIndex = -1;

            //populate shipping days combobox
            var shippingDays = Enum.GetValues(typeof(DeskQuote.ShippingDays))
                .Cast<DeskQuote.ShippingDays>()
                .ToList();

            comboBoxShipping.DataSource = shippingDays;
            comboBoxShipping.SelectedIndex = -1;
        }

        private void btnSubmitQuote_Click(object sender, EventArgs e)
        {
            var desk = new Desk();
            var deskQuote = new DeskQuote();
            try
            {
                desk.Depth = numDepth.Value;
                desk.Width = numWidth.Value;
                desk.NumDrawers = (int)numDrawers.Value;
                desk.Material = (Desk.SurfaceMaterial)comboBoxMaterial.SelectedItem;

                deskQuote.Desk = desk;
                deskQuote.CustomerName = textCustomerName.Text;
                deskQuote.ShippingRush = (DeskQuote.ShippingDays)comboBoxShipping.SelectedItem;

                deskQuote.QuoteDate = DateTime.Now;
                deskQuote.Quote = deskQuote.getQuote();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error compiling the quote, {0}", ex.Message);
            }

            string quotesFile = @"quotes.txt";

            using (StreamWriter streamwriter = File.AppendText(quotesFile))
            {
                streamwriter.WriteLine(
                $"{deskQuote.CustomerName}, " +
                $"{deskQuote.QuoteDate}, " +
                $"{deskQuote.Desk.Depth}, " +
                $"{deskQuote.Desk.Width}, " +
                $"{deskQuote.Desk.NumDrawers}, " +
                $"{deskQuote.Desk.Material}, " +
                $"{deskQuote.ShippingRush}, " +
                $"{deskQuote.Quote}");
            }

            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();

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

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelShipping_Click(object sender, EventArgs e)
        {

        }
    }
}
