using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatial.Controls;
using DotSpatial.Data;
using GeoAPI.Geometries;

namespace DotSpatialMap.Models
{
    public class Map:IModel
    {
        private IMap map;


      

        LayersFactory LayersFactory{ get; set; }

        public FunctionMode MapFunction { set => map.FunctionMode = value; }



        public Map(IMap map)
        {
            LayersFactory = new LayersFactory();
            this.map = map;
            
        }

        public void AddEmptyLayer(string type, string layerName)
        {
            IMapFeatureLayer layer = LayersFactory.CreateLayer(type, layerName);

           // DotSpatial.Symbology.LineSymbolizer custom = new DotSpatial.Symbology.LineSymbolizer(System.Drawing.Color.Red, 1);
            //layer.SetShapeSymbolizer(0, custom);

            map.Layers.Add(layer);
            map.MapFrame.DrawingLayers.Add(layer);
            
            
        }

        public void addFeature(IGeometry geometry)
        {
            var selectedLayer = map.Layers.SelectedLayer;

           switch (map.Layers.SelectedLayer.ToString())
            {
                case "DotSpatial.Controls.MapLineLayer":
                    ((MapLineLayer)selectedLayer).FeatureSet.AddFeature(geometry);
                    break;
                case "DotSpatial.Controls.MapPolygonLayer":
                    ((MapPolygonLayer)selectedLayer).FeatureSet.AddFeature(geometry);
                    break;

                case "DotSpatial.Controls.MapPointLayer":
                    ((MapPointLayer)selectedLayer).FeatureSet.AddFeature(geometry);
                    break;

                default:
                    throw new Exception("The selected layer does't support drawing");
                   

            }

            map.Refresh();
            
           
        }

        public Coordinate PixelToProj(System.Drawing.Point location)
        {
            return map.PixelToProj(location);
        }
    }
}
