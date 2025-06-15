using System;
using System.Windows.Forms;

namespace GUI_DocuMaster
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        private void btnCompDoc_Click(object sender, EventArgs e)
        {
            var compareForm = new CompareDocument();
            compareForm.Show();
            this.Hide();
        }

        private void btnConvertPDF_Click(object sender, EventArgs e)
        {
            var pdfConvert = new PDFConvert();
            pdfConvert.Show();
            this.Hide();
        }

        private void btncConvertWord_Click(object sender, EventArgs e)
        {
            var wordConverter = new WordConverter();
            wordConverter.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void pBoxSummary_Click(object sender, EventArgs e)
        {
            var summaryForm = new SummaryGenerator();
            summaryForm.Show();
            this.Hide();
        }
    }
}