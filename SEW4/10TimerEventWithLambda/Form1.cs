namespace _10TimerEventWithLambda
{
    public partial class Form1 : Form
    {
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            this.timer1.Tick += (sender, e) => this.txtCounter.Text = this.counter++.ToString();
            this.timer1.Interval = 100;
            this.btnStart.Click += (sender, e) => this.timer1.Start();
            this.btnStop.Click += (sender, e) => this.timer1.Stop();
            this.btnClear.Click += (sender, e) =>
            {
                this.txtCounter.Clear();
                this.counter = 0;
            };
                
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }
    }
}