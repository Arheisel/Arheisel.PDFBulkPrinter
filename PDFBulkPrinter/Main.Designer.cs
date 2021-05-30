namespace ArheiselPDFBulkPrinter
{
    partial class Main
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
            this.fileListBox = new System.Windows.Forms.ListBox();
            this.currDir = new System.Windows.Forms.TextBox();
            this.dirButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.printerList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileListBox
            // 
            this.fileListBox.FormattingEnabled = true;
            this.fileListBox.Location = new System.Drawing.Point(13, 39);
            this.fileListBox.Name = "fileListBox";
            this.fileListBox.Size = new System.Drawing.Size(347, 316);
            this.fileListBox.TabIndex = 0;
            // 
            // currDir
            // 
            this.currDir.Location = new System.Drawing.Point(13, 13);
            this.currDir.Name = "currDir";
            this.currDir.ReadOnly = true;
            this.currDir.Size = new System.Drawing.Size(266, 20);
            this.currDir.TabIndex = 1;
            // 
            // dirButton
            // 
            this.dirButton.Location = new System.Drawing.Point(286, 12);
            this.dirButton.Name = "dirButton";
            this.dirButton.Size = new System.Drawing.Size(75, 21);
            this.dirButton.TabIndex = 3;
            this.dirButton.Text = "Change";
            this.dirButton.UseVisualStyleBackColor = true;
            this.dirButton.Click += new System.EventHandler(this.DirButton_Click);
            // 
            // printButton
            // 
            this.printButton.Enabled = false;
            this.printButton.Location = new System.Drawing.Point(13, 388);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(348, 25);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // printerList
            // 
            this.printerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.printerList.FormattingEnabled = true;
            this.printerList.Location = new System.Drawing.Point(13, 361);
            this.printerList.Name = "printerList";
            this.printerList.Size = new System.Drawing.Size(347, 21);
            this.printerList.TabIndex = 5;
            this.printerList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status: Select File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printerList);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.dirButton);
            this.Controls.Add(this.currDir);
            this.Controls.Add(this.fileListBox);
            this.Name = "Main";
            this.Text = "PDF Bulk Printer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox fileListBox;
        private System.Windows.Forms.TextBox currDir;
        private System.Windows.Forms.Button dirButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.ComboBox printerList;
        private System.Windows.Forms.Label label1;
    }
}

