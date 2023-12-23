namespace ColorChanger
{
    partial class Form1
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadXAML = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ConvertToHex = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.SavePresetButton = new System.Windows.Forms.Button();
            this.LoadPresetButton = new System.Windows.Forms.Button();
            this.PresetTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fuckoff = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(839, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Color Selector";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(964, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // LoadXAML
            // 
            this.LoadXAML.BackColor = System.Drawing.Color.Lavender;
            this.LoadXAML.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadXAML.ForeColor = System.Drawing.Color.Black;
            this.LoadXAML.Location = new System.Drawing.Point(12, 46);
            this.LoadXAML.Name = "LoadXAML";
            this.LoadXAML.Size = new System.Drawing.Size(441, 52);
            this.LoadXAML.TabIndex = 2;
            this.LoadXAML.Text = "Set selected color as ...";
            this.LoadXAML.UseVisualStyleBackColor = false;
            this.LoadXAML.Click += new System.EventHandler(this.LoadXAML_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(882, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Selected:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(836, 557);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 6;
            // 
            // ConvertToHex
            // 
            this.ConvertToHex.Location = new System.Drawing.Point(994, 557);
            this.ConvertToHex.Name = "ConvertToHex";
            this.ConvertToHex.Size = new System.Drawing.Size(75, 20);
            this.ConvertToHex.TabIndex = 7;
            this.ConvertToHex.Text = "Convert";
            this.ConvertToHex.UseVisualStyleBackColor = true;
            this.ConvertToHex.Click += new System.EventHandler(this.ConvertToHex_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(832, 525);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Convert hex to colour:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(835, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "(example: #FF80FF)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(839, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 217);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(835, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Color preview:";
            // 
            // SavePresetButton
            // 
            this.SavePresetButton.Location = new System.Drawing.Point(969, 670);
            this.SavePresetButton.Name = "SavePresetButton";
            this.SavePresetButton.Size = new System.Drawing.Size(100, 23);
            this.SavePresetButton.TabIndex = 15;
            this.SavePresetButton.Text = "Save preset";
            this.SavePresetButton.UseVisualStyleBackColor = true;
            this.SavePresetButton.Click += new System.EventHandler(this.SavePresetButton_Click);
            // 
            // LoadPresetButton
            // 
            this.LoadPresetButton.Location = new System.Drawing.Point(1079, 671);
            this.LoadPresetButton.Name = "LoadPresetButton";
            this.LoadPresetButton.Size = new System.Drawing.Size(123, 23);
            this.LoadPresetButton.TabIndex = 16;
            this.LoadPresetButton.Text = "Load preset from file";
            this.LoadPresetButton.UseVisualStyleBackColor = true;
            this.LoadPresetButton.Click += new System.EventHandler(this.LoadPresetButton_Click);
            // 
            // PresetTextBox
            // 
            this.PresetTextBox.Location = new System.Drawing.Point(836, 672);
            this.PresetTextBox.Name = "PresetTextBox";
            this.PresetTextBox.Size = new System.Drawing.Size(128, 20);
            this.PresetTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(832, 650);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Preset name:";
            // 
            // fuckoff
            // 
            this.fuckoff.AutoSize = true;
            this.fuckoff.Location = new System.Drawing.Point(893, 700);
            this.fuckoff.Name = "fuckoff";
            this.fuckoff.Size = new System.Drawing.Size(0, 13);
            this.fuckoff.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(35, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "Editable values:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(40, 207);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(229, 404);
            this.ValuesListBox.TabIndex = 24;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(40, 636);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 34);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Color preview:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1275, 759);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fuckoff);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PresetTextBox);
            this.Controls.Add(this.LoadPresetButton);
            this.Controls.Add(this.SavePresetButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConvertToHex);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoadXAML);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Color Picker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoadXAML;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ConvertToHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button SavePresetButton;
        private System.Windows.Forms.Button LoadPresetButton;
        private System.Windows.Forms.TextBox PresetTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label fuckoff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
    }
}

