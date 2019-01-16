using DotSpatial.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotSpatialMap.Models
{
    class MNHGTopology : ITopology
    {
        private IMap map;
        private MapPolygonLayer layer;
        

        public MNHGTopology(IMap map, string layer)
        {
            this.map = map;
            // TODO Set layer and check if it's a polygon layer
        }

        public bool Validate()
        {
            var features = layer.FeatureSet.Features;
            for (int i = 0; i < features.Count - 1; i++)
            {
                var f = features[i];
                for (int j = i + 1; j < features.Count; j++)
                {
                    var o = features[j];
                    if (!f.Geometry.Touches(o.Geometry)) return false; // TODO Remove code duplication
                }
            }
            return true;
        }
    }
}
