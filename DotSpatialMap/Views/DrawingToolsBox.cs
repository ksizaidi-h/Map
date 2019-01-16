using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotSpatialMap.Views
{
    interface DrawingToolsBox : IView
    {
        bool PolygonDrawingToolEnabled { get; set; }
        bool LineDrawingToolEnabled { get; set; }
        bool PointDrawingToolEnabled { get; set; }
        bool PolygonDrawingToolChecked { get; set; }
        bool PointDrawingToolChecked { get; set; }
        bool LineDrawingToolChecked { get; set; }
        string ItemClicked { get; }
        Graphics graphics { get; }
        Cursor MapCursor { set; }

        event EventHandler<DotSpatial.Symbology.LayerSelectedEventArgs> SelectedLayerChanged;

        event EventHandler Draw;
        event EventHandler AddPoint;
        event EventHandler StopDrawing;
        event EventHandler CancelDrawing;
        event EventHandler StopDrawingShapes;

        event EventHandler DrawPolygon;
        event EventHandler DrawLine;
        event EventHandler DrawPoint;
        event EventHandler RemoveLastPoint;
    }
}
