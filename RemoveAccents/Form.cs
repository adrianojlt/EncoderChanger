using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using RemoveAccents.Utils;

namespace RemoveAccents
{
    public partial class Form : System.Windows.Forms.Form
    {
        Util util;

        public Form()
        {
            InitializeComponent();
            util = new Util();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            encodingList.Items.Add("ISO-8859-1");
            encodingList.Items.Add("ISO-8859-3");
            encodingList.Items.Add("ISO-8859-15");
            encodingList.Items.Add("windows-1252");
            encodingList.Items.Add("utf-8");
            encodingList.Items.Add("utf-8 BOM");
            encodingList.Items.Add("utf-16");
            encodingList.SelectedIndex = 0;
        }

        private void openDirButton_Click(object sender, EventArgs e)
        {
            openDirDialog.SelectedPath = pathDir.Text;
            DialogResult result = openDirDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                String[] allfiles = System.IO.Directory.GetFiles(openDirDialog.SelectedPath, "*.srt", System.IO.SearchOption.AllDirectories);

                foreach (var file in allfiles)
                {
                    listBox.Items.Add(file);
                }

                pathDir.Text = openDirDialog.SelectedPath;
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                String path = openFileDialog.InitialDirectory + openFileDialog.FileName;
                listBox.Items.Add(path);
                pathFile.Text = (String)path;
            }
        }

        private void removeAccentsButton_Click(object sender, EventArgs e)
        {
            int processed = 0;
            foreach ( var file in listBox.Items )
            {
                try
                {
                    if (removeAccentsCB.Checked)
                    {
                        util.RemoveAccents((string)file);
                        infoLabel.Text = "removed accents";
                        return;
                    }
                    else
                    {
                        util.ChangeEncoding((string)file,encodingList.SelectedItem.ToString());
                        processed++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            infoLabel.Text = processed.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pathDir.Clear();
            pathFile.Clear();
            listBox.Items.Clear();
            infoLabel.Text = "";
            System.Console.Write("changed");
        }

        private void listBox_selectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            infoLabel.Text = "";
            //infoLabel.Text = util.GetEncoding(listBox.SelectedItem.ToString());
            infoLabel.Text = util.AnotherGetEncoding(listBox.SelectedItem.ToString()).ToString();

        }

        private void removeAccentsCB_CheckedChanged(object sender, EventArgs e)
        {
            if ( removeAccentsCB.Checked )
            {
                encodingList.Enabled = false;
                return;
            }

            encodingList.Enabled = true;
        }
    }
}
