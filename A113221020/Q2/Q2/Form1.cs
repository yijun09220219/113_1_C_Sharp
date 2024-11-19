namespace Q2
{
    public partial class Form1 : Form
    {
        // 定義水果卡路里
        const double BANANA = 115;
        const double APPLE = 80;
        const double ORANGE = 90;
        const double PEAR = 120;

        private double total = 0;

        // 使用布林值追蹤點擊狀態
        private bool isBananaAdded = false;
        private bool isAppleAdded = false;
        private bool isOrangeAdded = false;
        private bool isPearAdded = false;

        public Form1()
        {
            InitializeComponent();
        }

        // 點擊香蕉
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateCalories(ref isBananaAdded, BANANA);
        }

        // 點擊蘋果
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UpdateCalories(ref isAppleAdded, APPLE);
        }

        // 點擊橙子
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UpdateCalories(ref isOrangeAdded, ORANGE);
        }

        // 點擊梨子
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UpdateCalories(ref isPearAdded, PEAR);
        }

        // 更新總卡路里的方法
        private void UpdateCalories(ref bool isAdded, double calories)
        {
            if (isAdded)
            {
                total -= calories;
                isAdded = false;
            }
            else
            {
                total += calories;
                isAdded = true;
            }

            // 更新顯示的總卡路里
            totalLabel.Text = $"總卡路里: {total}";
        }

        // 重設按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;
            isBananaAdded = false;
            isAppleAdded = false;
            isOrangeAdded = false;
            isPearAdded = false;
            totalLabel.Text = "總卡路里: 0";
        }

        // 關閉按鈕
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}