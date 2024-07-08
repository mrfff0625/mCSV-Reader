using System;
using System.Windows.Forms;

namespace CsvReader
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void lnkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mrfff0625/mCSV");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
