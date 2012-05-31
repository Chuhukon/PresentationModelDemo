using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using PresentationModelDemo.PresentationModel;

namespace PresentationModelDemo
{
    /// <summary>
    /// Base view class
    /// </summary>
    /// <typeparam name="PM"></typeparam>
    public abstract class PageView<PM> : Page where PM: BasePresentationModel, new()
    {
        protected override void OnInit(EventArgs e)
        {
            this.Model = new PM();
            this.Model.Initialize(); 
        }

        private PM _model;
        public PM Model
        {
            get { return _model; }
            set
            {
                _model = value;
                _model.Changed += new EventHandler<EventArgs>(OnModelChanged);
            }
        }

        protected virtual void OnModelChanged(object sender, EventArgs e)
        {
            //implement GUI logic, for example bind/rebind controls
        }
    }
}