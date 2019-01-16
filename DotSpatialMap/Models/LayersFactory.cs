using System;
using System.Collections.ObjectModel;
using DotSpatial.Controls;

namespace DotSpatialMap.Models
{
    internal class LayersFactory
    {
        internal IMapFeatureLayer CreateLayer(string type, string layerName)
        {
            IMapFeatureLayer layer = null;
            switch (type)
            {
                case "Polygon":
                    layer = new MapPolygonLayer();
                    break;
                case "Line":
                    layer = new MapLineLayer();
                    break;
                case "Point":
                    layer = new MapPointLayer();
                    break;
                case "MultiPolygon":
                    layer = new MapPolygonLayer();
                    break;
                default:
                    throw new Exception("Wrong Layer Class:" + type);
                       
            }
            layer.DataSet.Name = layerName;
            layer.LegendText = layerName;
            return layer;
        }
    }
}