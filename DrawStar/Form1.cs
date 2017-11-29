using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class drawStar : Form
    {
        public drawStar()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            drawButton.Visible = false;
            whatLabel.Visible = false;
 
            xLabel.Visible = false;
            yLabel.Visible = false;
            sizeLabel.Visible = false;

            xInput.Visible = false;
            yInput.Visible = false;
            sizeInput.Visible = false;

            float xValue = Convert.ToSingle(xInput.Text);
            float yValue = Convert.ToSingle(yInput.Text);
            float sizeValue = Convert.ToSingle(sizeInput.Text);
            Pen drawPen = new Pen(Color.Black);

            DrawStar(drawPen, xValue, yValue, sizeValue);
        }

        public void DrawStar(Pen drawPen, float x, float y, float scale)
        {
            Graphics g = this.CreateGraphics();
            Random boo = new Random();
            float colour = boo.Next(1, 5);
            if (colour == 1)
            {
                drawPen = new Pen(Color.Red);
            }
            else if (colour == 2)
            {
                drawPen = new Pen(Color.Blue);
            }
            else if (colour == 3)
            {
                drawPen = new Pen(Color.Green);
            }
            else
            {
                drawPen = new Pen(Color.Black);
            }
            float size = scale / 266;

            float x1 = 130 * size + x, x2 = 160 * size + x, x3 = 260 * size + x, x4 = 180 * size + x,
                x5 = 210 * size + x, x6 = 130 * size + x, x7 = 50 * size + x, x8 = 80 * size + x
                , x9 = 5 * size + x, x10 = 100 * size + x;
            float y1 = 5 * size + y, y2 = 100 * size + y, y3 = 100 * size + y, y4 = 160 * size + y
                , y5 = 250 * size + y, y6 = 200 * size + y, y7 = 250 * size + y, y8 = 160 * size + y
                , y9 = 100 * size + y, y10 = 100 * size + y;



            g.DrawLine(drawPen, x1, y1, x2, y2);
            g.DrawLine(drawPen, x2, y2, x3, y3);
            g.DrawLine(drawPen, x3, y3, x4, y4);
            g.DrawLine(drawPen, x4, y4, x5, y5);
            g.DrawLine(drawPen, x5, y5, x6, y6);
            g.DrawLine(drawPen, x6, y6, x7, y7);
            g.DrawLine(drawPen, x7, y7, x8, y8);
            g.DrawLine(drawPen, x8, y8, x9, y9);
            g.DrawLine(drawPen, x9, y9, x10,y10);
            g.DrawLine(drawPen, x10,y10,x1, y1);
        }
    }
}
