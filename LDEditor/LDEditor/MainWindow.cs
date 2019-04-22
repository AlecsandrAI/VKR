using System;
using System.Collections;
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

    public partial class Main : Form
    {
        

        public Main()
        {
            InitializeComponent();
            
        }
       



        public void Form1_Load(object sender, EventArgs e)
        {
            List<NewNetwork> NetworkList = new List<NewNetwork>();
            NetworkList.Add(newNetwork1);
            NetworkList.Add(newNetwork2);
            NetworkList.Add(newNetwork3);
            NetworkList.Add(newNetwork4);
            NetworkList.Add(newNetwork5);
            NetworkList.Add(newNetwork6);
            NetworkList.Add(newNetwork7);
            NetworkList.Add(newNetwork8);
            NetworkList.Add(newNetwork9);
            NetworkList.Add(newNetwork10);
            NetworkList.Add(newNetwork11);
            NetworkList.Add(newNetwork12);
            NetworkList.Add(newNetwork13);
            NetworkList.Add(newNetwork14);
            NetworkList.Add(newNetwork15);
            NetworkList.Add(newNetwork16);
            NetworkList.Add(newNetwork17);
            NetworkList.Add(newNetwork18);
            NetworkList.Add(newNetwork19);
            NetworkList.Add(newNetwork20);

            



            newNetwork1.labelNumNetwork.Text = "1";
            newNetwork2.labelNumNetwork.Text = "2";
            newNetwork3.labelNumNetwork.Text = "3";
            newNetwork4.labelNumNetwork.Text = "4";
            newNetwork5.labelNumNetwork.Text = "5";
            newNetwork6.labelNumNetwork.Text = "6";
            newNetwork7.labelNumNetwork.Text = "7";
            newNetwork8.labelNumNetwork.Text = "8";
            newNetwork9.labelNumNetwork.Text = "9";
            newNetwork10.labelNumNetwork.Text = "10";
            newNetwork11.labelNumNetwork.Text = "11";
            newNetwork12.labelNumNetwork.Text = "12";
            newNetwork13.labelNumNetwork.Text = "13";
            newNetwork14.labelNumNetwork.Text = "14";
            newNetwork15.labelNumNetwork.Text = "15";
            newNetwork16.labelNumNetwork.Text = "16";
            newNetwork17.labelNumNetwork.Text = "17";
            newNetwork18.labelNumNetwork.Text = "18";
            newNetwork19.labelNumNetwork.Text = "19";
            newNetwork20.labelNumNetwork.Text = "20";

            foreach (NewNetwork net in NetworkList)
            {
                listBox1.Items.Add(net.Name);
            }



        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip3_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            //this.contact1_MouseClick.Click += new System.EventHandler(ClearLabels);
        }

        private void contact1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }

        private void contact1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scrollableControl1_Click(object sender, EventArgs e)
        {

        }

        private void scrollableControl1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            InvContact invcontact = new InvContact();
            newNetwork1.NetElementPanel.Controls.Add(invcontact, 1, 0);
        }


        private void splitContainer1_Panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }


        private void проектToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            AutoVarible autoVarible = new AutoVarible();
            autoVarible.ShowDialog();
        }
        
        private void tableLayoutPanel1_Layout(object sender, LayoutEventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            newNetwork1.NetElementPanel.Controls.Add(contact, 1, 0);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            
            Coil coil = new Coil();
            newNetwork1.NetElementPanel.Controls.Add(coil, newNetwork1.NetElementPanel.ColumnCount-1, 0);
        }

        private void newNetwork1_Load(object sender, EventArgs e)
        {

        }

        private void newNetwork1_Click(object sender, EventArgs e)
        {
            
          
        }
    }
}



