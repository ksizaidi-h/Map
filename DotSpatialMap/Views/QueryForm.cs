using DotSpatialMap.Models;
using DotSpatialMap.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotSpatialMap.Views
{
    public partial class QueryForm : Form, ITopologyRequestView
    {

        QueryHandler Presenter;

        public QueryForm(Map map)
        {
            Presenter = new QueryHandler(this, map);

            InitializeComponent();

            InvokeInitialize(new EventArgs());
        }

        private void InvokeInitialize(EventArgs e)
        {
            EventHandler handler = Initialize;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public string RequestType => QueryTypeChooser.Text;

        public event EventHandler RunQuery;
        public event EventHandler Initialize;

        private void queryButtonOKClick(object sender, EventArgs e)
        {
            var handler = RunQuery;
            if (handler == null) return;

            handler(this, e);
        }
    }
}
