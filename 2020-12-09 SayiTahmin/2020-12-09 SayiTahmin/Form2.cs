using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_12_09_SayiTahmin
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
                if(8 == i)
                {
                    break; // döngüyü kırar, alttaki kodlar çalışmaya devam eder
                    //return;//sonrasındaki kodları çalıştırmaz
                }
            }

            listBox1.Items.Add("Döngü tamamlandı");
        }
    }
}
