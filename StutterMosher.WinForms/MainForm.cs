using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
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
            GoButton.Enabled = false;
            await Task.Factory.StartNew(ConvertInputFile);

            using (FileStream inputFile = File.OpenRead("input.avi"))
            using (FileStream outputFile = File.Create(OutputFileDialog.FileName))
            {
                Mosher mosher = new Mosher(inputFile, outputFile);
                mosher.ProgressChanged += Mosher_ProgressChanged;
                await mosher.MoshAsync((int)MoshPicker.Value);
            }

            DialogResult msgResult = MessageBox.Show(
                    "Moshing Completed Successfully! Would you like to view the results?", "Success!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information
                    );

            if(msgResult == DialogResult.Yes)
                Process.Start(OutputFileDialog.FileName);

            ProgressBar.Value = 0;
            GoButton.Enabled = true;
        }

        private void Mosher_ProgressChanged(object sender, Mosher.ProgressEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                ProgressBar.Value = (int)(100 * e.Progress);
            }));
        }

        private void ConvertInputFile()
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "ffmpeg.exe",
                Arguments = $"-y -i \"{InputFileDialog.FileName}\" -ss {StartTime.Text} -to {EndTime.Text} \"input.avi\""
            }).WaitForExit();
        }
    }
}
