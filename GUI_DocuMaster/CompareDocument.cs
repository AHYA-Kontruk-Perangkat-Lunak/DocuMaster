using System;
using System.IO;
using System.Linq;
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
            this.FormClosed += (s, e) => Application.Exit();
        }

        // Handler untuk Browse file 1
        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            txtFile1.Text = BrowseFile();
        }

        // Handler untuk Browse file 2
        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            txtFile2.Text = BrowseFile();
        }

        // Fungsi buka file dialog (mengurangi duplikasi kode)
        private string BrowseFile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Supported Files (*.txt;*.docx;*.pdf)|*.txt;*.docx;*.pdf|All Files (*.*)|*.*";
                return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : "";
            }
        }

        // Handler tombol Compare
        private void btnCompare_Click(object sender, EventArgs e)
        {
            string path1 = txtFile1.Text;
            string path2 = txtFile2.Text;

            if (!File.Exists(path1) || !File.Exists(path2))
            {
                MessageBox.Show("Pilih dua file (.txt, .docx, .pdf) terlebih dahulu.");
                return;
            }

            try
            {
                // Ambil statistik kedua file
                string stats1 = StatisticsHelper.GetTextStatistics(path1);
                string stats2 = StatisticsHelper.GetTextStatistics(path2);

                // Hitung persentase kemiripan
                double similarity = SimilarityHelper.CalculateJaccardSimilarity(path1, path2);

                // Tampilkan statistik dan persentase saja
                rtbResult.Text =
                    stats1 + "\n\n" +
                    stats2 + "\n\n" +
                    $"Persentase kemiripan (berdasarkan kata unik): {similarity:F2}%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat membandingkan file: " + ex.Message);
            }
        }

        // Handler tombol Back
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}