using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LDEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LDlabel1.Text = "Графический редактор";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открыт файл");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LDlabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
