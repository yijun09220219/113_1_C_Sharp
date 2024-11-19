namespace Q2
{
    public partial class Form1 : Form
    {
        // �w�q���G�d����
        const double BANANA = 115;
        const double APPLE = 80;
        const double ORANGE = 90;
        const double PEAR = 120;

        private double total = 0;

        // �ϥΥ��L�Ȱl���I�����A
        private bool isBananaAdded = false;
        private bool isAppleAdded = false;
        private bool isOrangeAdded = false;
        private bool isPearAdded = false;

        public Form1()
        {
            InitializeComponent();
        }

        // �I������
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UpdateCalories(ref isBananaAdded, BANANA);
        }

        // �I��ī�G
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UpdateCalories(ref isAppleAdded, APPLE);
        }

        // �I����l
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UpdateCalories(ref isOrangeAdded, ORANGE);
        }

        // �I�����l
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UpdateCalories(ref isPearAdded, PEAR);
        }

        // ��s�`�d��������k
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

            // ��s��ܪ��`�d����
            totalLabel.Text = $"�`�d����: {total}";
        }

        // ���]���s
        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;
            isBananaAdded = false;
            isAppleAdded = false;
            isOrangeAdded = false;
            isPearAdded = false;
            totalLabel.Text = "�`�d����: 0";
        }

        // �������s
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}