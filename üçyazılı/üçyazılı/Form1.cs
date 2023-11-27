using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace üçyazılı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y1=Convert.ToDouble(textBox1.Text);
            double y2=Convert.ToDouble(textBox2.Text);
            double y3=Convert.ToDouble(textBox4.Text);

            Ortalama ortalama1=new Ortalama(y1,y2,y3);

            label5.Text=ortalama1.OrtalamaHesapla().ToString();

        }
    }
}
