namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtuser.Text=="admin" && txtpass.Text=="admin" )
            {
                Form2 fb=new Form2();
                this.Hide();
                fb.ShowDialog();
                this.Close();
               
            }
            else
            {
                MessageBox.Show("Invalid Username and Password");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}