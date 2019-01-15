using DotSpatial.Controls;
using DotSpatial.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotSpatialMap.Models
{
    class MNOTopology : ITopology
    {
        private IMap map;
        private double cluster_tolerance = 0.001f; // Default tolerance
        private MapPolygonLayer layer;

        public MNOTopology(IMap map, string layer)
        {
            this.map = map;
        }

        public bool Validate()
        {
            var features = layer.FeatureSet.Features;
            for(int i = 0; i < features.Count - 1; i++)
            {
                var f = features[i];
                for(int j = i + 1; j < features.Count; j++)
                {
                    var o = features[j];
                    if (f.Geometry.Intersects(o.Geometry))
                    {
                        var err = f.Geometry.Intersection(o.Geometry); // Dir biha 7aja affichi wella..
                        // TODO Don't stop at first error and check for all errors (tewwel perfomance?)
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
