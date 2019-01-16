using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotSpatialMap.Views
{
    interface IMainView:IView
    {
        string SelelectedLayerName { get; set; }
        
        
        event EventHandler AddEmptyLayer;
        event EventHandler ExecuteTopologicalQuery;
     
    }
}
