﻿namespace DynamicCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtScreen = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // TxtScreen
            // 
            TxtScreen.Dock = DockStyle.Top;
            TxtScreen.Location = new Point(0, 0);
            TxtScreen.Name = "TxtScreen";
            TxtScreen.Size = new Size(467, 27);
            TxtScreen.TabIndex = 14;
            TxtScreen.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(25, 131);
            button1.Name = "button1";
            button1.Size = new Size(55, 29);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AllBtns_Clicked;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(115, 131);
            button2.Name = "button2";
            button2.Size = new Size(55, 29);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AllBtns_Clicked;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(25, 190);
            button3.Name = "button3";
            button3.Size = new Size(55, 29);
            button3.TabIndex = 2;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AllBtns_Clicked;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(209, 131);
            button4.Name = "button4";
            button4.Size = new Size(55, 29);
            button4.TabIndex = 3;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += AllBtns_Clicked;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(115, 190);
            button5.Name = "button5";
            button5.Size = new Size(55, 29);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += AllBtns_Clicked;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(25, 257);
            button6.Name = "button6";
            button6.Size = new Size(55, 29);
            button6.TabIndex = 5;
            button6.Text = "7";
            button6.UseVisualStyleBackColor = false;
            button6.Click += AllBtns_Clicked;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(209, 190);
            button7.Name = "button7";
            button7.Size = new Size(55, 29);
            button7.TabIndex = 6;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += AllBtns_Clicked;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(209, 257);
            button8.Name = "button8";
            button8.Size = new Size(55, 29);
            button8.TabIndex = 7;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = false;
            button8.Click += AllBtns_Clicked;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(115, 257);
            button9.Name = "button9";
            button9.Size = new Size(55, 29);
            button9.TabIndex = 8;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += AllBtns_Clicked;
            // 
            // button10
            // 
            button10.Location = new Point(322, 131);
            button10.Name = "button10";
            button10.Size = new Size(55, 29);
            button10.TabIndex = 9;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += AllBtns_Clicked;
            // 
            // button11
            // 
            button11.Location = new Point(401, 131);
            button11.Name = "button11";
            button11.Size = new Size(55, 29);
            button11.TabIndex = 10;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += AllBtns_Clicked;
            // 
            // button12
            // 
            button12.Location = new Point(322, 190);
            button12.Name = "button12";
            button12.Size = new Size(55, 29);
            button12.TabIndex = 11;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += AllBtns_Clicked;
            // 
            // button13
            // 
            button13.Location = new Point(401, 190);
            button13.Name = "button13";
            button13.Size = new Size(55, 29);
            button13.TabIndex = 12;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            button13.Click += AllBtns_Clicked;
            // 
            // button14
            // 
            button14.Location = new Point(322, 257);
            button14.Name = "button14";
            button14.Size = new Size(134, 29);
            button14.TabIndex = 13;
            button14.Text = "=";
            button14.UseVisualStyleBackColor = true;
            button14.Click += AllBtns_Clicked;
            // 
            // button15
            // 
            button15.Location = new Point(25, 65);
            button15.Name = "button15";
            button15.Size = new Size(55, 29);
            button15.TabIndex = 15;
            button15.Text = "(";
            button15.UseVisualStyleBackColor = true;
            button15.Click += AllBtns_Clicked;
            // 
            // button16
            // 
            button16.Location = new Point(115, 65);
            button16.Name = "button16";
            button16.Size = new Size(55, 29);
            button16.TabIndex = 16;
            button16.Text = ")";
            button16.UseVisualStyleBackColor = true;
            button16.Click += AllBtns_Clicked;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(322, 65);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 29);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += AllBtns_Clicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 327);
            Controls.Add(btnClear);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(TxtScreen);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Calculator";
            Load += Form1_Load;
            Click += button9_Click_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TxtScreen;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button btnClear;
    }
}
