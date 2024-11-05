namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassAtextBox.Text = "";
            ClassBtextBox.Text = "";
            ClassCtextBox.Text = "";
            ClassAlbl.Text = "";
            ClassBlbl.Text = "";
            ClassClbl.Text = "";
            Totallbl.Text = "";

            ClassAtextBox.Focus();
        }
    }
}
