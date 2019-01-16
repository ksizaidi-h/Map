using DotSpatialMap.Models;
using DotSpatialMap.Views;
using GeoAPI.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotSpatialMap.Presenters
{
    class QueryHandler : Presenter<QueryForm>
    {
        private Map map;
        private TopologyRequestHandler handler;

        public override IModel Model { set => map = (Map) value; }

        public QueryHandler(QueryForm view, Map map) : base(view)
        {
            this.map = map;
            handler = map.Handler;
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);
            View.RunQuery += RunSpecifiedQuery;
            View.ShowDialog();
        }

        protected override void OnViewLoad(object sender, EventArgs e)
        {
            base.OnViewLoad(sender, e);
        }

        private void RunSpecifiedQuery(object sender, EventArgs e)
        {
            IGeometry result;

            switch(View.RequestType)
            {
                case "Union":
                    result = handler.GetUnion();
                    break;
                case "Intersection":
                    result = handler.GetIntersect();
                    break;
                case "Couverture":
                    result = null;
                    break;
                case "Difference":
                    result = handler.GetDifference();
                    break;
                default:
                    result = null;
                    break;
            }

            if(result == null)
            {
                MessageBox.Show("Operation non valide.");
                return;
            }

            var type = result.GeometryType;
            var addedLayer = map.AddEmptyLayer(type, "Query Result");

            switch (addedLayer.ToString())
            {
                case "DotSpatial.Controls.MapLineLayer":
                    ((DotSpatial.Controls.MapLineLayer)addedLayer).FeatureSet.AddFeature(result);
                    break;
                case "DotSpatial.Controls.MapPolygonLayer":
                    ((DotSpatial.Controls.MapPolygonLayer)addedLayer).FeatureSet.AddFeature(result);
                    break;

                case "DotSpatial.Controls.MapPointLayer":
                    ((DotSpatial.Controls.MapPointLayer)addedLayer).FeatureSet.AddFeature(result);
                    break;

                default:
                    throw new Exception("Geometry is empty!");
            }

            map.Refresh();
        }
    }
}
