using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Symbology;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotSpatialMap.Models
{
    public class TopologyRequestHandler:IModel
    {
        private Map map;

        public TopologyRequestHandler(Map map)
        {
            this.map = map;
        }

        public IGeometry GetIntersect()
        {
            var layer = map.selectedLayer;
            var features = layer.Selection.ToFeatureList();
            IGeometry result;

            result = features.First().Geometry; // TODO Type safety

            for(int i = 1; i < features.Count; i++)
            {
                result = result.Intersection(features[i].Geometry);
            }

            var type = result.GeometryType;
            var addedLayer = map.AddEmptyLayer(type, "Query Result");

            switch (addedLayer.ToString())
            {
                case "DotSpatial.Controls.MapLineLayer":
                    ((MapLineLayer)addedLayer).FeatureSet.AddFeature(result);
                    break;
                case "DotSpatial.Controls.MapPolygonLayer":
                    ((MapPolygonLayer)addedLayer).FeatureSet.AddFeature(result);
                    break;

                case "DotSpatial.Controls.MapPointLayer":
                    ((MapPointLayer)addedLayer).FeatureSet.AddFeature(result);
                    break;

                default:
                    throw new Exception("Geometry is empty!");


            }

            map.Refresh();

            return result;
        }
    }
}
