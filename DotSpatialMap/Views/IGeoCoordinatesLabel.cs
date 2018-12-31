using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotSpatialMap.Views
{
    interface IGeoCoordinatesLabel:IView
    {
        string GeoLocation { set; }

        event EventHandler CoordinateChanged;
    }
}
