using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// extra
using System.Runtime.InteropServices;

namespace Calculator_App
{
    public partial class SimpleCalculator: Form
    {

        // for draggable window using custom title bar
        // stop dragging mouse for whatever control is currently using it
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr window, int message, int parameter1, int parameter2);

        private void titleBar_MouseDown(object sender, MouseEventArgs e)    // add the releasecapture fn and send msg to a fn to send later
        {   // handler (the window itself)
            ReleaseCapture();
            SendMessage(this.Handle, 0xA1, 0x2, 0);
        }

        private void InitializeCustomTitleBar()     // make the function that takes the panel then adds the mouse down function
        {
            Panel titleBar = panel1;
            titleBar.MouseDown += new MouseEventHandler(titleBar_MouseDown);
        }


        public SimpleCalculator()
        {
            InitializeComponent();
            InitializeCustomTitleBar();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
