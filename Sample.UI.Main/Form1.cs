using Sample.ClassLibrary;

namespace Sample.UI.Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sample.ClassLibrary.Class1 class1 = new Class1();
            label1.Text = "OK" + class1.Calc(23).ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
                Class1 class1 = new Class1();
                label1.Text = "Error" + class1.Calc(23).ToString();
            }
    }
}