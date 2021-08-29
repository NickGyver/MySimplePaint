
namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNewFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.DropDownShapesButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineShapeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.circleShapeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleShapeButton = new System.Windows.Forms.ToolStripMenuItem();
            this.lineSizeButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.DropDownLineColorButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.paletteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.fillButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.paletteFillButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundColorButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.backgroundPalleteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lineColorDialog = new System.Windows.Forms.ColorDialog();
            this.fillColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButton,
            this.helpButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuButton
            // 
            this.menuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileButton,
            this.toolStripSeparator1,
            this.saveFileButton,
            this.saveAsButton,
            this.toolStripSeparator2,
            this.exitButton});
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(50, 20);
            this.menuButton.Text = "Menu";
            // 
            // openFileButton
            // 
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(122, 22);
            this.openFileButton.Text = "Open file";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("saveFileButton.Image")));
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(122, 22);
            this.saveFileButton.Text = "Save File";
            // 
            // saveAsButton
            // 
            this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(122, 22);
            this.saveAsButton.Text = "Save as...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(122, 22);
            this.exitButton.Text = "Exit";
            // 
            // helpButton
            // 
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(44, 20);
            this.helpButton.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewFileButton,
            this.toolStripSaveFileButton,
            this.toolStripOpenFileButton,
            this.toolStripButton1,
            this.DropDownShapesButton,
            this.lineSizeButton,
            this.DropDownLineColorButton,
            this.paletteButton,
            this.toolStripButton2,
            this.fillButton,
            this.paletteFillButton,
            this.toolStripButton3,
            this.backgroundColorButton,
            this.backgroundPalleteColor,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNewFileButton
            // 
            this.toolStripNewFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewFileButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNewFileButton.Image")));
            this.toolStripNewFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewFileButton.Name = "toolStripNewFileButton";
            this.toolStripNewFileButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripNewFileButton.Text = "New File";
            this.toolStripNewFileButton.Click += new System.EventHandler(this.toolStripNewFileButton_Click);
            // 
            // toolStripSaveFileButton
            // 
            this.toolStripSaveFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveFileButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveFileButton.Image")));
            this.toolStripSaveFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveFileButton.Name = "toolStripSaveFileButton";
            this.toolStripSaveFileButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripSaveFileButton.Text = "Save file";
            // 
            // toolStripOpenFileButton
            // 
            this.toolStripOpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenFileButton.Image")));
            this.toolStripOpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenFileButton.Name = "toolStripOpenFileButton";
            this.toolStripOpenFileButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenFileButton.Text = "Open File";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(6, 25);
            // 
            // DropDownShapesButton
            // 
            this.DropDownShapesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DropDownShapesButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineShapeButton,
            this.circleShapeButton,
            this.rectangleShapeButton});
            this.DropDownShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("DropDownShapesButton.Image")));
            this.DropDownShapesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownShapesButton.Name = "DropDownShapesButton";
            this.DropDownShapesButton.Size = new System.Drawing.Size(29, 22);
            this.DropDownShapesButton.Text = "Shapes";
            // 
            // lineShapeButton
            // 
            this.lineShapeButton.CheckOnClick = true;
            this.lineShapeButton.Name = "lineShapeButton";
            this.lineShapeButton.Size = new System.Drawing.Size(126, 22);
            this.lineShapeButton.Text = "Line";
            this.lineShapeButton.Click += new System.EventHandler(this.lineShapeButton_Click);
            // 
            // circleShapeButton
            // 
            this.circleShapeButton.CheckOnClick = true;
            this.circleShapeButton.Name = "circleShapeButton";
            this.circleShapeButton.Size = new System.Drawing.Size(126, 22);
            this.circleShapeButton.Text = "Circle";
            this.circleShapeButton.Click += new System.EventHandler(this.circleShapeButton_Click);
            // 
            // rectangleShapeButton
            // 
            this.rectangleShapeButton.CheckOnClick = true;
            this.rectangleShapeButton.Name = "rectangleShapeButton";
            this.rectangleShapeButton.Size = new System.Drawing.Size(126, 22);
            this.rectangleShapeButton.Text = "Rectangle";
            this.rectangleShapeButton.Click += new System.EventHandler(this.rectangleShapeButton_Click);
            // 
            // lineSizeButton
            // 
            this.lineSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("lineSizeButton.Image")));
            this.lineSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineSizeButton.Name = "lineSizeButton";
            this.lineSizeButton.Size = new System.Drawing.Size(29, 22);
            this.lineSizeButton.Text = "Line Size";
            // 
            // DropDownLineColorButton
            // 
            this.DropDownLineColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DropDownLineColorButton.Image = ((System.Drawing.Image)(resources.GetObject("DropDownLineColorButton.Image")));
            this.DropDownLineColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownLineColorButton.Name = "DropDownLineColorButton";
            this.DropDownLineColorButton.Size = new System.Drawing.Size(29, 22);
            this.DropDownLineColorButton.Text = "Line Colors";
            // 
            // paletteButton
            // 
            this.paletteButton.Image = ((System.Drawing.Image)(resources.GetObject("paletteButton.Image")));
            this.paletteButton.Name = "paletteButton";
            this.paletteButton.Size = new System.Drawing.Size(87, 25);
            this.paletteButton.Text = "Line color";
            this.paletteButton.Click += new System.EventHandler(this.paletteButton_Click_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(6, 25);
            // 
            // fillButton
            // 
            this.fillButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fillButton.Image = ((System.Drawing.Image)(resources.GetObject("fillButton.Image")));
            this.fillButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(29, 22);
            this.fillButton.Text = "Fill";
            // 
            // paletteFillButton
            // 
            this.paletteFillButton.Image = ((System.Drawing.Image)(resources.GetObject("paletteFillButton.Image")));
            this.paletteFillButton.Name = "paletteFillButton";
            this.paletteFillButton.Size = new System.Drawing.Size(80, 25);
            this.paletteFillButton.Text = "Fill color";
            this.paletteFillButton.Click += new System.EventHandler(this.paletteFillButton_Click_1);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(6, 25);
            // 
            // backgroundColorButton
            // 
            this.backgroundColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backgroundColorButton.Image = ((System.Drawing.Image)(resources.GetObject("backgroundColorButton.Image")));
            this.backgroundColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(29, 22);
            this.backgroundColorButton.Text = "Background Color";
            // 
            // backgroundPalleteColor
            // 
            this.backgroundPalleteColor.Image = ((System.Drawing.Image)(resources.GetObject("backgroundPalleteColor.Image")));
            this.backgroundPalleteColor.Name = "backgroundPalleteColor";
            this.backgroundPalleteColor.Size = new System.Drawing.Size(129, 25);
            this.backgroundPalleteColor.Text = "Background color";
            this.backgroundPalleteColor.Click += new System.EventHandler(this.backgroundPalleteColor_Click_1);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(6, 25);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 401);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MyPaint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuButton;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveFileButton;
        private System.Windows.Forms.ToolStripMenuItem saveAsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNewFileButton;
        private System.Windows.Forms.ToolStripButton toolStripSaveFileButton;
        private System.Windows.Forms.ToolStripButton toolStripOpenFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton DropDownShapesButton;
        private System.Windows.Forms.ToolStripMenuItem lineShapeButton;
        private System.Windows.Forms.ToolStripMenuItem circleShapeButton;
        private System.Windows.Forms.ToolStripMenuItem rectangleShapeButton;
        private System.Windows.Forms.ToolStripMenuItem helpButton;
        private System.Windows.Forms.ToolStripDropDownButton DropDownLineColorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton lineSizeButton;
        private System.Windows.Forms.ToolStripDropDownButton fillButton;
        private System.Windows.Forms.ToolStripDropDownButton backgroundColorButton;
        private System.Windows.Forms.ColorDialog lineColorDialog;
        private System.Windows.Forms.ColorDialog fillColorDialog;
        private System.Windows.Forms.ColorDialog backgroundColorDialog;
        private System.Windows.Forms.ToolStripMenuItem paletteButton;
        private System.Windows.Forms.ToolStripMenuItem paletteFillButton;
        private System.Windows.Forms.ToolStripSeparator toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem backgroundPalleteColor;
        private System.Windows.Forms.ToolStripSeparator toolStripButton4;
    }
}

