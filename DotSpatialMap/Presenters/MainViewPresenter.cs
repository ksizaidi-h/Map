using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatialMap.Models;
using DotSpatialMap.Views;

namespace DotSpatialMap.Presenters
{
    class MainViewPresenter : Presenter<IMainView>
    {

        private AddLayerDialog addLayerDialog;
        private Map map;

        public override IModel Model { set => map = (Map)value; }

        public MainViewPresenter(IMainView view, Map map) : base(view)
        {
            if (map == null)
                throw new ArgumentNullException("Map");
            this.map = map;
            
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);


            View.SelelectedLayerName = "";
            View.AddEmptyLayer += AddEmptyLayer;
            
        }

      

        private void AddEmptyLayer(object sender, EventArgs e)
        {
            addLayerDialog = new AddLayerDialog(map);
        }

        protected override void OnViewLoad(object sender, EventArgs e)
        {
            base.OnViewLoad(sender, e);
           
        }
        
    }
}
