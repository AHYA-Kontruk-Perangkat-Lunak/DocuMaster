using Spire.Pdf;
using Spire.Pdf.Graphics;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI_DocuMaster
{
    public partial class PDFConvert : Form
    {
        string filePath = "";

        public PDFConvert()
        {
            InitializeComponent();
            this.BackColor = Color.LightYellow;
            this.Text = "PDFConvert";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filePath = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                textBox1.Text = filePath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                MessageBox.Show("Silakan pilih file TXT terlebih dahulu.", "Peringatan");
                return;
            }

            try
            {
                string text = File.ReadAllText(filePath);

                PdfDocument doc = new PdfDocument();
                PdfPageBase page = doc.Pages.Add();
                PdfFont font = new PdfFont(PdfFontFamily.Helvetica, 12);
                PdfSolidBrush brush = new PdfSolidBrush(Color.Black);
                PdfStringFormat format = new PdfStringFormat();

                RectangleF rect = new RectangleF(0, 0, page.Canvas.ClientSize.Width, page.Canvas.ClientSize.Height);
                page.Canvas.DrawString(text, font, brush, rect, format);

                string outputPdf = Path.ChangeExtension(filePath, ".pdf");
                doc.SaveToFile(outputPdf);
                doc.Close();

                MessageBox.Show("Berhasil dikonversi ke PDF:\n" + outputPdf, "Sukses");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

            this.Hide();
        }
    }
}
