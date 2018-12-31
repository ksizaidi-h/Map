using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatialMap.Models;
using DotSpatialMap.Presenters;

namespace DotSpatialMap.Views
{
    public partial class AddLayerDialog : Form,INewLayerDialog
    {
        AddLayerDialogPresenter Presenter;

        public AddLayerDialog(Map mapModel)
        {
            Presenter = new AddLayerDialogPresenter(this,mapModel);

            InitializeComponent();

            InvokeInitialize(new EventArgs());
        }

        public string LayerName {
            get
            {
                return LayerNameTextBox.Text;
            }
        }

        public string LayerType {
            get {

                return LayerClassChooser.Text;

            }
        }

        public event EventHandler Confirm;

        private void ConfirmLayerBtn_Click(object sender, EventArgs e)
        {
            
            var handler = Confirm;
            if (handler != null) {
                handler(this, e);
            }
        }

        public event EventHandler Cancel;

        private void CancelAddLayerBtn_Click(object sender, EventArgs e)
        {
            var handler = Cancel;
            if(handler != null)
            {
                handler(this, e);
            }
        }


        public event EventHandler Initialize;

        public void InvokeInitialize(EventArgs e)
        {
            
            EventHandler handler = Initialize;
            if (handler != null)
            {
                handler(this, e);
            }
        }





    }
}
