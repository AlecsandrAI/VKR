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
using System.Xml.Serialization;
using System.IO;

namespace LDEditor
{
    [Serializable]
    public partial class frmEditor : Form
    {

        public string DocName = ""; 

        public frmEditor()
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

        private void lineHoriz1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            //netwo1.Controls.Add(l);
        }

        private void netwo1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void frmEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //XmlSerializer xmlser = new XmlSerializer(typeof(frmEditor.ControlCollection));
            ////Создаем переменную filename, которой присваиваем
            ////название файла Editor.xml в текущей директории
            //string filename = System.Environment.CurrentDirectory + "\\Editor.xml";
            ////Создаем поток filestream для создания XML-файла
            //FileStream filestream = new FileStream(filename, FileMode.Create);
            ////Создаем сериализацию для экземпляра frmSize
            //xmlser.Serialize(filestream, sender);
            ////Закрываем поток
            //filestream.Close();
        }
    }
}
