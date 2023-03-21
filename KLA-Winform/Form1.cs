namespace KLA_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KLA2.Editor editor = new KLA2.Editor();

            //textBox1.Text = editor.Print("from win");
        }
    }
}