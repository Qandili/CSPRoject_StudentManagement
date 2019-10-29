using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP_Project_StudentManagement
{
    public partial class updateFiliere : Form
    {
        public string text;
        public updateFiliere(String value)
        {
            text = value;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
        }

        private void updateFiliere_Load(object sender, EventArgs e)
        {
            textBox1.Text = text;
        }
    }
}
