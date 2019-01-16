using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatialMap.Views;
using DotSpatialMap.Models;
using System.Windows.Forms;

namespace DotSpatialMap.Presenters
{
    class AddLayerDialogPresenter : Presenter<AddLayerDialog>
    {

        private Map map;

        public override IModel Model { set => map = (Map)value; }

        public AddLayerDialogPresenter(AddLayerDialog view, Map map) : base(view)
        {

            this.map = map;
            
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);

            View.Confirm += Confirm;
            View.Cancel += Cancel;
            View.ShowDialog();
        }

        private void Cancel(object sender, EventArgs e)
        {
            View.Close();
        }

        private void Confirm(object sender, EventArgs e)
        {
            map.AddEmptyLayer(View.LayerType, View.LayerName);
            View.Close();   
        }

        protected override void OnViewLoad(object sender, EventArgs e)
        {
            base.OnViewLoad(sender, e);
            
        }
    }
}
