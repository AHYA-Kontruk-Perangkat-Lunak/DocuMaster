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

<<<<<<< HEAD
        private void button4_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();

=======
        private void button1_Click(object sender, EventArgs e)
        {
            WordConverter WordConverter = new WordConverter();
            WordConverter.Show();
>>>>>>> 73369d1d8f17854e2671ed746988a338ef2133b1
            this.Hide();
        }
    }
}
