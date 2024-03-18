namespace Parking_Monitoring_System
{
    public partial class MainMenuForm : Form
    {
        private System.Windows.Forms.Timer tmrTIMER;
        public MainMenuForm()
        {
            InitializeComponent();

            tmrTIMER = new System.Windows.Forms.Timer();
            tmrTIMER.Interval = 1000; // Set the interval to 1 second
            tmrTIMER.Tick += tmrTimer_Tick; // Attach the event handler

            label1.Select();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            tmrTIMER.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            TimeZoneInfo phTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Manila");
            DateTime phTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, phTimeZone);

            textBox1.Text = phTime.ToString("MMMM dd, yyyy");
            textBox2.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
