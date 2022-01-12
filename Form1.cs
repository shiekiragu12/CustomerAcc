using System;
using System.Windows.Forms;


namespace CustomerAcc
{
    public partial class Form1 : Form
    {
        private object TxtPassword;
        private object TxtConfirmPassword;
        private object MessageBoxIcon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("Enter your username", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            if (TxtPassword.text != TxtConfirmPassword.text)
            {
                MessageBox.Show("Passwords don't match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CustomerA repository = new CustomerA1();
            bool result = await repository.Insert(new User() { UserName = txtUserName.Text, Password = TxtPassword });
            if (result)
                MessageBox.Show("Succesfully signed up", "Message", MessageBoxButtons.OK, MessageBoxIcon.ToString);
            else
                MessageBox.Show("Error", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
