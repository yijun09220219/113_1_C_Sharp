namespace Tutorail3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowDate_Click(object sender, EventArgs e)
        {
            string output;

            output = "民國" + txtYear.Text + "年" + txtMonth.Text + "月" + txtDay.Text + "日" + "星期" + txtDayOfWeek.Text;

            lblShow.Text = output;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDayOfWeek.Text = "";
            txtDay.Text = "";
            txtMonth.Text = "";
            txtYear.Text = "";
            lblShow.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
