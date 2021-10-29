using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieProjectFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Please enter password");
            }
            else if(textBox1.Text == "pass")
            {
                Form3 x = new Form3();
                x.Show();
            }
            else
            {
                MessageBox.Show("Wrong Password", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
