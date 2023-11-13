using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void form3_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("sample.csv");

            for (int i = 0 ; i < lines.Length ; i++)
            {
               listBox1.Items.Add(lines[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox12215(object sender, EventArgs e)
        {

        }
    }
}
