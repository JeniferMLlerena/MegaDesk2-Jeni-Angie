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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuoteForm = new AddQuote();
            addNewQuoteForm.Tag = this;
            addNewQuoteForm.Show(this);
            Hide();
        }


        private void BtnViewAllQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes ViewAllQuotesForm = new ViewAllQuotes();
            ViewAllQuotesForm.Tag = this;
            ViewAllQuotesForm.Show(this);
            Hide();
        }

        private void BtnSearchQuote_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuoteForm = new SearchQuotes();
            SearchQuoteForm.Tag = this;
            SearchQuoteForm.Show(this);
            Hide();
        }

        private void BtnCloseApp_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
