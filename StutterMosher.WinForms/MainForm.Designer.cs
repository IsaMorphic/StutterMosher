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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputFileTextBox
            // 
            this.InputFileTextBox.Location = new System.Drawing.Point(7, 33);
            this.InputFileTextBox.Name = "InputFileTextBox";
            this.InputFileTextBox.ReadOnly = true;
            this.InputFileTextBox.Size = new System.Drawing.Size(220, 22);
            this.InputFileTextBox.TabIndex = 0;
            // 
            // InputFileButton
            // 
            this.InputFileButton.Location = new System.Drawing.Point(233, 33);
            this.InputFileButton.Name = "InputFileButton";
            this.InputFileButton.Size = new System.Drawing.Size(75, 23);
            this.InputFileButton.TabIndex = 1;
            this.InputFileButton.Text = "Browse";
            this.InputFileButton.UseVisualStyleBackColor = true;
            this.InputFileButton.Click += new System.EventHandler(this.InputFileButton_Click);
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
            // OutputFileButton
            // 
            this.OutputFileButton.Location = new System.Drawing.Point(233, 78);
            this.OutputFileButton.Name = "OutputFileButton";
            this.OutputFileButton.Size = new System.Drawing.Size(75, 23);
            this.OutputFileButton.TabIndex = 4;
            this.OutputFileButton.Text = "Browse";
            this.OutputFileButton.UseVisualStyleBackColor = true;
            this.OutputFileButton.Click += new System.EventHandler(this.OutputFileButton_Click);
            // 
            // OutputFileTextBox
            // 
            this.OutputFileTextBox.Location = new System.Drawing.Point(7, 78);
            this.OutputFileTextBox.Name = "OutputFileTextBox";
            this.OutputFileTextBox.ReadOnly = true;
            this.OutputFileTextBox.Size = new System.Drawing.Size(220, 22);
            this.OutputFileTextBox.TabIndex = 3;
            // 
            // InputFileDialog
            // 
            this.InputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.InputFileDialog_FileOk);
            // 
            // OutputFileDialog
            // 
            this.OutputFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OutputFileDialog_FileOk);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 219);
            this.Controls.Add(label2);
            this.Controls.Add(this.OutputFileButton);
            this.Controls.Add(this.OutputFileTextBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.InputFileButton);
            this.Controls.Add(this.InputFileTextBox);
            this.Name = "MainForm";
            this.Text = "StutterMosher GUI";
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
    }
}

