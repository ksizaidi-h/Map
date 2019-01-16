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

            return result;
        }

        public IGeometry GetUnion()
        {
            var layer = map.selectedLayer;
            var features = layer.Selection.ToFeatureList();
            IGeometry result;

            result = features.First().Geometry; // TODO Type safety

            for (int i = 1; i < features.Count; i++)
            {
                result = result.Union(features[i].Geometry);
            }

            return result;
        }

        public IGeometry GetDifference()
        {
            var layer = map.selectedLayer;
            var features = layer.Selection.ToFeatureList();
            IGeometry result;

            result = features.First().Geometry; // TODO Type safety

            for (int i = 1; i < features.Count; i++)
            {
                result = result.Difference(features[i].Geometry);
            }

            return result;
        }
    }
}
