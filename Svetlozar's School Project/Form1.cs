using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Svetlozar_s_School_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(Triangle);
            thread1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread thread2 = new Thread(Rectangle);
            thread2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void Triangle()
        {

            int randomNum = new Random().Next(1, 100);
            for (int i = 0; i < randomNum; i++)
            {

                Random rnd = new Random();
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Pen randomPen = new Pen(randomColor, 4);
                int n = new Random().Next(20, 170);
                PointF point1 = new PointF(new Random().Next(200, this.Width) + new Random().Next(20, 170), new Random().Next(0, this.Height - 50) + new Random().Next(20, 170));
                PointF point2 = new PointF(new Random().Next(200, this.Width) + new Random().Next(20, 170), new Random().Next(0, this.Height - 50) + new Random().Next(20, 170));
                PointF point3 = new PointF(new Random().Next(200, this.Width) + new Random().Next(20, 170), new Random().Next(0, this.Height - 50) + new Random().Next(20, 170));
                PointF[] curvePoints =
                         {
                 point1,
                 point2,
                 point3,
             };
                this.CreateGraphics().DrawPolygon(randomPen, curvePoints);
                Thread.Sleep(2000);
            }
        }

        public void Rectangle()
        {
            int randomNum = new Random().Next(1, 100);
            for (int i = 0; i < randomNum; i++)
            {
                    Random rnd = new Random();
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    int b = new Random().Next(20, 170);
                    int n = new Random().Next(20, 170);
                    this.CreateGraphics().DrawRectangle(new Pen(randomColor, 4), new Rectangle(new Random().Next(200, this.Width), new Random().Next(0, this.Height - 50), n, b));
                    Thread.Sleep(3000);
            }
        }
    }
}
