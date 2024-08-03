namespace DynamicCalc
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
            btnClear = new Button();
            button16 = new Button();
            button15 = new Button();
            TxtScreen = new TextBox();
            btnEqual = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button14 = new Button();
            button17 = new Button();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(322, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(133, 29);
            btnClear.TabIndex = 35;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // button16
            // 
            button16.Location = new Point(249, 150);
            button16.Name = "button16";
            button16.Size = new Size(55, 29);
            button16.TabIndex = 34;
            button16.Text = ")";
            button16.UseVisualStyleBackColor = true;
            button16.Click += AllButtons;
            // 
            // button15
            // 
            button15.Location = new Point(179, 150);
            button15.Name = "button15";
            button15.Size = new Size(55, 29);
            button15.TabIndex = 33;
            button15.Text = "(";
            button15.UseVisualStyleBackColor = true;
            button15.Click += AllButtons;
            // 
            // TxtScreen
            // 
            TxtScreen.Dock = DockStyle.Top;
            TxtScreen.Location = new Point(0, 0);
            TxtScreen.Name = "TxtScreen";
            TxtScreen.Size = new Size(480, 27);
            TxtScreen.TabIndex = 32;
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(322, 342);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(134, 29);
            btnEqual.TabIndex = 31;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += EquiButton;
            // 
            // button13
            // 
            button13.Location = new Point(401, 275);
            button13.Name = "button13";
            button13.Size = new Size(55, 29);
            button13.TabIndex = 30;
            button13.Text = "/";
            button13.UseVisualStyleBackColor = true;
            button13.Click += AllButtons;
            // 
            // button12
            // 
            button12.Location = new Point(322, 275);
            button12.Name = "button12";
            button12.Size = new Size(55, 29);
            button12.TabIndex = 29;
            button12.Text = "*";
            button12.UseVisualStyleBackColor = true;
            button12.Click += AllButtons;
            // 
            // button11
            // 
            button11.Location = new Point(401, 216);
            button11.Name = "button11";
            button11.Size = new Size(55, 29);
            button11.TabIndex = 28;
            button11.Text = "-";
            button11.UseVisualStyleBackColor = true;
            button11.Click += AllButtons;
            // 
            // button10
            // 
            button10.Location = new Point(322, 216);
            button10.Name = "button10";
            button10.Size = new Size(55, 29);
            button10.TabIndex = 27;
            button10.Text = "+";
            button10.UseVisualStyleBackColor = true;
            button10.Click += AllButtons;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(115, 342);
            button9.Name = "button9";
            button9.Size = new Size(55, 29);
            button9.TabIndex = 26;
            button9.Text = "8";
            button9.UseVisualStyleBackColor = false;
            button9.Click += AllButtons;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ButtonHighlight;
            button8.Location = new Point(209, 342);
            button8.Name = "button8";
            button8.Size = new Size(55, 29);
            button8.TabIndex = 25;
            button8.Text = "9";
            button8.UseVisualStyleBackColor = false;
            button8.Click += AllButtons;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(209, 275);
            button7.Name = "button7";
            button7.Size = new Size(55, 29);
            button7.TabIndex = 24;
            button7.Text = "6";
            button7.UseVisualStyleBackColor = false;
            button7.Click += AllButtons;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(25, 342);
            button6.Name = "button6";
            button6.Size = new Size(55, 29);
            button6.TabIndex = 23;
            button6.Text = "7";
            button6.UseVisualStyleBackColor = false;
            button6.Click += AllButtons;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(115, 275);
            button5.Name = "button5";
            button5.Size = new Size(55, 29);
            button5.TabIndex = 22;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += AllButtons;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(209, 216);
            button4.Name = "button4";
            button4.Size = new Size(55, 29);
            button4.TabIndex = 21;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = false;
            button4.Click += AllButtons;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(25, 275);
            button3.Name = "button3";
            button3.Size = new Size(55, 29);
            button3.TabIndex = 20;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AllButtons;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(115, 216);
            button2.Name = "button2";
            button2.Size = new Size(55, 29);
            button2.TabIndex = 19;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AllButtons;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(25, 216);
            button1.Name = "button1";
            button1.Size = new Size(55, 29);
            button1.TabIndex = 18;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AllButtons;
            // 
            // button14
            // 
            button14.BackColor = SystemColors.ButtonHighlight;
            button14.Location = new Point(25, 150);
            button14.Name = "button14";
            button14.Size = new Size(55, 29);
            button14.TabIndex = 36;
            button14.Text = "0";
            button14.UseVisualStyleBackColor = false;
            button14.Click += AllButtons;
            // 
            // button17
            // 
            button17.BackColor = SystemColors.ButtonHighlight;
            button17.Location = new Point(107, 150);
            button17.Name = "button17";
            button17.Size = new Size(55, 29);
            button17.TabIndex = 37;
            button17.Text = ".";
            button17.UseVisualStyleBackColor = false;
            button17.Click += AllButtons;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 436);
            Controls.Add(button17);
            Controls.Add(button14);
            Controls.Add(btnClear);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(TxtScreen);
            Controls.Add(btnEqual);
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
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Button button16;
        private Button button15;
        private TextBox TxtScreen;
        private Button btnEqual;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button14;
        private Button button17;
    }
}
