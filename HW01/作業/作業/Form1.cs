namespace 作業
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "愛心二";
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "愛心三";
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "愛心四";
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "愛心五";
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            lblTranslation.Text = "愛心六";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
