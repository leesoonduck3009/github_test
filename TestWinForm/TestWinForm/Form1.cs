namespace TestWinForm
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
        int i = 0;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            i++;
            MessageBox.Show("Ban da click vao box " + i);
        }
    }
}