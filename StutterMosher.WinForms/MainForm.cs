using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
