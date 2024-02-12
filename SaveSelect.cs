namespace SR2SaveEditor
{
    public partial class SaveSelect : Form
    {
        public string savPath;
        public void OpenSav()
        {
            var result = OpenSAVFile.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                savPath = OpenSAVFile.FileName;
            }
        }
        public SaveSelect()
        {
            InitializeComponent();

            button1.Click += OpenSav;
        }

        private void OpenSav(object? sender, EventArgs e)
        {
            OpenSav();
        }

        private void SaveSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
