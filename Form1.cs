using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
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

            InitializeMenu();
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
        Stack<Bitmap> undoStack = new Stack<Bitmap>();

        private void InitializeMenu()
        {
            MenuStrip menuStrip = new MenuStrip();

            ToolStripMenuItem fileMenu = new ToolStripMenuItem("File");
            ToolStripMenuItem editMenu = new ToolStripMenuItem("Edit");

            ToolStripMenuItem saveMenuItem = new ToolStripMenuItem("Save");
            saveMenuItem.Click += SaveMenuItem_Click;
            ToolStripMenuItem importMenuItem = new ToolStripMenuItem("Import");
            importMenuItem.Click += ImportMenuItem_Click;
            ToolStripMenuItem undoMenuItem = new ToolStripMenuItem("Undo");
            undoMenuItem.Click += UndoMenuItem_Click;
            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Copy");
            copyMenuItem.Click += CopyMenuItem_Click;
            ToolStripMenuItem cutMenuItem = new ToolStripMenuItem("Cut");
            cutMenuItem.Click += CutMenuItem_Click;
            ToolStripMenuItem pasteMenuItem = new ToolStripMenuItem("Paste");
            pasteMenuItem.Click += PasteMenuItem_Click;

            fileMenu.DropDownItems.Add(saveMenuItem);
            fileMenu.DropDownItems.Add(importMenuItem);

            editMenu.DropDownItems.Add(undoMenuItem);
            editMenu.DropDownItems.Add(copyMenuItem);
            editMenu.DropDownItems.Add(cutMenuItem);
            editMenu.DropDownItems.Add(pasteMenuItem);

            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(editMenu);

            this.Controls.Add(menuStrip);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.C))
            {
                CopyMenuItem_Click(this, EventArgs.Empty);
                return true;
            }
            if (keyData == (Keys.Control | Keys.X))
            {
                CutMenuItem_Click(this, EventArgs.Empty);
                return true;
            }
            if (keyData == (Keys.Control | Keys.V))
            {
                PasteMenuItem_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bm.Save(sfd.FileName);
            }
        }

        private void ImportMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files (*.bmp, *.jpg, *.png)|*.bmp;*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap importedImage = new Bitmap(ofd.FileName);
                g.DrawImage(importedImage, 0, 0);
                picCanvas.Image = bm;
            }
        }

        private void UndoMenuItem_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                bm = undoStack.Pop();
                g = Graphics.FromImage(bm);
                picCanvas.Image = bm;
                picCanvas.Refresh();
            }
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(bm);
        }

        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(bm);
            g.Clear(Color.White);
            picCanvas.Refresh();
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                Image clipboardImage = Clipboard.GetImage();
                g.DrawImage(clipboardImage, 0, 0);
                picCanvas.Image = bm;
                picCanvas.Refresh();
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

            undoStack.Push((Bitmap)bm.Clone());
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
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

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

            if (index == 6)
            {
                DrawTriangle(g, cX, cY, x, y);
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

        private void DrawTriangle(Graphics g, int startX, int startY, int endX, int endY)
        {
            Point[] points = new Point[3];
            points[0] = new Point(startX + (endX - startX) / 2, startY);
            points[1] = new Point(startX, endY);
            points[2] = new Point(endX, endY);

            g.DrawPolygon(draw, points);
        }

        private void picColors_Click(object sender, EventArgs e) { }

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

                if (index == 6)
                {
                    DrawTriangle(g, cX, cY, x, y);
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
            new_color = cd.Color;
            picColors.BackColor = cd.Color;
            draw.Color = cd.Color;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float x_ratio = 1f * pb.Image.Width / pb.Width;
            float y_ratio = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * x_ratio), (int)(pt.Y * y_ratio));
        }

        private void picColors_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(picColors, e.Location);
            Color pickedColor = ((Bitmap)picColors.Image).GetPixel(point.X, point.Y);
            btnPickColor.BackColor = pickedColor;
            new_color = pickedColor;
            draw.Color = pickedColor;
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }

        private void importToolStripMenuItem1_Click(object sender, EventArgs e) { }
    }
}
