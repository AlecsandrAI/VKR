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
using System.IO;
using System.Xml.Serialization;

namespace LDEditor
{

    public partial class frmMain : Form
    {
        string thisNameVar;
        public class FormSize
        {
            public int height;
            public int width;
        }

        List<NewNetwork> NetList = new List<NewNetwork>();

        public frmMain()
        {
            InitializeComponent();

        }


        public void Form1_Load(object sender, EventArgs e)
        {

            NetList.Add(newNetwork1);
             newNetwork1.labelNumNetwork.Text = tLPEditor.Controls.Count.ToString();

            //Создаем экземпляр frmSizeSetup класса FormSize:
            FormSize frmSizeSetup = new FormSize();

            //Cоздаем экземпляр xmlser класса XmlSerializer
            XmlSerializer xmlser = new XmlSerializer(typeof(FormSize));

            //Создаем переменную filename, которой присваиваем
            //название файла applicationSettings.xml в текущей директории
            string filename = System.Environment.CurrentDirectory + "\\applicationSettings.xml";
            
            //Создаем поток filestream для чтения XML-файла
            FileStream filestream = new FileStream(filename, FileMode.Open);

            //Экземпляру frmSizeSetup передаем данные,
            //полученные в процессе десериализации
            frmSizeSetup = (FormSize)xmlser.Deserialize(filestream);

            //Устанавливаем текущие высоту и ширину формы
            this.Height = frmSizeSetup.height;
            this.Width = frmSizeSetup.width;

            //Закрываем поток
            filestream.Close();
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





        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            NewNetwork newNetwork = new NewNetwork();
            int i = tLPEditor.Controls.Count + 1;
            newNetwork.Height = 50;
            newNetwork.AutoSize = false;
            newNetwork.Anchor = (AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);
            newNetwork.labelNumNetwork.Text = i.ToString();
            tLPEditor.Controls.Add(newNetwork);


            foreach (NewNetwork net in NetList)
            {
                NetList.Add(net);
                break;
            }

            this.Refresh();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
          
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {
                    AutoVarible av = new AutoVarible();
                    
                    if (av.ShowDialog(this) == DialogResult.OK)
                    {
                        dgvVarTable.Rows.Add(av.NameVar, av.TypeVar, av.CommentVar);
                        
                    }
                    netw.NetElementPanel.Controls.Add(contact, 1, 0);

                    contact.tbVar.Text = av.NameVar;
                    

                    break;
                }
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            Coil coil = new Coil();
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {
                    netw.NetElementPanel.Controls.Add(coil, netw.NetElementPanel.ColumnCount - 1, 0);
                   
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
            Contact contact = new Contact();
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {

                    netw.NetElementPanel.RowCount++;
                    netw.Height = netw.Height + 50;
                    netw.NetElementPanel.Controls.Add(contact, 1, 1);
                }
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {
                    tLPEditor.Controls.Remove(netw);
                    tLPEditor.Dispose();

                }

            }

        }
        private void ToolStripButton12_Click(object sender, EventArgs e)
        {
            frmEditor frm = new frmEditor();
            frm.Show();
        }

        private void toolStripButton13_Click(object sender, EventArgs e)
        {
            
        }

        private void tLPEditor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Создаем экземпляр frmSize класса FormSize:
            FormSize frmSize = new FormSize();

            // Присваиваем текущие значения высоты и ширины формы переменным height и width
            frmSize.height = this.Height;
            frmSize.width = this.Width;

            //Cоздаем экземпляр xmlser класса XmlSerializer
            XmlSerializer xmlser = new XmlSerializer(typeof(FormSize));

            //Создаем переменную filename, которой присваиваем
            //название файла applicationSettings.xml в текущей директории
            string filename = System.Environment.CurrentDirectory + "\\applicationSettings.xml";

            //Создаем поток filestream для создания XML-файла
            FileStream filestream = new FileStream(filename, FileMode.Create);

            //Создаем сериализацию для экземпляра frmSize
            xmlser.Serialize(filestream, frmSize);

            //Закрываем поток
            filestream.Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            NetworkElement networkElement = new NetworkElement();
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {
                    
                    netw.NetElementPanel.Controls.Add(networkElement, 1, 0);
                   
                    break;
                }
            }
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            NetworkElement n = new NetworkElement();
            foreach (NewNetwork netw in tLPEditor.Controls)
            {
                if (netw.ContainsFocus)
                {
                    netw.NetElementPanel.Controls.Add(n);
                    break;
                }
            }
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            
        }


        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvVarTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void tLPEditor_ControlAdded(object sender, ControlEventArgs e)
        {
            //AutoVarible av = new AutoVarible();


            //if (av.ShowDialog(this) == DialogResult.OK)
            //{
            //    dgvVarTable.Rows.Add(av.NameVar, av.TypeVar, av.CommentVar);
                

            //}
        }

        private void tsmiPOU_Click(object sender, EventArgs e)
        {
            sc3.Panel1Collapsed = tsmiPOU.Checked;
        }
    }
   
}
       
    



