using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace StutterMosher.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void InputFileButton_Click(object sender, EventArgs e)
        {
            InputFileDialog.ShowDialog();
        }

        private void InputFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            InputFileTextBox.Text = InputFileDialog.FileName;
        }

        private void OutputFileButton_Click(object sender, EventArgs e)
        {
            OutputFileDialog.ShowDialog();
        }

        private void OutputFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            OutputFileTextBox.Text = OutputFileDialog.FileName;
        }

        private async void GoButton_Click(object sender, EventArgs e)
        {
            using (FileStream inputFile = File.OpenRead(InputFileDialog.FileName))
            using (FileStream outputFile = File.Create(OutputFileDialog.FileName))
            {
                Mosher mosher = new Mosher(inputFile, outputFile);
                mosher.ProgressChanged += Mosher_ProgressChanged;
                await mosher.MoshAsync((int)MoshPicker.Value);
                MessageBox.Show(
                    "Moshing Completed Successfully!", "Success!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                ProgressBar.Value = 0;
            }
        }

        private void Mosher_ProgressChanged(object sender, Mosher.ProgressEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                ProgressBar.Value = (int)(100 * e.Progress);
            }));
        }
    }
}
