namespace Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double length, out double width, out _))
            {
                lblShow.Text = $"�Цa���n: {(length * width):n3}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double length, out double width, out _))
            {
                lblShow.Text = $"�Цa�P��: {((length + width) * 2):n3}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double length, out double width, out double unit))
            {
                lblShow.Text = $"���榨��: {(unit * 2 * (length + width)):n3}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ���ոѪR��J
        private bool TryGetInputs(out double length, out double width, out double unit)
        {
            length = 0;
            width = 0;
            unit = 0;

            if (!double.TryParse(LEtxtBox.Text, out length))
            {
                MessageBox.Show("�п�J���T�����׼ƭȡI");
                return false;
            }

            if (!double.TryParse(WItxtBox.Text, out width))
            {
                MessageBox.Show("�п�J���T���e�׼ƭȡI");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(UNITtxtBox.Text) && !double.TryParse(UNITtxtBox.Text, out unit))
            {
                MessageBox.Show("�п�J���T����즨���ƭȡI");
                return false;
            }

            return true;
        }
    }
}