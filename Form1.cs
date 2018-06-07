using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace num4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Amy");
            listBox1.Items.Add("Allen");
            listBox1.Items.Add("Barry");
            listBox1.Items.Add("Bill");
            listBox1.Items.Add("Clark");
            listBox1.Items.Add("Cash");
            listBox1.SelectionMode = SelectionMode.MultiSimple;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Object obj in listBox1.SelectedItems)
            {
                MessageBox.Show(obj.ToString());
            }
        }
    }
}

