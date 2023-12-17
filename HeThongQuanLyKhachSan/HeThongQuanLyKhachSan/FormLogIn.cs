namespace HeThongQuanLyKhachSan
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "anh.nb203309" && txtPassword.Text == "187801612")
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
            else
            {
                lableWrongUserNameOrPassword.Visible = true;
                txtPassword.Clear();
            }
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}