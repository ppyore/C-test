using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test4
{
    public partial class Form1 : Form
    {
        public class myGeneric<T>
        {
            public void myTest(T myValue)
            {
                System.Type myType = myValue.GetType();
                Console.WriteLine(myType);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Add item
            ComboBox combobox1 = new ComboBox();
            comboBox1.Items.Add("Amy");
            comboBox1.Items.Add("Bill");
            comboBox1.Items.Add("Clark");
            comboBox1.Items.Add("Barry");
            comboBox1.Items.Add("Allen");
        } 
     }
}

