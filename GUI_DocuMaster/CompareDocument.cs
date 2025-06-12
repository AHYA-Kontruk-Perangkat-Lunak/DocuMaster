using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocuMaster.Helpers;
using GUI_DocuMaster.Helpers;

namespace GUI_DocuMaster
{
    public partial class CompareDocument : Form
    {
        public CompareDocument()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Supported Files (*.txt;*.docx;*.pdf)|*.txt;*.docx;*.pdf|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Supported Files (*.txt;*.docx;*.pdf)|*.txt;*.docx;*.pdf|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = ofd.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path1 = textBox1.Text;
            string path2 = textBox2.Text;

            if (File.Exists(path1) && File.Exists(path2))
            {
                // Ambil statistik
                string stats1 = StatisticsHelper.GetTextStatistics(path1);
                string stats2 = StatisticsHelper.GetTextStatistics(path2);

                // Bandingkan file
                var perbedaan = DocumentComparer.CompareFiles(path1, path2);

                string hasilPerbedaan = "";
                if (perbedaan.Count == 0)
                {
                    hasilPerbedaan = "Dokumen sama persis!";
                }
                //else
                //{
                //    hasilPerbedaan = "Perbedaan ditemukan di baris:\n\n";
                //    foreach (var beda in perbedaan)
                //    {
                //        hasilPerbedaan += $"Baris {beda.Baris}:\nFile 1: {beda.Text1}\n\nFile 2: {beda.Text2}\n\n";
                //    }
                //}

                // Gabungkan hasil statistik + hasil compare ke RichTextBox
                richTextBox1.Text = stats1 + "\n" + stats2 + "\n" + hasilPerbedaan;

                double persentase = SimilarityHelper.CalculateJaccardSimilarity(path1, path2);

                richTextBox1.Text =
                    stats1 + "\n" + stats2 +
                    $"\nPersentase kemiripan (berdasarkan kata unik): {persentase:F2}%" +
                    "\n" + hasilPerbedaan;
            }
            else
            {
                MessageBox.Show("Pilih dua file .txt terlebih dahulu.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();

            this.Hide();
        }

        private void CompareDocument_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
