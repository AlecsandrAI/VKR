﻿using System;
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
        List<NewNetwork> NetList = new List<NewNetwork>();

        public Main()
        {
            InitializeComponent();

        }

        
        public void Form1_Load(object sender, EventArgs e)
        {

            NetList.Add(newNetwork1);

            newNetwork1.labelNumNetwork.Text = tLPEditor.Controls.Count.ToString();


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
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {
                    netw.NetElementPanel.Controls.Add(invcontact, 1, 0);

                    break;
                }
            }
        }


        private void splitContainer1_Panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }


        private void проектToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            NewNetwork newNetwork = new NewNetwork();
            int i = tLPEditor.Controls.Count + 1;
            newNetwork.Height = 50;
            newNetwork.AutoSize = false;
            newNetwork.labelNumNetwork.Text = i.ToString();
            tLPEditor.Controls.Add(newNetwork);


            foreach (NewNetwork net in NetList)
            {
                NetList.Add(net);
                break;
            }

            this.Refresh();
        }

        private void tableLayoutPanel1_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();

            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {
                    netw.NetElementPanel.Controls.Add(contact, 1, 0);

                    break;
                }
            }
            this.Refresh();
            //if (ActiveControl is TableLayoutPanel)
            //{

            //    TableLayoutPanel NetElementPanel = ActiveControl as TableLayoutPanel;
            //    ActiveControl.Controls.Add(contact, 1, 0);
            //}

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            Coil coil = new Coil();
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {
                    netw.NetElementPanel.Controls.Add(coil, netw.NetElementPanel.ColumnCount - 1, 0);
                    pGElem.SelectedObject = netw;
                }
                else
                {
                    foreach (Coil co in netw.NetElementPanel.Controls)
                    {
                        if (co.ContainsFocus)
                        {

                            netw.NetElementPanel.Controls.Add(coil, netw.NetElementPanel.ColumnCount - 1, netw.NetElementPanel.GetRow(co) + 1);
                            netw.NetElementPanel.RowCount++;
                            netw.Height = +50;
                            pGElem.SelectedObject = co;
                            break;
                        }
                    }

                }

                break;
            }

            this.Refresh();

        }

        private void newNetwork1_Load(object sender, EventArgs e)
        {

        }

        private void newNetwork1_Click(object sender, EventArgs e)
        {


        }

        private void Main_Click(object sender, EventArgs e)
        {
            this.Refresh();

        }

        private void propertyGrid1_SelectedObjectsChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            ParalContact paralcontact = new ParalContact();
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {

                    netw.NetElementPanel.RowCount++;
                    netw.Height = netw.Height + 50;
                    netw.NetElementPanel.Controls.Add(paralcontact, 1, 1);
                }
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            foreach (Control netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {

                }
            }
        }
    }
}



