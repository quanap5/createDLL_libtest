using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculateLib;
namespace ClienCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculate cal = new Calculate();


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //int temp = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                var temp = cal.Add(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = temp.ToString();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var temp = cal.Sub(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
                textBox3.Text = temp.ToString();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
