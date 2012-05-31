using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace PresentationModelDemo.PresentationModel
{
    public abstract class BasePresentationModel
    {
        public event EventHandler<EventArgs> Changed;

        /// <summary>
        /// Initialize the Model, Has to be implemented by the class that derived from this class.
        /// Be sure you call this base function after loading the data.
        /// </summary>
        public virtual void Initialize()
        {
            //When the model is initialized the model is changed.
            OnChanged(EventArgs.Empty);
        }

        protected void OnChanged(EventArgs args) //helper function.
        {
            if (Changed != null)
                Changed(this, args);
        }
    }
}