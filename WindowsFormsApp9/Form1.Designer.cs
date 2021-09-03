
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
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.fillButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.redToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.paletteFillButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundColorButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.redToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundPalleteColor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripSeparator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lineColorDialog = new System.Windows.Forms.ColorDialog();
            this.fillColorDialog = new System.Windows.Forms.ColorDialog();
            this.backgroundColorDialog = new System.Windows.Forms.ColorDialog();
            this.size3pxButton = new System.Windows.Forms.ToolStripMenuItem();
            this.size5pxButton = new System.Windows.Forms.ToolStripMenuItem();
            this.size7pxButton = new System.Windows.Forms.ToolStripMenuItem();
            this.size9pxButton = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeOfShape = new System.Windows.Forms.ToolStripLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.xLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.xPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.yLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.yPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.openFileButton.Size = new System.Drawing.Size(180, 22);
            this.openFileButton.Text = "Open file";
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveAsButton
            // 
            this.saveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("saveAsButton.Image")));
            this.saveAsButton.Name = "saveAsButton";
            this.saveAsButton.Size = new System.Drawing.Size(180, 22);
            this.saveAsButton.Text = "Save as...";
            this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(180, 22);
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
            this.sizeOfShape,
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
            this.toolStripSaveFileButton.Click += new System.EventHandler(this.toolStripSaveFileButton_Click);
            // 
            // toolStripOpenFileButton
            // 
            this.toolStripOpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripOpenFileButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenFileButton.Image")));
            this.toolStripOpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenFileButton.Name = "toolStripOpenFileButton";
            this.toolStripOpenFileButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripOpenFileButton.Text = "Open File";
            this.toolStripOpenFileButton.Click += new System.EventHandler(this.toolStripOpenFileButton_Click);
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
            this.lineShapeButton.Size = new System.Drawing.Size(180, 22);
            this.lineShapeButton.Text = "Line";
            this.lineShapeButton.Click += new System.EventHandler(this.lineShapeButton_Click);
            // 
            // circleShapeButton
            // 
            this.circleShapeButton.CheckOnClick = true;
            this.circleShapeButton.Name = "circleShapeButton";
            this.circleShapeButton.Size = new System.Drawing.Size(180, 22);
            this.circleShapeButton.Text = "Circle";
            this.circleShapeButton.Click += new System.EventHandler(this.circleShapeButton_Click);
            // 
            // rectangleShapeButton
            // 
            this.rectangleShapeButton.CheckOnClick = true;
            this.rectangleShapeButton.Name = "rectangleShapeButton";
            this.rectangleShapeButton.Size = new System.Drawing.Size(180, 22);
            this.rectangleShapeButton.Text = "Rectangle";
            this.rectangleShapeButton.Click += new System.EventHandler(this.rectangleShapeButton_Click);
            // 
            // lineSizeButton
            // 
            this.lineSizeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineSizeButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.size3pxButton,
            this.size5pxButton,
            this.size7pxButton,
            this.size9pxButton});
            this.lineSizeButton.Image = ((System.Drawing.Image)(resources.GetObject("lineSizeButton.Image")));
            this.lineSizeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineSizeButton.Name = "lineSizeButton";
            this.lineSizeButton.Size = new System.Drawing.Size(29, 22);
            this.lineSizeButton.Text = "Line Size";
            // 
            // DropDownLineColorButton
            // 
            this.DropDownLineColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DropDownLineColorButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.DropDownLineColorButton.Image = ((System.Drawing.Image)(resources.GetObject("DropDownLineColorButton.Image")));
            this.DropDownLineColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DropDownLineColorButton.Name = "DropDownLineColorButton";
            this.DropDownLineColorButton.Size = new System.Drawing.Size(29, 22);
            this.DropDownLineColorButton.Text = "Line Colors";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "red";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "green";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "blue";
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
            this.fillButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem1,
            this.greenToolStripMenuItem1,
            this.blueToolStripMenuItem1});
            this.fillButton.Image = ((System.Drawing.Image)(resources.GetObject("fillButton.Image")));
            this.fillButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(29, 22);
            this.fillButton.Text = "Fill";
            // 
            // redToolStripMenuItem1
            // 
            this.redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            this.redToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem1.Text = "red";
            // 
            // greenToolStripMenuItem1
            // 
            this.greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            this.greenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem1.Text = "green";
            // 
            // blueToolStripMenuItem1
            // 
            this.blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            this.blueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem1.Text = "blue";
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
            this.backgroundColorButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem2,
            this.greenToolStripMenuItem2,
            this.blueToolStripMenuItem2});
            this.backgroundColorButton.Image = ((System.Drawing.Image)(resources.GetObject("backgroundColorButton.Image")));
            this.backgroundColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backgroundColorButton.Name = "backgroundColorButton";
            this.backgroundColorButton.Size = new System.Drawing.Size(29, 22);
            this.backgroundColorButton.Text = "Background Color";
            // 
            // redToolStripMenuItem2
            // 
            this.redToolStripMenuItem2.Name = "redToolStripMenuItem2";
            this.redToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem2.Text = "red";
            // 
            // greenToolStripMenuItem2
            // 
            this.greenToolStripMenuItem2.Name = "greenToolStripMenuItem2";
            this.greenToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem2.Text = "green";
            // 
            // blueToolStripMenuItem2
            // 
            this.blueToolStripMenuItem2.Name = "blueToolStripMenuItem2";
            this.blueToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem2.Text = "blue";
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
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // size3pxButton
            // 
            this.size3pxButton.CheckOnClick = true;
            this.size3pxButton.Name = "size3pxButton";
            this.size3pxButton.Size = new System.Drawing.Size(180, 22);
            this.size3pxButton.Text = "3px";
            this.size3pxButton.Click += new System.EventHandler(this.size3pxButton_Click);
            // 
            // size5pxButton
            // 
            this.size5pxButton.CheckOnClick = true;
            this.size5pxButton.Name = "size5pxButton";
            this.size5pxButton.Size = new System.Drawing.Size(180, 22);
            this.size5pxButton.Text = "5px";
            this.size5pxButton.Click += new System.EventHandler(this.size5pxButton_Click);
            // 
            // size7pxButton
            // 
            this.size7pxButton.CheckOnClick = true;
            this.size7pxButton.Name = "size7pxButton";
            this.size7pxButton.Size = new System.Drawing.Size(180, 22);
            this.size7pxButton.Text = "7px";
            this.size7pxButton.Click += new System.EventHandler(this.size7pxButton_Click);
            // 
            // size9pxButton
            // 
            this.size9pxButton.CheckOnClick = true;
            this.size9pxButton.Name = "size9pxButton";
            this.size9pxButton.Size = new System.Drawing.Size(180, 22);
            this.size9pxButton.Text = "9px";
            this.size9pxButton.Click += new System.EventHandler(this.size9pxButton_Click);
            // 
            // sizeOfShape
            // 
            this.sizeOfShape.Name = "sizeOfShape";
            this.sizeOfShape.Size = new System.Drawing.Size(13, 22);
            this.sizeOfShape.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xLabel,
            this.xPositionLabel,
            this.yLabel,
            this.yPositionLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // xLabel
            // 
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 17);
            this.xLabel.Text = "X:";
            // 
            // xPositionLabel
            // 
            this.xPositionLabel.Name = "xPositionLabel";
            this.xPositionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // yLabel
            // 
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 17);
            this.yLabel.Text = "Y:";
            // 
            // yPositionLabel
            // 
            this.yPositionLabel.Name = "yPositionLabel";
            this.yPositionLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuButton;
        private System.Windows.Forms.ToolStripMenuItem openFileButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
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
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem size3pxButton;
        private System.Windows.Forms.ToolStripMenuItem size5pxButton;
        private System.Windows.Forms.ToolStripMenuItem size7pxButton;
        private System.Windows.Forms.ToolStripMenuItem size9pxButton;
        private System.Windows.Forms.ToolStripLabel sizeOfShape;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel xLabel;
        private System.Windows.Forms.ToolStripStatusLabel xPositionLabel;
        private System.Windows.Forms.ToolStripStatusLabel yLabel;
        private System.Windows.Forms.ToolStripStatusLabel yPositionLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

