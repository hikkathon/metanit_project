using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metanit_async_await
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayMessage(string message)
        {
            textBox2.Text += message + Environment.NewLine;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factorial fact = new Factorial();
            fact.Notify += DisplayMessage;
            int number = Convert.ToInt32(textBox1.Text);
            fact.FactNotAsync(number);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Factorial fact = new Factorial();
            fact.Notify += DisplayMessage;
            int number = Convert.ToInt32(textBox1.Text);
            fact.FactAsync(number);
        }
    }
}
