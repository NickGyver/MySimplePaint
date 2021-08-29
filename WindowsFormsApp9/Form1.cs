using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        Bitmap bmp;


        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(1000, 1000);
            pictureBox1.Image = bmp;
            gfx = Graphics.FromImage(pictureBox1.Image);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);

            //gfx = CreateGraphics();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //  gfx.Dispose();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (lineShapeButton.CheckState == CheckState.Checked)
            {

                if (e.Button == MouseButtons.Left)
                {
                    gfx.FillRectangle(new SolidBrush(lineColorDialog.Color), e.X, e.Y, 5, 5);
                    pictureBox1.Image = bmp;
                }
            }
        }

        private void toolStripNewFileButton_Click(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            Refresh();
        }

        private void backgroundPalleteColor_Click_1(object sender, EventArgs e)
        {
            backgroundColorDialog.ShowDialog();
            pictureBox1.BackColor = backgroundColorDialog.Color;
        }

        private void paletteFillButton_Click_1(object sender, EventArgs e)
        {
            fillColorDialog.ShowDialog();
        }

        private void paletteButton_Click_1(object sender, EventArgs e)
        {
            lineColorDialog.ShowDialog();
        }

        private void lineShapeButton_Click(object sender, EventArgs e)
        {
            circleShapeButton.Checked = false;
            rectangleShapeButton.Checked = false;
        }

        private void circleShapeButton_Click(object sender, EventArgs e)
        {
            lineShapeButton.Checked = false;
            rectangleShapeButton.Checked = false;
        }
        private void rectangleShapeButton_Click(object sender, EventArgs e)
        {
            lineShapeButton.Checked = false;
            circleShapeButton.Checked = false;
        }
    }
}
