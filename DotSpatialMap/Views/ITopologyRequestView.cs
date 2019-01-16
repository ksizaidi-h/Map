using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotSpatialMap.Views
{
    interface ITopologyRequestView:IView
    {
        string RequestType { get; }

        event EventHandler RunQuery;
        event EventHandler Cancel;
    }
}
