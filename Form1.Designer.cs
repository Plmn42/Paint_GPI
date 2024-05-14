namespace Paint_GPI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientPanel1 = new Paint_GPI.GradientPanel();
            this.gradientPanelTop = new Paint_GPI.GradientPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.picColors = new System.Windows.Forms.PictureBox();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPickColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gradientPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColors)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 175);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1417, 614);
            this.picCanvas.TabIndex = 7;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1417, 36);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.importToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.importToolStripMenuItem.Text = "Save";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(169, 34);
            this.importToolStripMenuItem1.Text = "Import";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.toolStripSeparator1,
            this.cutToolStripMenuItem,
            this.toolStripSeparator2,
            this.copyToolStripMenuItem,
            this.toolStripSeparator3,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Z";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(226, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + x";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(226, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(226, 6);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Angle = 60F;
            this.gradientPanel1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 789);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1417, 55);
            this.gradientPanel1.TabIndex = 6;
            this.gradientPanel1.TopColor = System.Drawing.Color.MidnightBlue;
            // 
            // gradientPanelTop
            // 
            this.gradientPanelTop.Angle = 60F;
            this.gradientPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientPanelTop.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gradientPanelTop.Controls.Add(this.btnPickColor);
            this.gradientPanelTop.Controls.Add(this.btnClear);
            this.gradientPanelTop.Controls.Add(this.picColors);
            this.gradientPanelTop.Controls.Add(this.btnTriangle);
            this.gradientPanelTop.Controls.Add(this.btnRectangle);
            this.gradientPanelTop.Controls.Add(this.btnEraser);
            this.gradientPanelTop.Controls.Add(this.btnPencil);
            this.gradientPanelTop.Controls.Add(this.btnFill);
            this.gradientPanelTop.Controls.Add(this.btnCircle);
            this.gradientPanelTop.Controls.Add(this.btnColor);
            this.gradientPanelTop.Controls.Add(this.btnLine);
            this.gradientPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelTop.Location = new System.Drawing.Point(0, 36);
            this.gradientPanelTop.Name = "gradientPanelTop";
            this.gradientPanelTop.Size = new System.Drawing.Size(1417, 139);
            this.gradientPanelTop.TabIndex = 5;
            this.gradientPanelTop.TopColor = System.Drawing.Color.MidnightBlue;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1330, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 35);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // picColors
            // 
            this.picColors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picColors.Image = ((System.Drawing.Image)(resources.GetObject("picColors.Image")));
            this.picColors.Location = new System.Drawing.Point(0, 0);
            this.picColors.Name = "picColors";
            this.picColors.Size = new System.Drawing.Size(384, 129);
            this.picColors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picColors.TabIndex = 0;
            this.picColors.TabStop = false;
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackColor = System.Drawing.Color.White;
            this.btnTriangle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTriangle.FlatAppearance.BorderSize = 0;
            this.btnTriangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTriangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTriangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriangle.ForeColor = System.Drawing.Color.White;
            this.btnTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btnTriangle.Image")));
            this.btnTriangle.Location = new System.Drawing.Point(1011, 85);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(48, 45);
            this.btnTriangle.TabIndex = 10;
            this.btnTriangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTriangle.UseVisualStyleBackColor = false;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.White;
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRectangle.FlatAppearance.BorderSize = 0;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.ForeColor = System.Drawing.Color.White;
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(1011, 34);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(48, 45);
            this.btnRectangle.TabIndex = 9;
            this.btnRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.Transparent;
            this.btnEraser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEraser.FlatAppearance.BorderSize = 0;
            this.btnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ForeColor = System.Drawing.Color.White;
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEraser.Location = new System.Drawing.Point(843, 34);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(100, 95);
            this.btnEraser.TabIndex = 8;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.Transparent;
            this.btnPencil.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPencil.FlatAppearance.BorderSize = 0;
            this.btnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.ForeColor = System.Drawing.Color.White;
            this.btnPencil.Image = ((System.Drawing.Image)(resources.GetObject("btnPencil.Image")));
            this.btnPencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPencil.Location = new System.Drawing.Point(737, 34);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(100, 95);
            this.btnPencil.TabIndex = 7;
            this.btnPencil.Text = " Pencil";
            this.btnPencil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Transparent;
            this.btnFill.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFill.FlatAppearance.BorderSize = 0;
            this.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFill.Location = new System.Drawing.Point(631, 34);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(100, 95);
            this.btnFill.TabIndex = 6;
            this.btnFill.Text = "Fill";
            this.btnFill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFill.UseVisualStyleBackColor = false;
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.White;
            this.btnCircle.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCircle.FlatAppearance.BorderSize = 0;
            this.btnCircle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCircle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircle.ForeColor = System.Drawing.Color.White;
            this.btnCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnCircle.Image")));
            this.btnCircle.Location = new System.Drawing.Point(957, 34);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(48, 45);
            this.btnCircle.TabIndex = 5;
            this.btnCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.Location = new System.Drawing.Point(524, 34);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(100, 95);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = " Color";
            this.btnColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLine.FlatAppearance.BorderSize = 0;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.ForeColor = System.Drawing.Color.White;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(957, 85);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(48, 45);
            this.btnLine.TabIndex = 4;
            this.btnLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPickColor
            // 
            this.btnPickColor.BackColor = System.Drawing.Color.White;
            this.btnPickColor.Location = new System.Drawing.Point(411, 34);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(74, 73);
            this.btnPickColor.TabIndex = 9;
            this.btnPickColor.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 844);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.gradientPanelTop);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gradientPanelTop.ResumeLayout(false);
            this.gradientPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnLine;
        private GradientPanel gradientPanelTop;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnPencil;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.PictureBox picColors;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPickColor;
    }
}

