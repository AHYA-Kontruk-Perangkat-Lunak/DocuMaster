using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_DocuMaster.Helpers; 

namespace GUI_DocuMaster
{
    public partial class SummaryGenerator : Form
    {
        private ISummaryStrategy summaryStrategy; 
        private IFileParser fileParser;

        public SummaryGenerator()
        {
            InitializeComponent();

            string token = "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";
            summaryStrategy = new HuggingFaceSummaryStrategy(token);
        }

        // Fungsi untuk memilih file
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Supported Files (*.txt;*.docx;*.pdf)|*.txt;*.docx;*.pdf|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        // Fungsi untuk merangkum isi file
        private async void button2_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Silakan pilih file terlebih dahulu.");
                return;
            }

            string ext = Path.GetExtension(filePath).ToLower();
            switch (ext)
            {
                case ".txt":
                    fileParser = new TxtFileParser();
                    break;
                case ".docx":
                    fileParser = new DocxFileParser();
                    break;
                case ".pdf":
                    fileParser = new PdfFileParser();
                    break;
                default:
                    MessageBox.Show("Format file tidak didukung.");
                    return;
            }

            try
            {
                string content = await fileParser.ParseAsync(filePath);
                if (content.Length > 1000)
                    content = content.Substring(0, 1000);

                string summary = await summaryStrategy.SummarizeAsync(content);
                richTextBox1.Text = summary;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memproses file: " + ex.Message);
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenuForm = new MainMenu();
            mainMenuForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 2 clicked!");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 3 clicked!");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 4 clicked!");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Label 5 clicked!");
        }
    }
}
