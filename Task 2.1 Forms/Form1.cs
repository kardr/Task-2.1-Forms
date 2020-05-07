using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2._1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            if (y <= x && y >= 0 && x <= 23)
            {
                if (y == x || y == 0 || x == 23)
                {
                    textBox3.Text += "На границе";
                }
                else textBox3.Text += "Да";
            }
            else  textBox3.Text += "Нет";
        }
    }
}
