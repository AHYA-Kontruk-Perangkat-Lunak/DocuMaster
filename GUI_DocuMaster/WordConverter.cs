using Spire.Doc;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_DocuMaster
{
    public partial class WordConverter : Form
    {
        public WordConverter()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => Application.Exit();
        }

        // Inisialisasi awal saat form dimuat
        private void WordConverter_Load(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty; // Kosongkan status pesan dari sesi sebelumnya
        }

        // Event handler untuk tombol "Browse"
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Menampilkan dialog untuk memilih file input .txt
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TBFilePath.Text = openFileDialog.FileName;
                    lblStatus.Text = string.Empty; // Reset pesan status sebelumnya
                }
            }
        }

        // Event handler untuk tombol "Convert to Word"
        private async void btnConvertWord_Click(object sender, EventArgs e)
        {
            // Validasi awal: pastikan file yang dipilih valid dan eksis
            if (!IsValidInputFile(TBFilePath.Text))
            {
                ShowStatus("❌ File tidak valid.", Color.Red);
                return;
            }

            // Tampilkan dialog simpan untuk menentukan lokasi dan nama file output
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(TBFilePath.Text) + ".docx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ShowStatus("⏳ Sedang mengonversi...", Color.Black); // Feedback proses berjalan

                    try
                    {
                        // Jalankan proses konversi secara asynchronous agar UI tetap responsif
                        await ConvertTextFileToWordAsync(TBFilePath.Text, saveFileDialog.FileName);

                        ShowStatus("✅ Word berhasil disimpan!", Color.Green); // Feedback sukses
                    }
                    catch (Exception ex)
                    {
                        // Tangani kesalahan dan tampilkan ke user (tanpa crash)
                        ShowStatus($"❌ Terjadi kesalahan: {ex.Message}", Color.Red);
                    }
                }
            }
        }

        // Fungsi utama konversi dari .txt ke .docx menggunakan library FreeSpire.Doc
        private async Task ConvertTextFileToWordAsync(string inputPath, string outputPath)
        {
            await Task.Run(() =>
            {
                string content = File.ReadAllText(inputPath); // Ambil isi file .txt

                Document doc = new Document(); // Buat dokumen baru
                Section section = doc.AddSection();
                section.AddParagraph().AppendText(content); // Tambahkan isi ke paragraf

                doc.SaveToFile(outputPath, FileFormat.Docx); // Simpan sebagai .docx
            });
        }

        // Fungsi validasi: periksa apakah file ada dan tidak kosong
        private bool IsValidInputFile(string path)
        {
            return !string.IsNullOrWhiteSpace(path) && File.Exists(path);
        }

        // Fungsi utilitas: tampilkan pesan status ke user
        private void ShowStatus(string message, Color color)
        {
            lblStatus.ForeColor = color;
            lblStatus.Text = message;
        }

        // Navigasi kembali ke halaman menu utama
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide(); // Sembunyikan form saat ini untuk hindari duplikasi tampilan
        }

        // Navigasi alternatif (redundan tapi dipertahankan jika dipakai layout)
        private void button4_Click(object sender, EventArgs e)
        {
            btnBack_Click(sender, e); // Alihkan ke handler utama
        }

        private void lblFilePath_Click(object sender, EventArgs e)
        {
            // Kosongkan atau isi sesuai kebutuhan
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Kosongkan atau isi sesuai kebutuhan
        }
    }
}
