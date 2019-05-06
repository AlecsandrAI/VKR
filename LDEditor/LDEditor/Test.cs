using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFControlLibrary;

namespace LDEditor
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewNetwork newNetwork = new NewNetwork();
            int i = panel1.Controls.Count + 1;
            newNetwork.Height = 50;
            newNetwork.AutoSize = false;
            newNetwork.labelNumNetwork.Text = i.ToString();
            panel1.Controls.Add(newNetwork);


           

            this.Refresh();
        }
    }
}
