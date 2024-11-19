using System.Windows.Forms;
using System;

namespace chp4_prob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal income;    // 收入
            decimal taxrate;   // 稅率
            decimal payable;   // 應繳稅額
            decimal netIncome; // 淨收入

            // 確保輸入值有效
            if (decimal.TryParse(incomeTextBox.Text, out income))
            {
                // 確定稅率
                taxrate = GetTaxRate(income);

                // 計算稅額與淨收入
                payable = income * taxrate;
                netIncome = income - payable;

                // 顯示結果
                taxlabel.Text = $"Payable Tax: {payable:C2}";
                label2.Text = $"Net Income: {netIncome:C2}";
            }
            else
            {
                MessageBox.Show("請輸入有效的收入數值！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 根據收入返回稅率
        private decimal GetTaxRate(decimal income)
        {
            if (income <= 590000)
                return 0.05m;
            else if (income <= 1330000)
                return 0.12m;
            else if (income <= 2660000)
                return 0.20m;
            else if (income <= 4980000)
                return 0.30m;
            else
                return 0.40m;
        }
    }
}