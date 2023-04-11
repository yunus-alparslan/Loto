using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int puanımx=0;


        void puancount()
        {



            puanımx++;

            label7.Text = puanımx.ToString();
        }

        void lotom()
        {
            int loto1, loto2, loto3, loto4, loto5,lot1,lot2,lot3,lot4,lot5;

            Random lotom = new Random();

            loto1 = lotom.Next(1, 3);
            loto2 = lotom.Next(1, 3);
            loto3 = lotom.Next(1, 3);
            loto4 = lotom.Next(1, 3);
            loto5 = lotom.Next(1, 3);

            lot1 = Convert.ToInt16(textBox1.Text);
            lot2 = Convert.ToInt16(textBox2.Text);
            lot3 = Convert.ToInt16(textBox3.Text);
            lot4 = Convert.ToInt16(textBox4.Text);
            lot5 = Convert.ToInt16(textBox5.Text);
            if (lot1 == loto1)
            {
                textBox1.BackColor = Color.Green;
                
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }

            if (lot2 == loto2)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }

            if (lot3 == loto3)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }

            if (lot4 == loto4)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }

            if (lot5 == loto5)
            {
                textBox5.BackColor = Color.Green;
            }
            else
            {
                textBox5.BackColor = Color.Red;
            }


            if (lot1 == loto1 & lot2 == loto2 & lot3 == loto3 & lot4 == loto4 & lot5 == loto5)
            {
                this.BackColor = Color.Yellow;
                puancount();
                MessageBox.Show("Kazandığınız Puan "+label7.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
  

            }
   

            label1.Text = loto1.ToString();
            label2.Text = loto2.ToString();
            label3.Text = loto3.ToString();
            label4.Text = loto4.ToString();
            label5.Text = loto5.ToString();
           
        }


        

        private void button1_Click(object sender, EventArgs e)
        {
            lotom();
        }
    }
}
