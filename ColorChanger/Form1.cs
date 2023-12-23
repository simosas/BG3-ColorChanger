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
        void SetupSelections()
        {
            string[] vars = { "PrimaryColor", "SecondaryColor", "TertiaryColor", "SpecialTxt", "DialogueBase", "DialogueHighlight", "DialogueHighlightHistory", "CombatLogEnemy", "CombatLogAlly", "RollSuccess", "RollFailure", "ItemRarityColour.Uncommon", "ItemRarityColour.Rare", "ItemRarityColour.VeryRare", "ItemRarityColour.Legendary", "ApprovalNegative", "ApprovalNeutral", "ApprovalPositive", "ProficiencyAbility" };
            for (int i = 0; i < vars.Length; i++)
            {
                ValuesListBox.Items.Add(vars[i]);
            }
        }
        public static string Base64Encode(string plainText)
        {
            if (plainText != null)
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            else return "";

        }
        void MakePreset(string filename)
        {
            string thingtoencode = "";
            for (int i = 0; i < 19; i++)
            {
                thingtoencode = thingtoencode + docc.ChildNodes[0].ChildNodes[i].ChildNodes[0].Value;
            }
            thingtoencode = Base64Encode(thingtoencode);
            File.WriteAllText("CustomPresets\\" + filename, thingtoencode);
        }
        public static string Base64Decode(string base64EncodedData)
        {
            if (base64EncodedData != null)
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            else return "";
        }

        Color currentcolor;
        XmlDocument docc = new XmlDocument();
        public Form1()
        {
            InitializeComponent();
            System.IO.Directory.CreateDirectory("CustomPresets");
            label1.Text = "#000000";
            currentcolor = colorDialog1.Color;
            docc.Load("Colorful Words Master.xaml");
            SetupSelections();

            
            

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
            
            if (ValuesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a value to change first >:(");
            }
            else
            {
                docc.ChildNodes[0].ChildNodes[ValuesListBox.SelectedIndex].ChildNodes[0].Value = label1.Text;
                docc.Save("Colorful Words Master.xaml");
                panel2.BackColor = ColorTranslator.FromHtml(label1.Text);
            }








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



        private void SavePresetButton_Click(object sender, EventArgs e)
        {
            if (PresetTextBox.Text == "")
            {
                MessageBox.Show("You need a name for your preset!");
            }
            else
            {
                MakePreset(PresetTextBox.Text);
            }
        }

        private void LoadPresetButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            string fileContent = String.Empty;
            string decoded;
            string[] values = new string[20];
            ofd.InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var fileStream = ofd.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                decoded = Base64Decode(fileContent);
                values = decoded.Split('#');
            }
            var list = values.ToList();
            list.RemoveAt(0);

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = "#" + list[i].ToString();
                docc.ChildNodes[0].ChildNodes[i].ChildNodes[0].Value = list[i];
            }
            docc.Save("Colorful Words Master.xaml");

        }


        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadXAML.Text = "Set selected color as " + ValuesListBox.Text;
            try
            {
                Color fromhex = ColorTranslator.FromHtml(docc.ChildNodes[0].ChildNodes[ValuesListBox.SelectedIndex].ChildNodes[0].Value);
                panel2.BackColor = fromhex;
            }
            catch { }   


        }
    }
}
