using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbolcu_Bulma_while
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            int bul = 0;
            int i = 0;
            while (i<listBox1.Items.Count)
            {
                if (listBox1.Items[i].ToString() == ad) 
                {
                    bul++;
                    MessageBox.Show(ad + " Adlı Futbolcu " + (i + 1) + " .Sırada Bulundu");
                    break;
                }
                i++;
            }
            if (bul == 0) 
            {
                MessageBox.Show(ad + " Adlı Futbolcu Bulunamadı");
            }
        }
    }
}
