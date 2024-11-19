using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calory; // 總熱量
            double gram;   // 脂肪克數
            double fatCalories; // 來自脂肪的卡路里
            double fatPercentage; // 卡路里百分比

            // 驗證輸入是否為有效數字，且數值大於等於0
            if (double.TryParse(textBox1.Text, out calory) && calory > 0 &&
                double.TryParse(textBox2.Text, out gram) && gram >= 0)
            {
                // 計算來自脂肪的卡路里
                fatCalories = gram * 9;

                // 確保脂肪卡路里不超過總熱量
                if (fatCalories <= calory)
                {
                    // 計算脂肪卡路里百分比
                    fatPercentage = (fatCalories / calory) * 100;

                    // 顯示結果
                    label3.Text = $"The number of calories from fat: {fatCalories:F2}\n" +
                                  $"Percentage of calories from fat: {fatPercentage:F2}%";

                    // 判斷是否為低脂食品（選中 RadioButton 時才檢查）
                    if (radioButton1.Checked)
                    {
                        if (fatPercentage < 30)
                            label3.Text += "\nThe food is considered low fat.";
                        else
                            label3.Text += "\nThe food is not a considered low fat.";
                    }
                }
                else
                {
                    // 錯誤訊息：脂肪卡路里超過總熱量
                    MessageBox.Show("脂肪卡路里不能超過總熱量！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // 錯誤訊息：輸入的值無效或不符合規範
                MessageBox.Show("請輸入有效的數字，並確保總熱量大於 0，脂肪重量大於等於 0！", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
