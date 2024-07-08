using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CsvReader
{
    public partial class MainForm : Form
    {
        #region Window_Stuff

        public MainForm()
        {
            InitializeComponent();
        }

        #endregion Window_Stuff

        #region Menu_Stuff

        private void msiOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void msiClose_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void msiQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msiHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mrfff.ct8.pl/programs/mcsv-reader");
        }

        private void msiAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        #endregion Menu_Stuff

        #region Grid_Stuff

        private void OpenFile()
        {
            string filePath = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CloseFile();

                filePath = openFileDialog.FileName;

                string fileName = Path.GetFileName(filePath);
                Text = "mCSV Reader - " + fileName;

                string fileContent = File.ReadAllText(filePath);
                InterpretCsv(fileContent);
            }
        }

        private void CloseFile()
        {
            dgvGrid.Columns.Clear();
            dgvGrid.Rows.Clear();

            Text = "mCSV Reader";
        }

        #endregion Grid_Stuff

        #region Csv_Stuff

        private void InterpretCsv(string csv)
        {
            try
            {
                string[] recordsArray = csv.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
                string[] headers = recordsArray[0].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                List<string> records = new List<string>(recordsArray);
                records.RemoveAt(0);

                foreach (string header in headers)
                {
                    dgvGrid.Columns.Add(header, header);
                }

                foreach (string record in records)
                {
                    string[] fields = record.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                    dgvGrid.Rows.Add(fields);
                }
            }
            catch
            {
                MessageBox.Show("Program couldn't read the file specified.", "mCSV Reader", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion Csv_Stuff
    }
}
