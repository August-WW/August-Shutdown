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
            Process.Start("shutdown", "/s /t 8");
        }

    }
}