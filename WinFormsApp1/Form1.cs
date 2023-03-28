using ClassLibrary1.Kuku;
using PdfSharp;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UtilityStrings utilityStrings = new UtilityStrings();
            textBox1.Text = utilityStrings.CombineString("11111", "2222");
            
        }
    }
}