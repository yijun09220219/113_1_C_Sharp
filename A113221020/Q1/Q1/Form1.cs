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
                lblShow.Text = $"田地面積: {(length * width):n3}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double length, out double width, out _))
            {
                lblShow.Text = $"田地周長: {((length + width) * 2):n3}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (TryGetInputs(out double length, out double width, out double unit))
            {
                lblShow.Text = $"圍欄成本: {(unit * 2 * (length + width)):n3}";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 嘗試解析輸入
        private bool TryGetInputs(out double length, out double width, out double unit)
        {
            length = 0;
            width = 0;
            unit = 0;

            if (!double.TryParse(LEtxtBox.Text, out length))
            {
                MessageBox.Show("請輸入正確的長度數值！");
                return false;
            }

            if (!double.TryParse(WItxtBox.Text, out width))
            {
                MessageBox.Show("請輸入正確的寬度數值！");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(UNITtxtBox.Text) && !double.TryParse(UNITtxtBox.Text, out unit))
            {
                MessageBox.Show("請輸入正確的單位成本數值！");
                return false;
            }

            return true;
        }
    }
}