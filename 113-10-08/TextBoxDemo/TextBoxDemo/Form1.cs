namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fullName;
            string firstName;
            string lastName;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            fullName = lastName + "" + firstName;

            lblShow.Text = fullName;

        }
    }
}
