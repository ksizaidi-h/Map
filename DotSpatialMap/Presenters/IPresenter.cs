using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatialMap.Models;

namespace DotSpatialMap.Presenters
{
    public interface IPresenter
    {
        void setModel(IModel model);
        void addPresenter(IPresenter presenter);

        IModel Model { set; }
    }
}
