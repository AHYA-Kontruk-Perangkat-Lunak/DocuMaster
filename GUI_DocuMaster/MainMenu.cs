using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DocuMaster
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCompDoc_Click(object sender, EventArgs e)
        {
            CompareDocument CompareDocument = new CompareDocument();
            CompareDocument.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordConverter WordConverter = new WordConverter();
            WordConverter.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HomePage home = new HomePage();
            home.Show();

            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PDFConvert pdf = new PDFConvert();
            pdf.Show();

            this.Hide();
        }
    }
}
