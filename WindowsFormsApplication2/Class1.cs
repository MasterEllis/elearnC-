using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{

    class PaintPanel : Panel
    {
       
        double a=1, b=0; //коэффициенты функции

        // перегруженная функция формы OnPaint 
        protected override void OnPaint(PaintEventArgs e)

        {

            int x1, y1, x2, y2; // координаты точек 
            int x0 = 230, y0 = 300; // начало координат
            
            Graphics g = e.Graphics;// создание объекта класса Graphics

            // вывод надписи «График»
            g.DrawString("График фкнкции y="+a+"x+"+b, new Font("Times New Roman", 18), new SolidBrush(Color.Black), 80, 0);
  

            // вывод осей 
            g.DrawLine(new Pen(Color.Black), x0, y0, x0 + 260, y0);
            g.DrawLine(new Pen(Color.Black), x0, y0, x0, y0 - 260);

            g.DrawString("у", new Font("Currier", 10), new SolidBrush(Color.Black), x0 - 10, y0 - 260);
            g.DrawString("x", new Font("Currier", 10), new SolidBrush(Color.Black), x0 + 260, y0 + 5);

            // построение графика 
            x1 = x0; y1 =y0 - (int)(- b* 10);
            for (int x = 1; x < 20; x++)

            {
                x2 = x0 + x * 10;
                y2 = y0 - (int)((a*x-b) * 10);

                g.DrawLine(new Pen(Color.Blue, 2), x1, y1, x2, y2);

                x1 = x2;
                y1 = y2;

            }

        }

        public void setA(double x)
        {
            a = x;
        }
        public void setB(double x)
        {
            b = x;
        }
    }
}
