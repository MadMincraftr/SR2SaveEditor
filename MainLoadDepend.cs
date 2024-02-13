using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SR2SaveEditor
{
    public partial class MainLoadDepend : Form
    {
        public string DLLPath => DLLPathPreview.Text;
        public void SelectAssemblyFunction()
        {
            var result = SelectAssembly.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DLLPathPreview.Text = SelectAssembly.FileName;
            }
        }
        public void LoadAssembly()
        {
            Program.gameCode = Assembly.LoadFile(DLLPathPreview.Text);
            Hide();
            new SaveSelect().ShowDialog(null);
            Show();
        }
        public MainLoadDepend()
        {
            InitializeComponent();
            DLLLoad.Click += button2_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectAssemblyFunction();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            LoadAssembly();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
