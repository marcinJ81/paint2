namespace paint
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
            this.gBox = new System.Windows.Forms.GroupBox();
            this.nudTRackBar = new System.Windows.Forms.NumericUpDown();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnOpen = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBrush = new System.Windows.Forms.ToolStripButton();
            this.tsbLinia = new System.Windows.Forms.ToolStripButton();
            this.tsbKolo = new System.Windows.Forms.ToolStripButton();
            this.tsbKoloCz = new System.Windows.Forms.ToolStripButton();
            this.tsbKwadrat = new System.Windows.Forms.ToolStripButton();
            this.tsbKwadratCz = new System.Windows.Forms.ToolStripButton();
            this.tsbGumka = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.canvasPicture = new System.Windows.Forms.PictureBox();
            this.gBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTRackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBox.Controls.Add(this.nudTRackBar);
            this.gBox.Controls.Add(this.trackBar1);
            this.gBox.Controls.Add(this.colorPanel);
            this.gBox.Location = new System.Drawing.Point(8, 343);
            this.gBox.Margin = new System.Windows.Forms.Padding(2);
            this.gBox.Name = "gBox";
            this.gBox.Padding = new System.Windows.Forms.Padding(2);
            this.gBox.Size = new System.Drawing.Size(567, 64);
            this.gBox.TabIndex = 1;
            this.gBox.TabStop = false;
            this.gBox.Text = "Kolor i grubość";
            // 
            // nudTRackBar
            // 
            this.nudTRackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudTRackBar.Location = new System.Drawing.Point(511, 25);
            this.nudTRackBar.Margin = new System.Windows.Forms.Padding(2);
            this.nudTRackBar.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudTRackBar.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTRackBar.Name = "nudTRackBar";
            this.nudTRackBar.Size = new System.Drawing.Size(41, 20);
            this.nudTRackBar.TabIndex = 3;
            this.nudTRackBar.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudTRackBar.ValueChanged += new System.EventHandler(this.nudTRackBar_ValueChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(51, 16);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(465, 42);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(4, 16);
            this.colorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(43, 42);
            this.colorPanel.TabIndex = 0;
            this.colorPanel.DoubleClick += new System.EventHandler(this.colorPanel_DoubleClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnOpen,
            this.btnSave,
            this.toolStripSeparator1,
            this.tsbBrush,
            this.tsbLinia,
            this.tsbKolo,
            this.tsbKoloCz,
            this.tsbKwadrat,
            this.tsbKwadratCz,
            this.tsbGumka,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(583, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "toolStripButton1";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(23, 22);
            this.btnOpen.Text = "toolStripButton2";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "toolStripButton3";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBrush
            // 
            this.tsbBrush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBrush.Image = ((System.Drawing.Image)(resources.GetObject("tsbBrush.Image")));
            this.tsbBrush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBrush.Name = "tsbBrush";
            this.tsbBrush.Size = new System.Drawing.Size(23, 22);
            this.tsbBrush.Text = "Simple Brush";
            this.tsbBrush.Click += new System.EventHandler(this.tsbBrush_Click);
            // 
            // tsbLinia
            // 
            this.tsbLinia.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLinia.Image = ((System.Drawing.Image)(resources.GetObject("tsbLinia.Image")));
            this.tsbLinia.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLinia.Name = "tsbLinia";
            this.tsbLinia.Size = new System.Drawing.Size(23, 22);
            this.tsbLinia.Text = "Line";
            this.tsbLinia.Click += new System.EventHandler(this.tsbLinia_Click);
            // 
            // tsbKolo
            // 
            this.tsbKolo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKolo.Image = ((System.Drawing.Image)(resources.GetObject("tsbKolo.Image")));
            this.tsbKolo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKolo.Name = "tsbKolo";
            this.tsbKolo.Size = new System.Drawing.Size(23, 22);
            this.tsbKolo.Text = "Empty Ellipse";
            this.tsbKolo.ToolTipText = "Empty Rectangle";
            this.tsbKolo.Click += new System.EventHandler(this.tsbKolo_Click);
            // 
            // tsbKoloCz
            // 
            this.tsbKoloCz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKoloCz.Image = ((System.Drawing.Image)(resources.GetObject("tsbKoloCz.Image")));
            this.tsbKoloCz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKoloCz.Name = "tsbKoloCz";
            this.tsbKoloCz.Size = new System.Drawing.Size(23, 22);
            this.tsbKoloCz.Text = "Full Ellipse";
            this.tsbKoloCz.Click += new System.EventHandler(this.tsbKoloCz_Click);
            // 
            // tsbKwadrat
            // 
            this.tsbKwadrat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKwadrat.Image = ((System.Drawing.Image)(resources.GetObject("tsbKwadrat.Image")));
            this.tsbKwadrat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKwadrat.Name = "tsbKwadrat";
            this.tsbKwadrat.Size = new System.Drawing.Size(23, 22);
            this.tsbKwadrat.Text = "Empty Rectangle";
            this.tsbKwadrat.Click += new System.EventHandler(this.tsbKwadrat_Click);
            // 
            // tsbKwadratCz
            // 
            this.tsbKwadratCz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKwadratCz.Image = ((System.Drawing.Image)(resources.GetObject("tsbKwadratCz.Image")));
            this.tsbKwadratCz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKwadratCz.Name = "tsbKwadratCz";
            this.tsbKwadratCz.Size = new System.Drawing.Size(23, 22);
            this.tsbKwadratCz.Text = "Full Rectangle";
            this.tsbKwadratCz.Click += new System.EventHandler(this.tsbKwadratCz_Click);
            // 
            // tsbGumka
            // 
            this.tsbGumka.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGumka.Image = ((System.Drawing.Image)(resources.GetObject("tsbGumka.Image")));
            this.tsbGumka.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGumka.Name = "tsbGumka";
            this.tsbGumka.Size = new System.Drawing.Size(23, 22);
            this.tsbGumka.Text = "Eraser";
            this.tsbGumka.Click += new System.EventHandler(this.tsbGumka_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // canvasPicture
            // 
            this.canvasPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvasPicture.BackColor = System.Drawing.Color.White;
            this.canvasPicture.Location = new System.Drawing.Point(8, 24);
            this.canvasPicture.Margin = new System.Windows.Forms.Padding(2);
            this.canvasPicture.Name = "canvasPicture";
            this.canvasPicture.Size = new System.Drawing.Size(564, 315);
            this.canvasPicture.TabIndex = 4;
            this.canvasPicture.TabStop = false;
            this.canvasPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPicture_MouseDown);
            this.canvasPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPicture_MouseMove);
            this.canvasPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPicture_MouseUp);
            this.canvasPicture.Resize += new System.EventHandler(this.canvasPicture_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 415);
            this.Controls.Add(this.canvasPicture);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTRackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.canvasPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown nudTRackBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnOpen;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.PictureBox canvasPicture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbBrush;
        private System.Windows.Forms.ToolStripButton tsbLinia;
        private System.Windows.Forms.ToolStripButton tsbKolo;
        private System.Windows.Forms.ToolStripButton tsbKoloCz;
        private System.Windows.Forms.ToolStripButton tsbKwadrat;
        private System.Windows.Forms.ToolStripButton tsbKwadratCz;
        private System.Windows.Forms.ToolStripButton tsbGumka;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

