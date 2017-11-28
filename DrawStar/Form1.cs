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
            otherLabel.Visible = false;
            xLabel.Visible = false;
            yLabel.Visible = false;
            sizeLabel.Visible = false;
            redRadio.Visible = false;
            greenRadio.Visible = false;
            blueRadio.Visible = false;
            xInput.Visible = false;
            yInput.Visible = false;
            sizeInput.Visible = false;

            var xValue = Convert.ToSingle(xInput.Text);
            var yValue = Convert.ToSingle(yInput.Text);
            var sizeValue = Convert.ToSingle(sizeInput.Text);
            Pen drawPen = new Pen(Color.Black);

            DrawStar(drawPen, xValue, yValue, sizeValue);
        }

        public void DrawStar(Pen drawPen, float x, float y, float size)
        {
            Graphics g = this.CreateGraphics();
            if (redRadio.Checked)
            {
                drawPen = new Pen(Color.Red);
            }
            else if (blueRadio.Checked)
            {
                drawPen = new Pen(Color.Blue);
            }
            else if (greenRadio.Checked)
            {
                drawPen = new Pen(Color.Green);
            }
            else
            {
                drawPen = new Pen(Color.Black);
            }

            g.DrawLine(drawPen, 130, 5, 160, 100);
            g.DrawLine(drawPen, 160, 100, 260, 100);
            g.DrawLine(drawPen, 260, 100, 180, 160);
            g.DrawLine(drawPen, 180, 160, 210, 250);
            g.DrawLine(drawPen, 210, 250, 130, 200);
            g.DrawLine(drawPen, 130, 200, 50, 250);
            g.DrawLine(drawPen, 50, 250, 80, 160);
            g.DrawLine(drawPen, 80, 160, 5, 100);
            g.DrawLine(drawPen, 5, 100, 100, 100);
            g.DrawLine(drawPen, 100, 100, 130, 5);
        }
    }
}
