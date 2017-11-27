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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            float xValue, yValue, sizeValue;

            xValue = Convert.ToSingle(xInput);
            yValue = Convert.ToSingle(yInput);
            sizeValue = Convert.ToSingle(sizeInput);

            Pen DrawPen;

            if (redRadio.Checked)
            {
                DrawPen = new Pen(Color.Red);
            }
            else if (blueRadio.Checked)
            {
                DrawPen = new Pen(Color.Blue);
            }
            else
            {
                DrawPen = new Pen(Color.Green);
            }
        }
    }
}
