namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbacteria_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdays_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // 驗證並取得初始細菌數量
                if (!int.TryParse(txtbacteria.Text, out int initialBacteria) || initialBacteria <= 0)
                {
                    MessageBox.Show("請輸入有效正整數細菌的初始數量");
                    return;
                }

                // 驗證並取得天數
                if (!int.TryParse(txtdays.Text, out int days) || days < 0)
                {
                    MessageBox.Show("請輸入有效整數作為天數");
                    return;
                }

                // 生長率（假設固定為每天翻倍）
                double growthRate = 2;

                // 計算最終細菌數量
                double finalBacteria = initialBacteria * Math.Pow(growthRate, days);

                // 顯示結果到 ListBox
                listBox1.Items.Clear(); // 清空先前的結果
                listBox1.Items.Add($"經過 {days} 天，細菌總數為：{finalBacteria}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}");
            }
        }
    }
}
