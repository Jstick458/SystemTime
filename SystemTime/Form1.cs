namespace SystemTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtInterval.Text = "0";
            lblRun.Text = "Stopped";
            lblRun.BackColor = Color.Red;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hsbInterval_Scroll(object sender, ScrollEventArgs e)
        {
            txtInterval.Text = (((float)hsbInterval.Value) / 10).ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DateTime time1;
            DateTime time2;
            int interval = (int)(float.Parse(txtInterval.Text) * 1000);
            TimeSpan diff;
            string diffString;

            
            time1 = DateTime.Now;
            Thread.Sleep(interval);
            time2 = DateTime.Now;
            diff = time2.Subtract(time1);
            diffString = diff.TotalMilliseconds.ToString();
            diffString = diffString.Substring(0, diffString.IndexOf("."));

            if (diffString.Length == 1)
            {
                diffString = diffString.Insert(0, "0.00");
            }
            else if (diffString.Length == 2)
            {
                diffString = diffString.Insert(0, "0.0");
            }
            else if (diffString.Length == 3)
            {
                diffString = diffString.Insert(0, "0.");
            }
            else if (diffString.Length == 4)
            {
                diffString = diffString.Insert(1, ".");
            }
            else if (diffString.Length == 5)
            {
                diffString = diffString.Insert(2, ".");
            }



            MessageBox.Show(diffString + " seconds");
            lblRun.Text = "Stopped";
            lblRun.BackColor = Color.Red;
        }

        private void btnStart_MouseDown(object sender, MouseEventArgs e)
        {
            lblRun.Text = "Running";
            lblRun.BackColor = Color.Green;
        }
    }
}