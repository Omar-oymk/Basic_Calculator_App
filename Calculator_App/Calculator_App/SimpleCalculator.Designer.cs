using System.Drawing;
using System.Windows.Forms;
namespace Calculator_App
{
    partial class SimpleCalculator
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.button1.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(321, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.button2.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(321, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 75);
            this.button2.TabIndex = 1;
            this.button2.Text = "X";
            this.button2.UseCompatibleTextRendering = true;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.button3.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(240, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 75);
            this.button3.TabIndex = 4;
            this.button3.Text = "-";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button3.UseCompatibleTextRendering = true;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(4)))), ((int)(((byte)(6)))));
            this.button4.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(240, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 75);
            this.button4.TabIndex = 2;
            this.button4.Text = "/";
            this.button4.UseCompatibleTextRendering = true;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(12, 436);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 70);
            this.button5.TabIndex = 3;
            this.button5.Text = "4";
            this.button5.UseCompatibleTextRendering = true;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button6.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button6.Location = new System.Drawing.Point(88, 436);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 70);
            this.button6.TabIndex = 4;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button7.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button7.Location = new System.Drawing.Point(12, 512);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 70);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseCompatibleTextRendering = true;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button8.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button8.Location = new System.Drawing.Point(88, 512);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 70);
            this.button8.TabIndex = 6;
            this.button8.Text = "8";
            this.button8.UseCompatibleTextRendering = true;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button9.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button9.Location = new System.Drawing.Point(12, 360);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 70);
            this.button9.TabIndex = 7;
            this.button9.Text = "1";
            this.button9.UseCompatibleTextRendering = true;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button10.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button10.Location = new System.Drawing.Point(88, 360);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 70);
            this.button10.TabIndex = 8;
            this.button10.Text = "2";
            this.button10.UseCompatibleTextRendering = true;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button11.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button11.Location = new System.Drawing.Point(164, 360);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(70, 70);
            this.button11.TabIndex = 9;
            this.button11.Text = "3";
            this.button11.UseCompatibleTextRendering = true;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button12.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button12.Location = new System.Drawing.Point(164, 436);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(70, 70);
            this.button12.TabIndex = 10;
            this.button12.Text = "6";
            this.button12.UseCompatibleTextRendering = true;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button13.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold);
            this.button13.Location = new System.Drawing.Point(164, 512);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(70, 70);
            this.button13.TabIndex = 5;
            this.button13.Text = "9";
            this.button13.UseCompatibleTextRendering = true;
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(190)))), ((int)(((byte)(130)))));
            this.textBox1.Location = new System.Drawing.Point(12, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(382, 284);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(92)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 39);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Calibri", 10F);
            this.button14.ForeColor = System.Drawing.Color.Red;
            this.button14.Location = new System.Drawing.Point(361, 3);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(42, 33);
            this.button14.TabIndex = 0;
            this.button14.Text = "X";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button15.Location = new System.Drawing.Point(243, 512);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(70, 70);
            this.button15.TabIndex = 13;
            this.button15.Text = "0";
            this.button15.UseCompatibleTextRendering = true;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button16.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold);
            this.button16.Location = new System.Drawing.Point(324, 512);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(70, 70);
            this.button16.TabIndex = 14;
            this.button16.Text = "=";
            this.button16.UseCompatibleTextRendering = true;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button17.Location = new System.Drawing.Point(329, 323);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(60, 26);
            this.button17.TabIndex = 15;
            this.button17.Text = "Clear";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button18.Location = new System.Drawing.Point(249, 323);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(60, 26);
            this.button18.TabIndex = 16;
            this.button18.Text = "Back";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(90)))), ((int)(((byte)(71)))));
            this.button19.Location = new System.Drawing.Point(174, 323);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 26);
            this.button19.TabIndex = 17;
            this.button19.Text = "Ans";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.BackColor = System.Drawing.Color.Green;
            this.button20.Location = new System.Drawing.Point(12, 323);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(40, 31);
            this.button20.TabIndex = 18;
            this.button20.Text = "On";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // SimpleCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(68)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(406, 601);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimpleCalculator";
            this.Text = "Simple Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button14;
        private Label label1;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
    }
}

