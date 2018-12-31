using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatialMap.Models;
using DotSpatialMap.Views;

namespace DotSpatialMap.Presenters
{
    class GeoCoordinatesPresenter : Presenter<IGeoCoordinatesLabel>
    {

        private string longitude;
        private string latitude;

        public override IModel Model {  set { } }

        public GeoCoordinatesPresenter(IGeoCoordinatesLabel view) : base(view)
        {
        }

        protected override void OnViewInitialize(object sender, EventArgs e)
        {
            base.OnViewInitialize(sender, e);
            View.CoordinateChanged += UpdateCoordinates;
            
        }

        private void UpdateCoordinates(object sender, EventArgs e)
        {
            var geoArgs = (DotSpatial.Controls.GeoMouseArgs)e;

            longitude = geoArgs.GeographicLocation.X.ToString();
            latitude = geoArgs.GeographicLocation.Y.ToString();
            View.GeoLocation = $"Long : {longitude} , Lat : {latitude}";
        }

        protected override void OnViewLoad(object sender, EventArgs e)
        {
            base.OnViewLoad(sender, e);
        }
    }
}
