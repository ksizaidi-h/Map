namespace DotSpatialMap.Views
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.HeaderControl = new DotSpatial.Controls.SpatialHeaderControl();
            this.App = new DotSpatial.Controls.AppManager();
            this.spatialDockManager1 = new DotSpatial.Controls.SpatialDockManager();
            this.legend1 = new DotSpatial.Controls.Legend();
            this.Map = new DotSpatial.Controls.Map();
            this.spatialStatusStrip1 = new DotSpatial.Controls.SpatialStatusStrip();
            this.curruntCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.spatialToolStrip1 = new DotSpatial.Controls.SpatialToolStrip();
            this.addEmptyLayerBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.drawPolygonBtn = new System.Windows.Forms.ToolStripButton();
            this.drawLineBtn = new System.Windows.Forms.ToolStripButton();
            this.drawPointBtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
            this.spatialDockManager1.Panel1.SuspendLayout();
            this.spatialDockManager1.Panel2.SuspendLayout();
            this.spatialDockManager1.SuspendLayout();
            this.spatialStatusStrip1.SuspendLayout();
            this.spatialToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderControl
            // 
            this.HeaderControl.ApplicationManager = this.App;
            this.HeaderControl.MenuStrip = this.menuStrip1;
            this.HeaderControl.ToolbarsContainer = null;
            // 
            // App
            // 
            this.App.Directories = ((System.Collections.Generic.List<string>)(resources.GetObject("App.Directories")));
            this.App.DockManager = this.spatialDockManager1;
            this.App.HeaderControl = this.HeaderControl;
            this.App.Legend = this.legend1;
            this.App.Map = this.Map;
            this.App.ProgressHandler = this.spatialStatusStrip1;
            // 
            // spatialDockManager1
            // 
            this.spatialDockManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spatialDockManager1.Location = new System.Drawing.Point(0, 51);
            this.spatialDockManager1.Name = "spatialDockManager1";
            // 
            // spatialDockManager1.Panel1
            // 
            this.spatialDockManager1.Panel1.Controls.Add(this.legend1);
            // 
            // spatialDockManager1.Panel2
            // 
            this.spatialDockManager1.Panel2.Controls.Add(this.Map);
            this.spatialDockManager1.Size = new System.Drawing.Size(800, 374);
            this.spatialDockManager1.SplitterDistance = 266;
            this.spatialDockManager1.TabControl1 = null;
            this.spatialDockManager1.TabControl2 = null;
            this.spatialDockManager1.TabIndex = 2;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 266, 374);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(266, 374);
            this.legend1.TabIndex = 0;
            this.legend1.Text = "legend1";
            this.legend1.VerticalScrollEnabled = true;
            // 
            // Map
            // 
            this.Map.AllowDrop = true;
            this.Map.BackColor = System.Drawing.Color.White;
            this.Map.CollectAfterDraw = false;
            this.Map.CollisionDetection = false;
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.ExtendBuffer = false;
            this.Map.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.Map.IsBusy = false;
            this.Map.IsZoomedToMaxExtent = false;
            this.Map.Legend = this.legend1;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.ProgressHandler = this.spatialStatusStrip1;
            this.Map.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.Map.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.Map.RedrawLayersWhileResizing = true;
            this.Map.SelectionEnabled = true;
            this.Map.Size = new System.Drawing.Size(530, 374);
            this.Map.TabIndex = 0;
            this.Map.ZoomOutFartherThanMaxExtent = false;
            this.Map.GeoMouseMove += new System.EventHandler<DotSpatial.Controls.GeoMouseArgs>(this.handle_Geo_Mosue_Move);
            this.Map.Click += new System.EventHandler(this.Map_Click);
            this.Map.DoubleClick += new System.EventHandler(this.Map_DoubleClick);
            // 
            // spatialStatusStrip1
            // 
            this.spatialStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spatialStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curruntCoordinates,
            this.toolStripProgressBar1});
            this.spatialStatusStrip1.Location = new System.Drawing.Point(0, 425);
            this.spatialStatusStrip1.Name = "spatialStatusStrip1";
            this.spatialStatusStrip1.ProgressBar = this.toolStripProgressBar1;
            this.spatialStatusStrip1.ProgressLabel = this.curruntCoordinates;
            this.spatialStatusStrip1.Size = new System.Drawing.Size(800, 25);
            this.spatialStatusStrip1.TabIndex = 0;
            this.spatialStatusStrip1.Text = "spatialStatusStrip1";
            // 
            // curruntCoordinates
            // 
            this.curruntCoordinates.Name = "curruntCoordinates";
            this.curruntCoordinates.Size = new System.Drawing.Size(151, 20);
            this.curruntCoordinates.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // spatialToolStrip1
            // 
            this.spatialToolStrip1.ApplicationManager = this.App;
            this.spatialToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spatialToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmptyLayerBtn,
            this.toolStripSeparator1,
            this.drawPolygonBtn,
            this.drawLineBtn,
            this.drawPointBtn});
            this.spatialToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.spatialToolStrip1.Map = this.Map;
            this.spatialToolStrip1.Name = "spatialToolStrip1";
            this.spatialToolStrip1.Size = new System.Drawing.Size(800, 27);
            this.spatialToolStrip1.TabIndex = 1;
            this.spatialToolStrip1.Text = "spatialToolStrip1";
            // 
            // addEmptyLayerBtn
            // 
            this.addEmptyLayerBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addEmptyLayerBtn.Image = ((System.Drawing.Image)(resources.GetObject("addEmptyLayerBtn.Image")));
            this.addEmptyLayerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEmptyLayerBtn.Name = "addEmptyLayerBtn";
            this.addEmptyLayerBtn.Size = new System.Drawing.Size(24, 24);
            this.addEmptyLayerBtn.Text = "addEmptyLayer";
            this.addEmptyLayerBtn.Click += new System.EventHandler(this.addEmptyLayerBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // drawPolygonBtn
            // 
            this.drawPolygonBtn.CheckOnClick = true;
            this.drawPolygonBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPolygonBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawPolygonBtn.Image")));
            this.drawPolygonBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPolygonBtn.Name = "drawPolygonBtn";
            this.drawPolygonBtn.Size = new System.Drawing.Size(24, 24);
            this.drawPolygonBtn.Text = "Draw Polygon";
            this.drawPolygonBtn.CheckedChanged += new System.EventHandler(this.draw_Polygon_Btn_Checked);
            // 
            // drawLineBtn
            // 
            this.drawLineBtn.CheckOnClick = true;
            this.drawLineBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawLineBtn.Image")));
            this.drawLineBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineBtn.Name = "drawLineBtn";
            this.drawLineBtn.Size = new System.Drawing.Size(24, 24);
            this.drawLineBtn.Text = "Draw Line";
            this.drawLineBtn.CheckedChanged += new System.EventHandler(this.draw_Line_Btn_Checked);
            // 
            // drawPointBtn
            // 
            this.drawPointBtn.CheckOnClick = true;
            this.drawPointBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPointBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawPointBtn.Image")));
            this.drawPointBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPointBtn.Name = "drawPointBtn";
            this.drawPointBtn.Size = new System.Drawing.Size(24, 24);
            this.drawPointBtn.Text = "Draw Point";
            this.drawPointBtn.CheckedChanged += new System.EventHandler(this.draw_Point_Btn_Checked);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spatialDockManager1);
            this.Controls.Add(this.spatialToolStrip1);
            this.Controls.Add(this.spatialStatusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.HeaderControl)).EndInit();
            this.spatialDockManager1.Panel1.ResumeLayout(false);
            this.spatialDockManager1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
            this.spatialDockManager1.ResumeLayout(false);
            this.spatialStatusStrip1.ResumeLayout(false);
            this.spatialStatusStrip1.PerformLayout();
            this.spatialToolStrip1.ResumeLayout(false);
            this.spatialToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotSpatial.Controls.SpatialHeaderControl HeaderControl;
        private DotSpatial.Controls.AppManager App;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel curruntCoordinates;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip1;
        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map Map;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton addEmptyLayerBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton drawPolygonBtn;
        private System.Windows.Forms.ToolStripButton drawLineBtn;
        private System.Windows.Forms.ToolStripButton drawPointBtn;
    }
}