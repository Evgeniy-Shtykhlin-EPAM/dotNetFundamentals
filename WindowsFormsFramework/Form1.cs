using System;
using System.Windows.Forms;
using Library;
namespace WindowsFormsFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello, {textBox1.Text}");

            var message = LibraryClass.Foo(textBox1.Text);
            MessageBox.Show(message);
        }
    }
}
