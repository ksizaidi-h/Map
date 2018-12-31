using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotSpatialMap.Models;
using DotSpatialMap.Views;

namespace DotSpatialMap.Presenters
{
    //Base Presenter Class  
    public abstract class Presenter<TView> : IPresenter where TView : class, IView
    {
        public TView View { get; private set; }
        private IModel model;

        public virtual IModel Model {  set => model = value; }

        private List<IPresenter> presenters = new List<IPresenter>();


        public Presenter(TView view)
        {
            if (view == null)
                throw new ArgumentNullException("view");

            View = view;
            View.Initialize += OnViewInitialize;
            View.Load += OnViewLoad;
        }


        protected virtual void OnViewInitialize(object sender, EventArgs e) { }

        protected virtual void OnViewLoad(object sender, EventArgs e) { }

        public void setModel(IModel model)
        {
            foreach(IPresenter presenter in presenters)
            {
                presenter.Model = model;
            }
        }

        public void addPresenter(IPresenter presenter)
        {
            presenters.Add(presenter);
        }
    }
}
