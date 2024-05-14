using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_GPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 1000;
            this.Height = 600;
            bm = new Bitmap(picCanvas.Width, picCanvas.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            picCanvas.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen draw = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(draw, px, py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            picCanvas.Refresh();
            x = e.X;
            y=e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index==3)
            {
                g.DrawEllipse(draw,cX,cY,sX,sY);
            }

            if (index == 4)
            {
                g.DrawRectangle(draw,cX,cY,sX,sY);
            }

            if (index == 5)
            {
                g.DrawLine(draw,cX,cY,x,y);
            }
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            index = 6;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(draw, cX, cY, sX, sY);
                }

                if (index == 4)
                {
                    g.DrawRectangle(draw, cX, cY, sX, sY);
                }

                if (index == 5)
                {
                    g.DrawLine(draw, cX, cY, x, y);
                }
            }    
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            picCanvas.Image = bm;
            index = 0;
        }


        private void btnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
