namespace StutterMosher.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.InputFileTextBox = new System.Windows.Forms.TextBox();
            this.InputFileButton = new System.Windows.Forms.Button();
            this.OutputFileButton = new System.Windows.Forms.Button();
            this.OutputFileTextBox = new System.Windows.Forms.TextBox();
            this.InputFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.OutputFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.GoButton = new System.Windows.Forms.Button();
            this.MoshPicker = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MoshPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 17);
            label1.TabIndex = 2;
            label1.Text = "Input File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 58);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 17);
            label2.TabIndex = 5;
            label2.Text = "Output File";
            // 
            // InputFileTextBox
            // 
            this.InputFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFileTextBox.Location = new System.Drawing.Point(7, 33);
            this.InputFileTextBox.Name = "InputFileTextBox";
            this.InputFileTextBox.ReadOnly = true;
            this.InputFileTextBox.Size = new System.Drawing.Size(388, 22);
            this.InputFileTextBox.TabIndex = 0;
            // 
            // InputFileButton
            // 
            this.InputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InputFileButton.Location = new System.Drawing.Point(401, 32);
            this.InputFileButton.Name = "InputFileButton";
            this.InputFileButton.Size = new System.Drawing.Size(75, 23);
            this.InputFileButton.TabIndex = 1;
            this.InputFileButton.Text = "Browse";
            this.InputFileButton.UseVisualStyleBackColor = true;
            this.InputFileButton.Click += new System.EventHandler(this.InputFileButton_Click);
            // 
            // OutputFileButton
            // 
            this.OutputFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFileButton.Location = new System.Drawing.Point(401, 78);
            this.OutputFileButton.Name = "OutputFileButton";
            this.OutputFileButton.Size = new System.Drawing.Size(75, 23);
            this.OutputFileButton.TabIndex = 4;
            this.OutputFileButton.Text = "Browse";
            this.OutputFileButton.UseVisualStyleBackColor = true;
            this.OutputFileButton.Click += new System.EventHandler(this.OutputFileButton_Click);
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputFileTextBox.Location = new System.Drawing.Point(7, 78);
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.ReadOnly = true;
            this.OutputFileTextBox.Size = new System.Drawing.Size(388, 22);
            this.OutputFileTextBox.TabIndex = 3;
            // 
            // InputFileDialog
            // 
            this.InputFileDialog.DefaultExt = "avi";
            this.InputFileDialog.Filter = "MP4 Video Files | *.mp4";
            this.InputFileDialog.RestoreDirectory = true;
            this.InputFileDialog.SupportMultiDottedExtensions = true;
            this.InputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.InputFileDialog_FileOk);
            // 
            // OutputFileDialog
            // 
            this.OutputFileDialog.DefaultExt = "avi";
            this.OutputFileDialog.Filter = "AVI Video Files | *.avi";
            this.OutputFileDialog.RestoreDirectory = true;
            this.OutputFileDialog.SupportMultiDottedExtensions = true;
            this.OutputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OutputFileDialog_FileOk);
            // 
            // GoButton
            // 
            this.GoButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GoButton.Location = new System.Drawing.Point(401, 184);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 6;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // MoshPicker
            // 
            this.MoshPicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoshPicker.Location = new System.Drawing.Point(291, 185);
            this.MoshPicker.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.MoshPicker.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MoshPicker.Name = "MoshPicker";
            this.MoshPicker.Size = new System.Drawing.Size(104, 22);
            this.MoshPicker.TabIndex = 7;
            this.MoshPicker.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mosh Amount:";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.Location = new System.Drawing.Point(7, 184);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(171, 23);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBar.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 219);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MoshPicker);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(label2);
            this.Controls.Add(this.OutputFileButton);
            this.Controls.Add(this.OutputFileTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.InputFileButton);
            this.Controls.Add(this.InputFileTextBox);
            this.Name = "MainForm";
            this.Text = "StutterMosher GUI";
            ((System.ComponentModel.ISupportInitialize)(this.MoshPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputFileTextBox;
        private System.Windows.Forms.Button InputFileButton;
        private System.Windows.Forms.Button OutputFileButton;
        private System.Windows.Forms.TextBox OutputFileTextBox;
        private System.Windows.Forms.OpenFileDialog InputFileDialog;
        private System.Windows.Forms.SaveFileDialog OutputFileDialog;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.NumericUpDown MoshPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar ProgressBar;
    }
}

