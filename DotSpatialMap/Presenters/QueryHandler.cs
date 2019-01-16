using DotSpatialMap.Models;
using DotSpatialMap.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotSpatialMap.Presenters
{
    class QueryHandler : Presenter<QueryForm>
    {
        private Map map;
        private TopologyRequestHandler handler;

        public override IModel Model { set => map = (Map) value; }

        public QueryHandler(QueryForm view, Map map) : base(view)
        {
            this.map = map;
            handler = map.Handler;
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);
            View.RunQuery += RunSpecifiedQuery;
            View.ShowDialog();
        }

        protected override void OnViewLoad(object sender, EventArgs e)
        {
            base.OnViewLoad(sender, e);
        }

        private void RunSpecifiedQuery(object sender, EventArgs e)
        {
            var result = handler.GetIntersect();
            map.addFeature(result);
        }
    }
}
