using System.Diagnostics;

namespace August_Shutdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s");
        }
    }
}

// Just a little joke app, similar to the Peter Alert joke

// Made with <3 - August, 2023