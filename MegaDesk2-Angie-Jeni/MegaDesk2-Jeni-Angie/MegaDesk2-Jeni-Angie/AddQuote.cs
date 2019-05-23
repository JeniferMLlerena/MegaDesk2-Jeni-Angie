using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk2_Jeni_Angie
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            List<Desk.Desktop> materials =
                Enum.GetValues(typeof(Desk.Desktop))
                .Cast<Desk.Desktop>()
                .ToList();

            cmbDesktopMaterial.DataSource = materials;

            //set default to empty
            cmbDesktopMaterial.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void widthNumericUpDown_Validating(object sender, CancelEventArgs e)
        {
            if (widthNumericUpDown.Value < 24 || widthNumericUpDown.Value > 96)
            {
                MessageBox.Show("Please enter a width between 24 and 96", "Error Message",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void depthNumericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (depthNumericUpDown.Value < 12 || depthNumericUpDown.Value > 48)
            {
                LblError.Text = "Please enter depth between 12 and 48";
            }
            else
            {
                LblError.Text = " ";
            }
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            /*var material = new List<Desk.Desktop>();
            material = Enum.GetValues(typeof(Desk.Desktop))
                             .Cast<Desk.Desktop>()
                             .ToList();
            cmbDesktopMaterial.DataSource = material;
            //Default Empty Combo Box
            cmbDesktopMaterial.SelectedIndex = -1;*/
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            // Check form completness

            if (txtCustomerName.Text == "" || cmbRush.Text == "")
            {
                MessageBox.Show("Please fill out all the values", "Form Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Desk megaDesk = new Desk();
            megaDesk.width = widthNumericUpDown.Value;
            megaDesk.depth = depthNumericUpDown.Value;
            megaDesk.numOfDrawers = (int)numUpDownDrawers.Value;
            megaDesk.DesktopMaterial = (Desk.Desktop)cmbDesktopMaterial.SelectedValue;

            DeskQuote megaDeskQuote = new DeskQuote();
            DateTime today = DateTime.Now;
            megaDeskQuote.todaysDate = today;
            megaDeskQuote.CustomerName = txtCustomerName.Text;
            megaDeskQuote.rushOrder = cmbRush.Text;
            megaDeskQuote.getDesk = megaDesk;
            megaDeskQuote.price = megaDeskQuote.GetQuote();
            AddQuoteToJson(megaDeskQuote);


            // Take the json file and convert it to a list
            // add new quotes that are being created to the list
            // Convert the list into a json file

            try
            {
                //Show Display Quote
                DisplayQuote DisplayQuote = new DisplayQuote(megaDeskQuote);
                DisplayQuote.Show();
                Hide();
            }

            catch (Exception err)
            {
                MessageBox.Show("There was an error creating the quote. {0}", err.Message);
            }

        }

        public void AddQuoteToJson(DeskQuote NewDeskQuote)
        {

            string orderQuotes = @"quotes.json";

            if (File.Exists(orderQuotes))
            {
                List<DeskQuote> existingQuote = new List<DeskQuote>();

                using (StreamReader writeOrderQuotes = new StreamReader(orderQuotes))
                {
                    string OrderQuotes = writeOrderQuotes.ReadToEnd();

                    existingQuote = JsonConvert.DeserializeObject<List<DeskQuote>>(OrderQuotes);

                    existingQuote.Add(NewDeskQuote);
                }
                SaveQuotes(existingQuote);
            }
            else
            {
                List<DeskQuote> existingQuote = new List<DeskQuote>();
                existingQuote.Add(NewDeskQuote);
                SaveQuotes(existingQuote);
            }
        }

        private void SaveQuotes(List<DeskQuote> existingQuote)
        {
            var quotesFile = @"quotes.json";

            var OrderQuotes = JsonConvert.SerializeObject(existingQuote);

            File.WriteAllText(quotesFile, OrderQuotes);
        }

        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        

        private void AddQuote_FormClosing(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void AddQuote_Load_1(object sender, EventArgs e)
        {

        }
    }
}