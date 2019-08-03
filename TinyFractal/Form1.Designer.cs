namespace TinyFractal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImageCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentImage = new System.Windows.Forms.TextBox();
            this.chkShowMappings = new System.Windows.Forms.CheckBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnClearNormal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedPoint = new System.Windows.Forms.TextBox();
            this.txtMappings = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRandomStep = new System.Windows.Forms.TextBox();
            this.btnClearRandom = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnStartRandom = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.lblPositionTip = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnRandomKoch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRandomRatio = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.StatusStrip.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.txtRandomRatio);
            this.splitContainer1.Panel1.Controls.Add(this.btnRandomKoch);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txtImageCount);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtCurrentImage);
            this.splitContainer1.Panel1.Controls.Add(this.chkShowMappings);
            this.splitContainer1.Panel1.Controls.Add(this.btnParse);
            this.splitContainer1.Panel1.Controls.Add(this.btnClearNormal);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtPoint);
            this.splitContainer1.Panel1.Controls.Add(this.txtLine);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtSelectedPoint);
            this.splitContainer1.Panel1.Controls.Add(this.txtMappings);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txtRandomStep);
            this.splitContainer1.Panel1.Controls.Add(this.btnClearRandom);
            this.splitContainer1.Panel1.Controls.Add(this.btnNormal);
            this.splitContainer1.Panel1.Controls.Add(this.btnStartRandom);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picCanvas);
            this.splitContainer1.Size = new System.Drawing.Size(952, 716);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Image Count";
            // 
            // txtImageCount
            // 
            this.txtImageCount.Location = new System.Drawing.Point(87, 598);
            this.txtImageCount.Name = "txtImageCount";
            this.txtImageCount.Size = new System.Drawing.Size(105, 20);
            this.txtImageCount.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Current Image";
            // 
            // txtCurrentImage
            // 
            this.txtCurrentImage.Location = new System.Drawing.Point(87, 572);
            this.txtCurrentImage.Name = "txtCurrentImage";
            this.txtCurrentImage.Size = new System.Drawing.Size(105, 20);
            this.txtCurrentImage.TabIndex = 42;
            this.txtCurrentImage.Leave += new System.EventHandler(this.txtCurrentImage_Leave);
            this.txtCurrentImage.TextChanged += new System.EventHandler(this.txtCurrentImage_TextChanged);
            // 
            // chkShowMappings
            // 
            this.chkShowMappings.AutoSize = true;
            this.chkShowMappings.Checked = true;
            this.chkShowMappings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowMappings.Location = new System.Drawing.Point(90, 316);
            this.chkShowMappings.Name = "chkShowMappings";
            this.chkShowMappings.Size = new System.Drawing.Size(102, 17);
            this.chkShowMappings.TabIndex = 41;
            this.chkShowMappings.Text = "Show Mappings";
            this.chkShowMappings.UseVisualStyleBackColor = true;
            this.chkShowMappings.CheckedChanged += new System.EventHandler(this.chkShowMappings_CheckedChanged);
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(12, 311);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(72, 25);
            this.btnParse.TabIndex = 40;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // btnClearNormal
            // 
            this.btnClearNormal.Location = new System.Drawing.Point(12, 541);
            this.btnClearNormal.Name = "btnClearNormal";
            this.btnClearNormal.Size = new System.Drawing.Size(180, 25);
            this.btnClearNormal.TabIndex = 39;
            this.btnClearNormal.Text = "Clear Normal Results";
            this.btnClearNormal.UseVisualStyleBackColor = true;
            this.btnClearNormal.Click += new System.EventHandler(this.btnClearNormal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Initial  Point";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Initial  Line";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(87, 394);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(105, 20);
            this.txtPoint.TabIndex = 37;
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(87, 482);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(105, 20);
            this.txtLine.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Fractal Mappings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selected Point";
            // 
            // txtSelectedPoint
            // 
            this.txtSelectedPoint.Location = new System.Drawing.Point(87, 342);
            this.txtSelectedPoint.Name = "txtSelectedPoint";
            this.txtSelectedPoint.Size = new System.Drawing.Size(105, 20);
            this.txtSelectedPoint.TabIndex = 32;
            // 
            // txtMappings
            // 
            this.txtMappings.Location = new System.Drawing.Point(12, 46);
            this.txtMappings.Multiline = true;
            this.txtMappings.Name = "txtMappings";
            this.txtMappings.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMappings.Size = new System.Drawing.Size(180, 259);
            this.txtMappings.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Random Step";
            // 
            // txtRandomStep
            // 
            this.txtRandomStep.Location = new System.Drawing.Point(87, 368);
            this.txtRandomStep.Name = "txtRandomStep";
            this.txtRandomStep.Size = new System.Drawing.Size(105, 20);
            this.txtRandomStep.TabIndex = 28;
            // 
            // btnClearRandom
            // 
            this.btnClearRandom.Location = new System.Drawing.Point(12, 451);
            this.btnClearRandom.Name = "btnClearRandom";
            this.btnClearRandom.Size = new System.Drawing.Size(180, 25);
            this.btnClearRandom.TabIndex = 13;
            this.btnClearRandom.Text = "Clear Random Results";
            this.btnClearRandom.UseVisualStyleBackColor = true;
            this.btnClearRandom.Click += new System.EventHandler(this.btnClearRandom_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(12, 508);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(180, 27);
            this.btnNormal.TabIndex = 10;
            this.btnNormal.Text = "Deterministic Approach";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnStartRandom
            // 
            this.btnStartRandom.Location = new System.Drawing.Point(12, 420);
            this.btnStartRandom.Name = "btnStartRandom";
            this.btnStartRandom.Size = new System.Drawing.Size(180, 25);
            this.btnStartRandom.TabIndex = 9;
            this.btnStartRandom.Text = "Random Approach";
            this.btnStartRandom.UseVisualStyleBackColor = true;
            this.btnStartRandom.Click += new System.EventHandler(this.btnStartRandom_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Black;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(743, 716);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPositionTip});
            this.StatusStrip.Location = new System.Drawing.Point(0, 694);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(952, 22);
            this.StatusStrip.TabIndex = 3;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // lblPositionTip
            // 
            this.lblPositionTip.Name = "lblPositionTip";
            this.lblPositionTip.Size = new System.Drawing.Size(0, 17);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(952, 24);
            this.mnuMain.TabIndex = 4;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(148, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveToolStripMenuItem.Text = "&Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // btnRandomKoch
            // 
            this.btnRandomKoch.Location = new System.Drawing.Point(12, 627);
            this.btnRandomKoch.Name = "btnRandomKoch";
            this.btnRandomKoch.Size = new System.Drawing.Size(179, 27);
            this.btnRandomKoch.TabIndex = 46;
            this.btnRandomKoch.Text = "Random Koch Curve";
            this.btnRandomKoch.UseVisualStyleBackColor = true;
            this.btnRandomKoch.Click += new System.EventHandler(this.btnRandomKoch_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 663);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "Random Ratio";
            // 
            // txtRandomRatio
            // 
            this.txtRandomRatio.Location = new System.Drawing.Point(86, 660);
            this.txtRandomRatio.Name = "txtRandomRatio";
            this.txtRandomRatio.Size = new System.Drawing.Size(105, 20);
            this.txtRandomRatio.TabIndex = 47;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 716);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.mnuMain);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "TinyFractal";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnStartRandom;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnClearRandom;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblPositionTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRandomStep;
        private System.Windows.Forms.TextBox txtMappings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Button btnClearNormal;
        private System.Windows.Forms.CheckBox chkShowMappings;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentImage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtImageCount;
        private System.Windows.Forms.Button btnRandomKoch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRandomRatio;
    }
}

