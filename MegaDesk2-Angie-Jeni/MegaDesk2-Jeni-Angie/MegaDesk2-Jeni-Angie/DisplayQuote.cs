using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk2_Jeni_Angie
{
    public partial class DisplayQuote : Form
    {
        private DeskQuote _deskQuote;

        public DisplayQuote(DeskQuote deskQuote)
        {

            InitializeComponent();

            _deskQuote = deskQuote;

            txtCustomerName.Text = _deskQuote.CustomerName;
            numUpDownDrawers.Value = _deskQuote.getDesk.numOfDrawers;
            widthNumericUpDown.Value = _deskQuote.getDesk.width;
            depthNumericUpDown.Value = _deskQuote.getDesk.depth;
            cmbDesktopMaterial.Text = _deskQuote.getDesk.DesktopMaterial.ToString();
            cmbRush.Text = _deskQuote.rushOrder;
            lblShowTotalCost.Text = _deskQuote.price.ToString();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
