namespace HelloWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }
    }
}
