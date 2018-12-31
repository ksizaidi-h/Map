using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotSpatialMap.Views
{
    interface INewLayerDialog:IView
    {
        string LayerName { get; }
        string LayerType { get; }

        event EventHandler Confirm;
        event EventHandler Cancel;

    }
}
