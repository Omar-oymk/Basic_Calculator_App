using System;
using System.Windows.Forms;
using System.Data; // For DataTable.Compute
using System.Drawing;
using System.Runtime.InteropServices;

namespace Calculator_App
{
    public partial class SimpleCalculator : Form
    {
        // Fields
        private string x = ""; // Non-static instance field

        // Draggable window setup
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr window, int message, int parameter1, int parameter2);

        public SimpleCalculator()
        {
            InitializeComponent();
            InitializeCustomTitleBar();
        }

        private void InitializeCustomTitleBar()
        {
            panel1.MouseDown += titleBar_MouseDown;
            label1.MouseDown += titleBar_MouseDown; // Allow dragging via label too
        }

        private void titleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        #region Number Buttons
        private void button5_Click(object sender, EventArgs e)  // 4
        {
            x += "4";
            textBox1.Text = x;
        }

        private void button6_Click(object sender, EventArgs e)  // 5
        {
            x += "5";
            textBox1.Text = x;
        }

        private void button7_Click(object sender, EventArgs e)  // 7
        {
            x += "7";
            textBox1.Text = x;
        }

        private void button8_Click(object sender, EventArgs e)  // 8
        {
            x += "8";
            textBox1.Text = x;
        }

        private void button9_Click(object sender, EventArgs e)  // 1
        {
            x += "1";
            textBox1.Text = x;
        }

        private void button10_Click(object sender, EventArgs e)  // 2
        {
            x += "2";
            textBox1.Text = x;
        }

        private void button11_Click(object sender, EventArgs e)  // 3
        {
            x += "3";
            textBox1.Text = x;
        }

        private void button12_Click(object sender, EventArgs e)  // 6
        {
            x += "6";  // Fixed from "56"
            textBox1.Text = x;
        }

        private void button13_Click(object sender, EventArgs e)  // 9
        {
            x += "9";
            textBox1.Text = x;
        }

        private void button15_Click(object sender, EventArgs e)  // 0
        {
            x += "0";
            textBox1.Text = x;
        }
        #endregion

        #region Operator Buttons
        private void button1_Click(object sender, EventArgs e)  // +
        {
            x += "+";
            textBox1.Text = x;
        }

        private void button3_Click(object sender, EventArgs e)  // -
        {
            x += "-";
            textBox1.Text = x;
        }

        private void button2_Click(object sender, EventArgs e)  // *
        {
            x += "*";
            textBox1.Text = x;
        }

        private void button4_Click(object sender, EventArgs e)  // /
        {
            x += "/";
            textBox1.Text = x;
        }
        #endregion

        #region Special Functions
        private void button16_Click(object sender, EventArgs e)  // =
        {
            try
            {
                string y = "", z = "";

                for (int i=0; i<x.Length; i++)
                {
                    if (x[i] != '*' && x[i] != '+' && x[i] != '/' && x[i] != '-')
                    {
                        y += x[i];
                    }
                    else
                    {
                        for (int j = i+1; j<x.Length ; j++)
                        {
                            z += x[j];
                        }
                        switch(x[i])
                        {
                            case '*':
                                x = Convert.ToString(Convert.ToInt32(y) * Convert.ToInt32(z));
                                break;
                            case '+':
                                x = Convert.ToString(Convert.ToInt32(y) + Convert.ToInt32(z));
                                break;
                            case '-':
                                x = Convert.ToString(Convert.ToInt32(y) - Convert.ToInt32(z));
                                break;
                            case '/':
                                if (Convert.ToInt32(z) == 0)
                                {
                                    textBox1.Text = "Error: Division by zero";
                                    return;
                                }
                                x = Convert.ToString(Convert.ToDouble(y) / Convert.ToDouble(z));
                                break;
                        }


                        textBox1.Text += " = " + x;
                        break;
                    }
                }
                //var result = new DataTable().Compute(x, null);
                //textBox1.Text = result.ToString();
                //x = result.ToString(); // Store result for continued calculations
            }
            catch (Exception)
            {
                textBox1.Text = "Error";
                x = "";
            }
        }

        private void button14_Click(object sender, EventArgs e)  // Close (X)
        {
            this.Close();
        }
        #endregion

        #region Unused Event Handlers (Keep for designer compatibility)
        private void Form1_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        #endregion

        private void button17_Click(object sender, EventArgs e)
        {
            x = "";
            textBox1.Text = x;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            x += "+";
            textBox1.Text = x;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string y = x;
            x = "";
            for (int i=0; i<y.Length - 1; i++)
            {
                x += y[i];
            }
            textBox1.Text = x;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            x+= "-";
            textBox1.Text = x;
        }
    }
}