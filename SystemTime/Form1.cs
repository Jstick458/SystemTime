namespace SystemTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtInterval.Text = "0";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hsbInterval_Scroll(object sender, ScrollEventArgs e)
        {
            txtInterval.Text = (hsbInterval.Value/10).ToString();
        }
    }
}