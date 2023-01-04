namespace mytry_WFA
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_username.Text =="admin" && txt_password.Text == "123")
            {
                frm_about myform = new frm_about(txt_username.Text);   /// create a new class from about form
                myform.Show();                     // to show about form
                this.Hide();

            }
            else
            {
                MessageBox.Show("your username or password is invalid" , "warnning" , MessageBoxButtons.YesNo , MessageBoxIcon.Error);
                txt_username.Clear();     // to delete username
                txt_password.Clear();      // to delete password
                txt_username.Focus();
            }
            

                             
            
        }


        /// handle close icon
        private void form_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("are u sure u want close the form", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (d == DialogResult.No)  /// if i press no i will cancle the event
            {
                e.Cancel = true;    

            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_signin mysign = new frm_signin();
            mysign.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_clearfieldes_Click(object sender, EventArgs e)
        {
            txt_username.Clear();     // to delete username
            txt_password.Clear();      // to delete password
            txt_username.Focus();

        }
    }
}