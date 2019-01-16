using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Symbology;
using DotSpatialMap.Models;
using DotSpatialMap.Views;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using DotSpatial.Compatibility;

namespace DotSpatialMap.Presenters
{
    class DrawingToolsBoxPresenter : Presenter<DrawingToolsBox>
    {

        private Map Map;
        

        public DrawingToolsBoxPresenter(DrawingToolsBox view) : base(view)
        {
        }

        public override IModel Model {  set => Map = (Map)value; }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);

            View.SelectedLayerChanged += EnableDrawingTool;

            View.DrawLine += DrawLine;
            View.DrawPolygon += DrawPolygon;
            View.DrawPoint += DrawPoint;
           


        }



        #region Drawing

        private List<System.Drawing.Point> points = new List<System.Drawing.Point>();
        private List<Coordinate> coordinates = new List<Coordinate>();


        #region DrawingPoint
        private void DrawPoint(object sender, EventArgs e)
        {
            if (View.PointDrawingToolChecked)
            {
                View.AddPoint += DrawingPoint;
                Map.MapFunction = DotSpatial.Controls.FunctionMode.None;
                View.MapCursor = Cursors.Cross;
                View.RemoveLastPoint += RemoveDrawnPoint;
                View.CancelDrawing += StopDrawingPoints;
            }
            else
            {
                View.AddPoint -= DrawingPoint;
                View.RemoveLastPoint -= RemoveDrawnPoint;
                
            }
        }

        private void StopDrawingPoints(object sender, EventArgs e)
        {
            if(View.ItemClicked != "POINT")
            {
                View.PointDrawingToolChecked = false;
            }
        }

        private void RemoveDrawnPoint(object sender, EventArgs e)
        {
            //TODO
        }

        private void DrawingPoint(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;

            Map.addFeature(new Point(Map.PixelToProj(args.Location)));
        }
        #endregion DrawingPoint

        #region DrawingPolygon
        
        private void DrawPolygon(object sender, EventArgs e)
        {
            if (View.PolygonDrawingToolChecked)
            {
                View.AddPoint += AddPointToPolygon;
                Map.MapFunction = DotSpatial.Controls.FunctionMode.None;
                View.MapCursor = Cursors.Cross;
                View.RemoveLastPoint += RemoveLasPointFromPolygon;
                View.StopDrawing += StopDrawingPolygon;
                View.CancelDrawing += CancelDrawingPolygon;

            }
            else
            {
                View.AddPoint -= AddPointToPolygon;
                View.StopDrawing -= StopDrawingPolygon;
                View.CancelDrawing -= CancelDrawingPolygon;
                points.Clear();
                coordinates.Clear();
            }

        }

        private void CancelDrawingPolygon(object sender, EventArgs e)
        {
            if(View.ItemClicked != "POLYGON")
            {
                points.Clear();
                coordinates.Clear();
                View.PolygonDrawingToolChecked = false;
            }
            
        }

        private void RemoveLasPointFromPolygon(object sender, EventArgs e)
        {
            if(points.Count > 0)
            {
                points.RemoveAt(points.Count - 1);
                coordinates.RemoveAt(coordinates.Count - 1);
                if(points.Count == 0)
                {
                    View.Draw -= DrawingPolygon;
                }
            }
        }

        private void StopDrawingPolygon(object sender, EventArgs e)
        {
            View.Draw -= DrawingPolygon;
            coordinates.Add(coordinates[0]);
            try
            {
                Polygon polygon = new Polygon(new LinearRing(coordinates.ToArray()));
                Map.addFeature(polygon);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            

            points.Clear();
            coordinates.Clear();

        }

        private void AddPointToPolygon(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;

            if (points.Count == 0)
            {
                View.Draw += DrawingPolygon;
            }
            points.Add(args.Location);
            coordinates.Add(Map.PixelToProj(args.Location));
            
        }
        private System.Drawing.Brush brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(50, 213, 224, 242));

        private System.Drawing.Pen pen = new System.Drawing.Pen(System.Drawing.Brushes.Black);
        private void DrawingPolygon(object sender, EventArgs e)
        {
            DotSpatial.Controls.GeoMouseArgs args = (DotSpatial.Controls.GeoMouseArgs)e;

            if (points.Count > 1)
            {
                points.RemoveAt(points.Count - 1);
            }

            points.Add(args.Location);
            
            View.graphics.DrawPolygon(System.Drawing.Pens.Black, points.ToArray());
            View.graphics.FillPolygon(brush, points.ToArray());
            View.graphics.Dispose();
        }
        #endregion DrawingPolygon


        #region DrawingLine

        private List<System.Drawing.PointF> linePoints;
        private void DrawLine(object sender, EventArgs e)
        {
            if (View.LineDrawingToolChecked)
            {
                linePoints = new List<System.Drawing.PointF>();
                Map.MapFunction = DotSpatial.Controls.FunctionMode.None;
                View.MapCursor = Cursors.Cross;
                View.AddPoint += AddPointToLine;
                View.RemoveLastPoint += RemoveLastPointFromLine;
                View.StopDrawing += StopDrawingLine;
                View.CancelDrawing += CancelDrawingLine;

            }
            else
            {
                View.AddPoint -= AddPointToLine;
                View.RemoveLastPoint -= RemoveLastPointFromLine;
                View.StopDrawing -= StopDrawingLine;
                View.CancelDrawing += CancelDrawingLine;
                linePoints.Clear();
                coordinates.Clear();
            }
        }

        private void CancelDrawingLine(object sender, EventArgs e)
        {
            if(View.ItemClicked != "LINE")
            {
                linePoints.Clear();
                coordinates.Clear();
                View.LineDrawingToolChecked = false;
            }
        }

        private void RemoveLastPointFromLine(object sender, EventArgs e)
        {
            if(linePoints.Count > 0)
            {
                linePoints.RemoveAt(linePoints.Count - 1);
                coordinates.RemoveAt(coordinates.Count - 1);
                if(linePoints.Count == 0)
                {
                    View.Draw -= DrawingLine;
                }
            }
        }

        private void AddPointToLine(object sender, EventArgs e)
        {
            MouseEventArgs args = (MouseEventArgs)e;

            if (linePoints.Count == 0)
            {
                View.Draw += DrawingLine;
                
            }
            linePoints.Add(args.Location);
            coordinates.Add(Map.PixelToProj(args.Location));
        }

        private void DrawingLine(object sender, EventArgs e)
        {
            DotSpatial.Controls.GeoMouseArgs args = (DotSpatial.Controls.GeoMouseArgs)e;

            if (linePoints.Count > 1)
            {
                linePoints.RemoveAt(linePoints.Count - 1);
            }

            linePoints.Add(args.Location);
            View.graphics.DrawLines(System.Drawing.Pens.Black,linePoints.ToArray());
            
        }

        private void StopDrawingLine(object sender, EventArgs e)
        {
            View.Draw -= DrawingLine;
            try
            {
                LineString line = new LineString(coordinates.ToArray());
                Map.addFeature(line);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
            linePoints.Clear();
            coordinates.Clear();
        }

        #endregion DrawingLine


        private void EnableDrawingTool(object sender, LayerSelectedEventArgs e)
        {

            View.LineDrawingToolEnabled = false;
            View.PointDrawingToolEnabled = false;
            View.PolygonDrawingToolEnabled = false;

            View.LineDrawingToolChecked = false;
            View.PointDrawingToolChecked = false;
            View.PolygonDrawingToolChecked = false;
            switch (e.Layer.ToString())
            {
                case "DotSpatial.Controls.MapLineLayer":
                    View.LineDrawingToolEnabled = true;
                    break;
                case "DotSpatial.Controls.MapPolygonLayer":
                    View.PolygonDrawingToolEnabled = true;
                    break;

                case "DotSpatial.Controls.MapPointLayer":
                    View.PointDrawingToolEnabled = true;
                    break;              
            }
        }
        #endregion



        protected override void OnViewLoad(object sender, EventArgs e)
        {
            base.OnViewLoad(sender, e);
            View.LineDrawingToolEnabled = false;
            View.PointDrawingToolEnabled = false;
            View.PolygonDrawingToolEnabled = false;

        }
    }
}
