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
using System.Collections;

namespace LDEditor
{

    public partial class frmEditor : Form
    {

        public string DocName = "";
        List<Network> networks = new List<Network>();
        public frmEditor()
        {
            InitializeComponent();

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

        private void frmEditor_Load(object sender, EventArgs e)
        {
            //Network n = new Network();
            //tlpEditor.Controls.Add(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Network network = new Network();
            int i = workspace.tlpEditor.Controls.Count + 1;
            network.Height = 50;
            network.AutoSize = false;
            network.Anchor = (AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Left);

            workspace.tlpEditor.Controls.Add(network);



        }

        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Network n in workspace.tlpEditor.Controls)
                if (n.ContainsFocus)
                {
                    n.AddRowNetwork();
                }
        }
    }
}

