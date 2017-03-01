using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        PaintPanel pp; //панель для отрисовки графика
        public Form1()

        {
            InitializeComponent();
            this.CenterToScreen(); // форма в центре экрана дисплея 

            this.Text = "Форма для рисования";
            pp = new PaintPanel();
            panel2.Controls.Add(pp);
            pp.Dock = System.Windows.Forms.DockStyle.Fill;
            pp.Visible = false;

        }

        private void bBuild_Click(object sender, EventArgs e)
        {
            try {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                pp.setA(a);
                pp.setB(b);
                pp.Visible = true;
            }
            catch (Exception ex)
            {
                //MessageBox("Неправильные коэффициенты");
                
            }
            

        }
    }
    }
