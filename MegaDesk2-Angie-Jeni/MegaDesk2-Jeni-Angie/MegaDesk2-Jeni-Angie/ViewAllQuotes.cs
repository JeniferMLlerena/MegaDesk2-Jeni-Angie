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
using System.Xml;
using Newtonsoft.Json;

namespace MegaDesk2_Jeni_Angie
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {

            // write quotes.json
            // use var OrderQuotes = writeOrderQuotes.ReadToEnd();
            // comment out the while statements and make a list from the json file and add it to the grid. 

            string orderQuotes = @"quotes.json";

            using (StreamReader writeOrderQuotes = new StreamReader(orderQuotes))
            {
                var OrderQuotes = writeOrderQuotes.ReadToEnd();

                List<DeskQuote> list = JsonConvert.DeserializeObject<List<DeskQuote>>(OrderQuotes);

                quoteGrid.DataSource = list.Select(d => new
                {
                    todaysDate = d.todaysDate,
                    CustomerName = d.CustomerName,
                    width = d.getDesk.width,
                    depth = d.getDesk.depth,
                    numOfDrawers = d.getDesk.numOfDrawers,
                    DesktopMaterial = d.getDesk.DesktopMaterial,
                    rushOrder = d.rushOrder,
                    price = d.price
                }).ToList();
                            
            }
        }

        private void btnCloseViewQuotes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }
    }
}