/*---------------------------------------------
  �Z��:��ޤ@�A
  �Ǹ�:A113221020
  �m�W:���ɧg
-----------------------------------------------*/
namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //��ܼ��J�P�I��
        private void btnShowback_Click(object sender, EventArgs e)
        {
            ptxback.Visible = true;//�]�wvisible�ݩʬ���
            ptxfront.Visible = false;
        }
        //��ܼ��J�P����
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
