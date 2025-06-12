using Spire.Doc;
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
    public partial class WordConverter : Form
    {
        public WordConverter()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void WordConverter_Load(object sender, EventArgs e)
        {

        }

        private void lblFilePath_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                TBFilePath.Text = openFile.FileName;
                lblStatus.Text = "";
            }
        }

        private async void btnConvertWord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBFilePath.Text) || !File.Exists(TBFilePath.Text))
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "❌ File tidak valid.";
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Word Document (*.docx)|*.docx";
            saveDialog.FileName = Path.GetFileNameWithoutExtension(TBFilePath.Text) + ".docx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                lblStatus.ForeColor = Color.Black;
                lblStatus.Text = "⏳ Sedang mengonversi...";

                await Task.Run(() =>
                {
                    string content = File.ReadAllText(TBFilePath.Text);

                    Document doc = new Document();
                    Section section = doc.AddSection();
                    section.AddParagraph().AppendText(content);
                    doc.SaveToFile(saveDialog.FileName, FileFormat.Docx);
                });

                lblStatus.ForeColor = Color.Green;
                lblStatus.Text = "✅ Word berhasil disimpan!";
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

            this.Hide();
        }
    }
}
