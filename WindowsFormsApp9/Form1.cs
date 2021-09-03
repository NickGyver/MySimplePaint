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
using System.Drawing.Imaging;


namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        Graphics gfx;
        Bitmap bmp;
        Point p1, p2;
        string shapes = "point";
        int size = 2;
        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            gfx = Graphics.FromImage(pictureBox1.Image);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gfx.Clear(Color.White);
            sizeOfShape.Text = size.ToString();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripNewFileButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Clean all and make new image?", "New file", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                gfx.Clear(Color.White);
                Refresh();
            }
           
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
            shapes = "line";

            circleShapeButton.Checked = false;
            rectangleShapeButton.Checked = false;
        }

        private void circleShapeButton_Click(object sender, EventArgs e)
        {
            shapes = "elipse";

            lineShapeButton.Checked = false;
            rectangleShapeButton.Checked = false;
        }
        private void rectangleShapeButton_Click(object sender, EventArgs e)
        {
            shapes = "rectangle";

            lineShapeButton.Checked = false;
            circleShapeButton.Checked = false;
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (shapes == "point")
                    {
                        gfx.FillRectangle(new SolidBrush(lineColorDialog.Color), e.X, e.Y, size, size);
                    }
                    //if (shapes == "clean")
                    //{
                    //    gfx.FillRectangle(new SolidBrush(Color.White), e.X, e.Y, 20, 20);
                    //}
                    pictureBox1.Image = bmp;

                }
            }
            catch (Exception)
            {


            }

            xPositionLabel.Text = e.X.ToString();
            yPositionLabel.Text = e.Y.ToString();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                p2.X = e.X;
                p2.Y = e.Y;

                if (shapes == "line")
                {
                    gfx.DrawLine(new Pen(lineColorDialog.Color, size), p1.X, p1.Y, p2.X, p2.Y);
                }
                else if (shapes == "elipse")
                {
                    gfx.DrawEllipse(new Pen(lineColorDialog.Color, size), new Rectangle(p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y));

                }
                else if (shapes == "rectangle")
                {
                    gfx.DrawRectangle(new Pen(lineColorDialog.Color, size), new Rectangle(p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y));
                }

                pictureBox1.Image = bmp;
            }
            catch (Exception)
            {

            }           
        }
      
        private void size3pxButton_Click(object sender, EventArgs e)
        {
            size = 3;
            size5pxButton.Checked = false;
            size7pxButton.Checked = false;
            size9pxButton.Checked = false;
            sizeOfShape.Text = size.ToString();
        }

        private void size5pxButton_Click(object sender, EventArgs e)
        {
            size = 5;
            size3pxButton.Checked = false;
            size7pxButton.Checked = false;
            size9pxButton.Checked = false;
            sizeOfShape.Text = size.ToString();
        }

        private void size7pxButton_Click(object sender, EventArgs e)
        {
            size = 7;
            size3pxButton.Checked = false;
            size5pxButton.Checked = false;
            size9pxButton.Checked = false;
            sizeOfShape.Text = size.ToString();
        }

        private void size9pxButton_Click(object sender, EventArgs e)
        {
            size = 9;
            size3pxButton.Checked = false;
            size5pxButton.Checked = false;
            size7pxButton.Checked = false;
            sizeOfShape.Text = size.ToString();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();

                bmp.Dispose();
                gfx.Dispose();

                bmp = new Bitmap(openFileDialog1.FileName);

                pictureBox1.Image = bmp;

                gfx = Graphics.FromImage(pictureBox1.Image);
            }
            catch (Exception)
            {

            }
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();

                bmp.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);

                saveFileDialog1.Dispose();
            }
            catch (Exception)
            {

            }

        }

        private void toolStripOpenFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.ShowDialog();

                bmp.Dispose();
                gfx.Dispose();

                bmp = new Bitmap(openFileDialog1.FileName);

                pictureBox1.Image = bmp;

                gfx = Graphics.FromImage(pictureBox1.Image);
            }
            catch (Exception)
            {

            }
        }

        private void toolStripSaveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.ShowDialog();

                bmp.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);

                saveFileDialog1.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            p1.X = e.X;
            p1.Y = e.Y;
        }
    }
}
