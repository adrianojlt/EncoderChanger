namespace RemoveAccents
{
    partial class Form
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
            this.openDirButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openDirDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileButton = new System.Windows.Forms.Button();
            this.pathFile = new System.Windows.Forms.RichTextBox();
            this.pathDir = new System.Windows.Forms.RichTextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.encodingList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.removeAccentsCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // openDirButton
            // 
            this.openDirButton.Location = new System.Drawing.Point(11, 30);
            this.openDirButton.Margin = new System.Windows.Forms.Padding(2);
            this.openDirButton.Name = "openDirButton";
            this.openDirButton.Size = new System.Drawing.Size(56, 19);
            this.openDirButton.TabIndex = 0;
            this.openDirButton.Text = "add dir";
            this.openDirButton.UseVisualStyleBackColor = true;
            this.openDirButton.Click += new System.EventHandler(this.openDirButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(11, 7);
            this.openFileButton.Margin = new System.Windows.Forms.Padding(2);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(56, 19);
            this.openFileButton.TabIndex = 1;
            this.openFileButton.Text = "add file";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // pathFile
            // 
            this.pathFile.Location = new System.Drawing.Point(71, 7);
            this.pathFile.Margin = new System.Windows.Forms.Padding(2);
            this.pathFile.Name = "pathFile";
            this.pathFile.ReadOnly = true;
            this.pathFile.Size = new System.Drawing.Size(461, 19);
            this.pathFile.TabIndex = 4;
            this.pathFile.Text = "";
            // 
            // pathDir
            // 
            this.pathDir.Location = new System.Drawing.Point(71, 30);
            this.pathDir.Margin = new System.Windows.Forms.Padding(2);
            this.pathDir.Name = "pathDir";
            this.pathDir.Size = new System.Drawing.Size(461, 19);
            this.pathDir.TabIndex = 5;
            this.pathDir.Text = "";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(11, 53);
            this.listBox.Margin = new System.Windows.Forms.Padding(2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(521, 147);
            this.listBox.TabIndex = 9;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_selectedIndexChanged);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.removeAccentsButton_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(164, 233);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(457, 205);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Green;
            this.infoLabel.Location = new System.Drawing.Point(68, 271);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 16);
            this.infoLabel.TabIndex = 14;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // encodingList
            // 
            this.encodingList.FormattingEnabled = true;
            this.encodingList.Location = new System.Drawing.Point(12, 207);
            this.encodingList.Name = "encodingList";
            this.encodingList.Size = new System.Drawing.Size(121, 21);
            this.encodingList.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "INFO: ";
            // 
            // removeAccentsCB
            // 
            this.removeAccentsCB.AutoSize = true;
            this.removeAccentsCB.Location = new System.Drawing.Point(15, 234);
            this.removeAccentsCB.Name = "removeAccentsCB";
            this.removeAccentsCB.Size = new System.Drawing.Size(108, 17);
            this.removeAccentsCB.TabIndex = 17;
            this.removeAccentsCB.Text = "Remove Accents";
            this.removeAccentsCB.UseVisualStyleBackColor = true;
            this.removeAccentsCB.CheckedChanged += new System.EventHandler(this.removeAccentsCB_CheckedChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 296);
            this.Controls.Add(this.removeAccentsCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encodingList);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.pathDir);
            this.Controls.Add(this.pathFile);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.openDirButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form";
            this.Text = "Encode Changer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog openDirDialog;
        private System.Windows.Forms.Button openDirButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.RichTextBox pathFile;
        private System.Windows.Forms.RichTextBox pathDir;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox encodingList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox removeAccentsCB;
    }
}

