using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace serie.de.fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int num1 = 0, num2 = 1, nextnum;
            for (int i = 0; i < 30; i++)
            {
                nextnum = num1 + num2;
                num1 = num2;
                num2 = nextnum;
                listBox1.Items.Add(num1);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
