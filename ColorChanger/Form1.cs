using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xaml;
using System.Xml;
using System.Xml.Linq;
using System.IO.Compression;
using System.Reflection;

namespace ColorChanger
{
    public partial class Form1 : Form
    {
       
        Color currentcolor;
        int mapindex = -1;
        string selectedfile = "";
        XmlDocument docc = new XmlDocument();
        XmlDocument cclib = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
            label1.Text = "#000000";
            currentcolor = colorDialog1.Color;
            docc.Load("DefaultTheme.Colours.xaml");
            cclib.Load("CCLib.xaml");
            for (int i = 0; i < docc.ChildNodes[0].ChildNodes.Count; i++)
            {
                listBox1.Items.Add(docc.ChildNodes[0].ChildNodes[i].Attributes[0].InnerText);
            }
            for (int i = 0; i < cclib.ChildNodes[0].ChildNodes.Count; i++)
            {
                if (cclib.ChildNodes[0].ChildNodes[i].Name == "SolidColorBrush")
                {
                    listBox2.Items.Add(cclib.ChildNodes[0].ChildNodes[i].Attributes[0].Value);
                }
                
            }
            System.IO.Directory.CreateDirectory("CustomPresets");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Text = "";
                var r = colorDialog1.Color.R;
                var g = colorDialog1.Color.G;
                var b = colorDialog1.Color.B;
                var hexcolor = string.Format("{0:X2}{1:X2}{2:X2}", r, g, b);
                label1.Text = "#" + hexcolor.ToString();
                label1.ForeColor = colorDialog1.Color;
                currentcolor = colorDialog1.Color;
                panel1.BackColor = currentcolor;

            }
        }

        private void LoadXAML_Click(object sender, EventArgs e)
        {
            
            
            if (mapindex == -1)
            {
                docc.ChildNodes[0].ChildNodes[32].ChildNodes[0].Value = label1.Text;
            }
            else
            {
                if (selectedfile == "DefaultTheme.Colours.xaml")
                {
                    if (docc.ChildNodes[0].ChildNodes[mapindex].Name == "SolidColorBrush")
                    {
                        if (docc.ChildNodes[0].ChildNodes[mapindex].ChildNodes.Count == 0)
                        {
                            if (docc.ChildNodes[0].ChildNodes[mapindex].Attributes.Count == 3)
                            {
                                docc.ChildNodes[0].ChildNodes[mapindex].Attributes[2].Value = label1.Text;
                            }
                            else docc.ChildNodes[0].ChildNodes[mapindex].Attributes[1].Value = label1.Text;
                        }
                        else
                        {
                            docc.ChildNodes[0].ChildNodes[mapindex].ChildNodes[0].Value = label1.Text;
                        }

                    }
                    else docc.ChildNodes[0].ChildNodes[mapindex].ChildNodes[0].Value = label1.Text;
                }
                if (selectedfile == "CCLib.xaml")
                {
                    cclib.ChildNodes[0].ChildNodes[mapindex].Attributes[1].Value = label1.Text;
                }



            }
            if (selectedfile == "DefaultTheme.Colours.xaml")
            {
                docc.Save("DefaultTheme.Colours.xaml");
            }
            if (selectedfile == "CCLib.xaml")
            {
                cclib.Save("CCLib.xaml");
            }

            label2.Text = "Color for " + listBox1.Text + " changed successfully!";
            label2.ForeColor = currentcolor;




        }

        private void ConvertToHex_Click(object sender, EventArgs e)
        {
            try
            {
                Color fromhex = ColorTranslator.FromHtml(textBox1.Text);
                label1.Text = textBox1.Text;
                label1.ForeColor = fromhex;
                panel1.BackColor = fromhex;
            }
            catch
            {
                label4.Text = "Failed to convert. Make sure your hex is accurate!";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                selectedfile = "DefaultTheme.Colors.xaml";
                if (listBox2.SelectedIndex != -1) { listBox2.SelectedIndex = -1; }
            }
            

            if (!checkBox1.Checked)
            {
                LoadXAML.Text = "Set selected color as " + listBox1.Text;
                mapindex = listBox1.SelectedIndex;
            }
            else
            {
                LoadXAML.Text = "Set selected to variable " + listBox1.Text;
                mapindex = listBox1.SelectedIndex;
                label1.Text = "{StaticResource " + listBox1.Text + "}";
                label1.ForeColor = Color.Black;
            }

        }

        private void SavePresetButton_Click(object sender, EventArgs e)
        {
            if (PresetTextBox.Text == "")
            {
                MessageBox.Show("You need a name for your preset!");
            }
            else
            {
                using (ZipArchive zip = ZipFile.Open("CustomPresets\\" + PresetTextBox.Text + ".zip", ZipArchiveMode.Create))
                {
                    zip.CreateEntryFromFile("DefaultTheme.Colours.xaml", "DefaultTheme.Colours.xaml");
                    zip.CreateEntryFromFile("CCLib.xaml", "CCLib.xaml");
                    fuckoff.Text = "Saved preset " + PresetTextBox.Text + " to CustomPresets folder.";
                }
            }
        }

        private void LoadPresetButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory + "CustomPresets";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                using (ZipArchive zip = ZipFile.Open(ofd.FileName, ZipArchiveMode.Read))
                    foreach (ZipArchiveEntry entry in zip.Entries)
                    {
                        if (entry.Name == "DefaultTheme.Colours.xaml")
                        {
                            if (File.Exists("DefaultTheme.Colours.xaml"))
                            {
                                File.Delete("DefaultTheme.Colours.xaml");
                            }
                            entry.ExtractToFile("DefaultTheme.Colours.xaml");

                        }
                        if (entry.Name == "CCLib.xaml")
                        {
                            if (File.Exists("CCLib.xaml"))
                            {
                                File.Delete("CCLib.xaml");
                            }
                            entry.ExtractToFile("CCLib.xaml");

                        }
                    }

                fuckoff.Text = "Loaded preset successfully!";
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                selectedfile = "CCLib.xaml";
                if (listBox1.SelectedIndex != -1) { listBox1.SelectedIndex = -1; }
                mapindex = listBox2.SelectedIndex;
            }

            if (!checkBox1.Checked)
            {
                LoadXAML.Text = "Set selected color as " + listBox2.Text;
                mapindex = listBox2.SelectedIndex;
            }
            else
            {
                LoadXAML.Text = "Set selected to variable " + listBox2.Text;
                mapindex = listBox2.SelectedIndex;
                label1.Text = "{StaticResource " + listBox2.Text + "}";
                label1.ForeColor = Color.Black;
            }
        }

        private void AdvancedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdvancedCheckBox.Checked)
            {
                label6.Visible = true;
                label9.Visible = true;
                listBox1.Visible = true;
                listBox2.Visible = true;
                checkBox1.Visible = true;
            }
            else
            {
                label6.Visible = false;
                label9.Visible = false;
                listBox1.Visible = false;
                listBox2.Visible = false;
                checkBox1.Visible = false;
            }
        }
    }
}
