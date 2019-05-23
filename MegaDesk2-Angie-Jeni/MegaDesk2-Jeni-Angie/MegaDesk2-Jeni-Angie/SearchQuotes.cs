using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk2_Jeni_Angie
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            var material = new List<Desk.Desktop>();
            material = Enum.GetValues(typeof(Desk.Desktop))
                            .Cast<Desk.Desktop>()
                            .ToList();
            cmbSearchQuoteSurfaceMaterial.DataSource = material;
            //Default empty combo box
            cmbSearchQuoteSurfaceMaterial.SelectedIndex = -1;
        }

        private void btnCloseQuote_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string orderQuotes = @"quotes.json";
            using (StreamReader writeOrderQuotes = new StreamReader(orderQuotes))
            {
                var OrderQuotes = writeOrderQuotes.ReadToEnd();

                List<DeskQuote> list = JsonConvert.DeserializeObject<List<DeskQuote>>(OrderQuotes);

                gridSearchQuotes.DataSource = list.Select(d => new
                {
                    todaysDate = d.todaysDate,
                    CustomerName = d.CustomerName,
                    width = d.getDesk.width,
                    depth = d.getDesk.depth,
                    numOfDrawers = d.getDesk.numOfDrawers,
                    DesktopMaterial = d.getDesk.DesktopMaterial,
                    rushOrder = d.rushOrder,
                    price = d.price
                }).Where(quote => quote.DesktopMaterial.Equals(cmbSearchQuoteSurfaceMaterial.SelectedValue))
                  .ToList();
            }
        }

        private void BtnCloseQuote_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}