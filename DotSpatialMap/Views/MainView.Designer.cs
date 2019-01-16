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
            this.spatialToolStrip2 = new DotSpatial.Controls.SpatialToolStrip();
            this.addEmptyLayerBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.drawPolygonBtn = new System.Windows.Forms.ToolStripButton();
            this.drawLineBtn = new System.Windows.Forms.ToolStripButton();
            this.drawPointBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.pnlOperations = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPointShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePointShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPolylineShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPolygonShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOperationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.measurementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttributeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAColumnInTheAttributeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTheColumInShapeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAColumnInTheAttributeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAttributeTableInShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportAttributeTableToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).BeginInit();
            this.spatialDockManager1.Panel1.SuspendLayout();
            this.spatialDockManager1.Panel2.SuspendLayout();
            this.spatialDockManager1.SuspendLayout();
            this.spatialStatusStrip1.SuspendLayout();
            this.spatialToolStrip2.SuspendLayout();
            this.pnlOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderControl
            // 
            this.HeaderControl.ApplicationManager = this.App;
            this.HeaderControl.MenuStrip = null;
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
            this.App.MapChanged += new System.EventHandler<DotSpatial.Controls.MapChangedEventArgs>(this.App_MapChanged);
            // 
            // spatialDockManager1
            // 
            this.spatialDockManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spatialDockManager1.Location = new System.Drawing.Point(0, 55);
            this.spatialDockManager1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.spatialDockManager1.Name = "spatialDockManager1";
            // 
            // spatialDockManager1.Panel1
            // 
            this.spatialDockManager1.Panel1.Controls.Add(this.legend1);
            // 
            // spatialDockManager1.Panel2
            // 
            this.spatialDockManager1.Panel2.Controls.Add(this.Map);
            this.spatialDockManager1.Size = new System.Drawing.Size(800, 369);
            this.spatialDockManager1.SplitterDistance = 265;
            this.spatialDockManager1.TabControl1 = null;
            this.spatialDockManager1.TabControl2 = null;
            this.spatialDockManager1.TabIndex = 2;
            // 
            // legend1
            // 
            this.legend1.BackColor = System.Drawing.Color.White;
            this.legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 265, 369);
            this.legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 187, 428);
            this.legend1.HorizontalScrollEnabled = true;
            this.legend1.Indentation = 30;
            this.legend1.IsInitialized = false;
            this.legend1.Location = new System.Drawing.Point(0, 0);
            this.legend1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.legend1.Name = "legend1";
            this.legend1.ProgressHandler = null;
            this.legend1.ResetOnResize = false;
            this.legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.legend1.Size = new System.Drawing.Size(265, 369);
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
            this.Map.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Map.Name = "Map";
            this.Map.ProgressHandler = this.spatialStatusStrip1;
            this.Map.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Never;
            this.Map.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Never;
            this.Map.RedrawLayersWhileResizing = true;
            this.Map.SelectionEnabled = true;
            this.Map.Size = new System.Drawing.Size(531, 369);
            this.Map.TabIndex = 0;
            this.Map.ZoomOutFartherThanMaxExtent = false;
            this.Map.SelectionChanged += new System.EventHandler(this.Map_SelectionChanged);
            this.Map.GeoMouseMove += new System.EventHandler<DotSpatial.Controls.GeoMouseArgs>(this.handle_Geo_Mosue_Move);
            this.Map.Click += new System.EventHandler(this.Map_Click);
            this.Map.Paint += new System.Windows.Forms.PaintEventHandler(this.Map_Paint);
            this.Map.DoubleClick += new System.EventHandler(this.Map_DoubleClick);
            // 
            // spatialStatusStrip1
            // 
            this.spatialStatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spatialStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curruntCoordinates,
            this.toolStripProgressBar1});
            this.spatialStatusStrip1.Location = new System.Drawing.Point(0, 424);
            this.spatialStatusStrip1.Name = "spatialStatusStrip1";
            this.spatialStatusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.spatialStatusStrip1.ProgressBar = this.toolStripProgressBar1;
            this.spatialStatusStrip1.ProgressLabel = this.curruntCoordinates;
            this.spatialStatusStrip1.Size = new System.Drawing.Size(800, 26);
            this.spatialStatusStrip1.TabIndex = 0;
            this.spatialStatusStrip1.Text = "spatialStatusStrip1";
            // 
            // curruntCoordinates
            // 
            this.curruntCoordinates.Name = "curruntCoordinates";
            this.curruntCoordinates.Size = new System.Drawing.Size(151, 21);
            this.curruntCoordinates.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 20);
            // 
            // spatialToolStrip2
            // 
            this.spatialToolStrip2.ApplicationManager = this.App;
            this.spatialToolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.spatialToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmptyLayerBtn,
            this.toolStripSeparator2,
            this.drawPolygonBtn,
            this.drawLineBtn,
            this.drawPointBtn,
            this.toolStripButton1,
            this.toolStripButton2});
            this.spatialToolStrip2.Location = new System.Drawing.Point(0, 24);
            this.spatialToolStrip2.Map = this.Map;
            this.spatialToolStrip2.Name = "spatialToolStrip2";
            this.spatialToolStrip2.Size = new System.Drawing.Size(800, 27);
            this.spatialToolStrip2.TabIndex = 6;
            this.spatialToolStrip2.Text = "spatialToolStrip2";
            this.spatialToolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.spatialToolStrip2_ItemClicked);
            // 
            // addEmptyLayerBtn
            // 
            this.addEmptyLayerBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addEmptyLayerBtn.Image = ((System.Drawing.Image)(resources.GetObject("addEmptyLayerBtn.Image")));
            this.addEmptyLayerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addEmptyLayerBtn.Name = "addEmptyLayerBtn";
            this.addEmptyLayerBtn.Size = new System.Drawing.Size(24, 24);
            this.addEmptyLayerBtn.Text = "toolStripButton1";
            this.addEmptyLayerBtn.Click += new System.EventHandler(this.addEmptyLayerBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // drawPolygonBtn
            // 
            this.drawPolygonBtn.CheckOnClick = true;
            this.drawPolygonBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPolygonBtn.Image = ((System.Drawing.Image)(resources.GetObject("drawPolygonBtn.Image")));
            this.drawPolygonBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPolygonBtn.Name = "drawPolygonBtn";
            this.drawPolygonBtn.Size = new System.Drawing.Size(24, 24);
            this.drawPolygonBtn.Text = "toolStripButton2";
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
            this.drawLineBtn.Text = "toolStripButton3";
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
            this.drawPointBtn.Text = "toolStripButton4";
            this.drawPointBtn.CheckedChanged += new System.EventHandler(this.draw_Point_Btn_Checked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // pnlOperations
            // 
            this.pnlOperations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.pnlOperations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapeToolStripMenuItem,
            this.mapOperationToolStripMenuItem,
            this.attributeToolStripMenuItem});
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.pnlOperations.Size = new System.Drawing.Size(800, 28);
            this.pnlOperations.TabIndex = 7;
            this.pnlOperations.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(115, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // shapeToolStripMenuItem
            // 
            this.shapeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.polylineToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.shapeToolStripMenuItem.Name = "shapeToolStripMenuItem";
            this.shapeToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.shapeToolStripMenuItem.Text = "Shape File Operation";
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPointShapefileToolStripMenuItem,
            this.savePointShapefileToolStripMenuItem});
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.pointToolStripMenuItem.Text = "Point";
            // 
            // createPointShapefileToolStripMenuItem
            // 
            this.createPointShapefileToolStripMenuItem.Name = "createPointShapefileToolStripMenuItem";
            this.createPointShapefileToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.createPointShapefileToolStripMenuItem.Text = "Create Point Shapefile";
            // 
            // savePointShapefileToolStripMenuItem
            // 
            this.savePointShapefileToolStripMenuItem.Name = "savePointShapefileToolStripMenuItem";
            this.savePointShapefileToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.savePointShapefileToolStripMenuItem.Text = "Save Point Shapefile";
            // 
            // polylineToolStripMenuItem
            // 
            this.polylineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPolylineShapefileToolStripMenuItem,
            this.savePolylineToolStripMenuItem});
            this.polylineToolStripMenuItem.Name = "polylineToolStripMenuItem";
            this.polylineToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.polylineToolStripMenuItem.Text = "Polyline";
            // 
            // createPolylineShapefileToolStripMenuItem
            // 
            this.createPolylineShapefileToolStripMenuItem.Name = "createPolylineShapefileToolStripMenuItem";
            this.createPolylineShapefileToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.createPolylineShapefileToolStripMenuItem.Text = "Create Polyline Shapefile";
            // 
            // savePolylineToolStripMenuItem
            // 
            this.savePolylineToolStripMenuItem.Name = "savePolylineToolStripMenuItem";
            this.savePolylineToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.savePolylineToolStripMenuItem.Text = "Save Polyline";
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPolygonShapefileToolStripMenuItem,
            this.savePolygonShapefileToolStripMenuItem});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.polygonToolStripMenuItem.Text = "Polygon";
            // 
            // createPolygonShapefileToolStripMenuItem
            // 
            this.createPolygonShapefileToolStripMenuItem.Name = "createPolygonShapefileToolStripMenuItem";
            this.createPolygonShapefileToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.createPolygonShapefileToolStripMenuItem.Text = "Create Polygon Shapefile";
            // 
            // savePolygonShapefileToolStripMenuItem
            // 
            this.savePolygonShapefileToolStripMenuItem.Name = "savePolygonShapefileToolStripMenuItem";
            this.savePolygonShapefileToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.savePolygonShapefileToolStripMenuItem.Text = "Save Polygon Shapefile";
            // 
            // mapOperationToolStripMenuItem
            // 
            this.mapOperationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultInformationToolStripMenuItem,
            this.informationToolStripMenuItem,
            this.measurementToolStripMenuItem,
            this.toolStripSeparator1,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomToExtentToolStripMenuItem,
            this.panToolStripMenuItem,
            this.printMapToolStripMenuItem});
            this.mapOperationToolStripMenuItem.Name = "mapOperationToolStripMenuItem";
            this.mapOperationToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.mapOperationToolStripMenuItem.Text = "Map Operation";
            // 
            // defaultInformationToolStripMenuItem
            // 
            this.defaultInformationToolStripMenuItem.Name = "defaultInformationToolStripMenuItem";
            this.defaultInformationToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.defaultInformationToolStripMenuItem.Text = "Default";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // measurementToolStripMenuItem
            // 
            this.measurementToolStripMenuItem.Name = "measurementToolStripMenuItem";
            this.measurementToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.measurementToolStripMenuItem.Text = "Measurement";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            // 
            // zoomToExtentToolStripMenuItem
            // 
            this.zoomToExtentToolStripMenuItem.Name = "zoomToExtentToolStripMenuItem";
            this.zoomToExtentToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.zoomToExtentToolStripMenuItem.Text = "Zoom to Extent";
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.panToolStripMenuItem.Text = "Pan";
            // 
            // printMapToolStripMenuItem
            // 
            this.printMapToolStripMenuItem.Name = "printMapToolStripMenuItem";
            this.printMapToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.printMapToolStripMenuItem.Text = "Print Map";
            // 
            // attributeToolStripMenuItem
            // 
            this.attributeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAttributeTableToolStripMenuItem,
            this.addAColumnInTheAttributeTableToolStripMenuItem,
            this.saveTheColumInShapeFileToolStripMenuItem,
            this.deleteAColumnInTheAttributeTableToolStripMenuItem,
            this.updateAttributeTableInShapefileToolStripMenuItem,
            this.toolStripSeparator4,
            this.exportAttributeTableToExcelToolStripMenuItem});
            this.attributeToolStripMenuItem.Name = "attributeToolStripMenuItem";
            this.attributeToolStripMenuItem.Size = new System.Drawing.Size(153, 20);
            this.attributeToolStripMenuItem.Text = "Attribute Table Operation";
            // 
            // viewAttributeTableToolStripMenuItem
            // 
            this.viewAttributeTableToolStripMenuItem.Name = "viewAttributeTableToolStripMenuItem";
            this.viewAttributeTableToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.viewAttributeTableToolStripMenuItem.Text = "View Attribute table";
            // 
            // addAColumnInTheAttributeTableToolStripMenuItem
            // 
            this.addAColumnInTheAttributeTableToolStripMenuItem.Name = "addAColumnInTheAttributeTableToolStripMenuItem";
            this.addAColumnInTheAttributeTableToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.addAColumnInTheAttributeTableToolStripMenuItem.Text = "Add a column in the attribute table";
            // 
            // saveTheColumInShapeFileToolStripMenuItem
            // 
            this.saveTheColumInShapeFileToolStripMenuItem.Name = "saveTheColumInShapeFileToolStripMenuItem";
            this.saveTheColumInShapeFileToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.saveTheColumInShapeFileToolStripMenuItem.Text = "Save the colum in ShapeFile";
            // 
            // deleteAColumnInTheAttributeTableToolStripMenuItem
            // 
            this.deleteAColumnInTheAttributeTableToolStripMenuItem.Name = "deleteAColumnInTheAttributeTableToolStripMenuItem";
            this.deleteAColumnInTheAttributeTableToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.deleteAColumnInTheAttributeTableToolStripMenuItem.Text = "Delete a column in the attribute table";
            // 
            // updateAttributeTableInShapefileToolStripMenuItem
            // 
            this.updateAttributeTableInShapefileToolStripMenuItem.Name = "updateAttributeTableInShapefileToolStripMenuItem";
            this.updateAttributeTableInShapefileToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.updateAttributeTableInShapefileToolStripMenuItem.Text = "Update attribute table in Shapefile";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(330, 6);
            // 
            // exportAttributeTableToExcelToolStripMenuItem
            // 
            this.exportAttributeTableToExcelToolStripMenuItem.Name = "exportAttributeTableToExcelToolStripMenuItem";
            this.exportAttributeTableToExcelToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.exportAttributeTableToExcelToolStripMenuItem.Text = "Export Attribute table to Excel";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // MainView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.spatialDockManager1);
            this.Controls.Add(this.spatialStatusStrip1);
            this.Controls.Add(this.spatialToolStrip2);
            this.Controls.Add(this.pnlOperations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainView";
            this.Text = "AHLA-MAP";
            ((System.ComponentModel.ISupportInitialize)(this.HeaderControl)).EndInit();
            this.spatialDockManager1.Panel1.ResumeLayout(false);
            this.spatialDockManager1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialDockManager1)).EndInit();
            this.spatialDockManager1.ResumeLayout(false);
            this.spatialStatusStrip1.ResumeLayout(false);
            this.spatialStatusStrip1.PerformLayout();
            this.spatialToolStrip2.ResumeLayout(false);
            this.spatialToolStrip2.PerformLayout();
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotSpatial.Controls.SpatialHeaderControl HeaderControl;
        private DotSpatial.Controls.AppManager App;
        private DotSpatial.Controls.SpatialStatusStrip spatialStatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel curruntCoordinates;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private DotSpatial.Controls.SpatialDockManager spatialDockManager1;
        private DotSpatial.Controls.Legend legend1;
        private DotSpatial.Controls.Map Map;
        private DotSpatial.Controls.SpatialToolStrip spatialToolStrip2;
        private System.Windows.Forms.ToolStripButton addEmptyLayerBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton drawPolygonBtn;
        private System.Windows.Forms.ToolStripButton drawLineBtn;
        private System.Windows.Forms.ToolStripButton drawPointBtn;
        private System.Windows.Forms.MenuStrip pnlOperations;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPointShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePointShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPolylineShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolylineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPolygonShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolygonShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOperationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measurementToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToExtentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttributeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAColumnInTheAttributeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTheColumInShapeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAColumnInTheAttributeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAttributeTableInShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exportAttributeTableToExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}