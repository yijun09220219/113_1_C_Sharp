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
                // ���Ҩè��o��l�ӵ߼ƶq
                if (!int.TryParse(txtbacteria.Text, out int initialBacteria) || initialBacteria <= 0)
                {
                    MessageBox.Show("�п�J���ĥ���Ʋӵߪ���l�ƶq");
                    return;
                }

                // ���Ҩè��o�Ѽ�
                if (!int.TryParse(txtdays.Text, out int days) || days < 0)
                {
                    MessageBox.Show("�п�J���ľ�Ƨ@���Ѽ�");
                    return;
                }

                // �ͪ��v�]���]�T�w���C��½���^
                double growthRate = 2;

                // �p��̲ײӵ߼ƶq
                double finalBacteria = initialBacteria * Math.Pow(growthRate, days);

                // ��ܵ��G�� ListBox
                listBox1.Items.Clear(); // �M�ť��e�����G
                listBox1.Items.Add($"�g�L {days} �ѡA�ӵ��`�Ƭ��G{finalBacteria}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�o�Ϳ��~�G{ex.Message}");
            }
        }
    }
}
