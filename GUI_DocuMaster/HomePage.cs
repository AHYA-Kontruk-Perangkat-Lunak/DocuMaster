namespace GUI_DocuMaster
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show(); // Tampilkan form main menu

            this.Hide();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
