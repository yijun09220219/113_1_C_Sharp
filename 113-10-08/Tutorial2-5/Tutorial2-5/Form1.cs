/*---------------------------------------------
  班級:資管一乙
  學號:A113221020
  姓名:陳怡君
-----------------------------------------------*/
namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //顯示撲克牌背面
        private void btnShowback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true;//設定visible屬性為假
            ptxfront.Visible = false;
        }
        //顯示撲克牌正面
        private void btnShowfront_Click(object sender, EventArgs e)
        {
            ptxback.Visible = false;
            ptxfront.Visible = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
