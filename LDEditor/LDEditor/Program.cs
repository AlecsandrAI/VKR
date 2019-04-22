using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFControlLibrary;


namespace LDEditor
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());

            
            //List<NewNetwork> NetworksList = new List<NewNetwork>();
            //IEnumerator GetEnumerator()
            //{
            //    return NetworksList.GetEnumerator();
            //}

            //IEnumerator CurrentNetwork = NetworksList.GetEnumerator();
            //    while (CurrentNetwork.MoveNext())   // пока не будет возвращено false
            //{
            //    List<NewNetwork> item = (List<NewNetwork>)CurrentNetwork.Current;     // берем элемент на текущей позиции
            //    MessageBox.Show(item.ToString());
            //}
            //CurrentNetwork.Reset(); // сбрасываем указатель в начало массива
            //for (int i = 0; i < 20; i++)
            //{
            //    NetworksList.Add(new NewNetwork());

            //}


            //MessageBox.Show(NetworksList.Count.ToString());
        }

    }
   
    
}

