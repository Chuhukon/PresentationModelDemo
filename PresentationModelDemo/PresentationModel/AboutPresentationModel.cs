using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PresentationModelDemo.DomainModel;
using System.Web.Caching;

namespace PresentationModelDemo.PresentationModel
{
    public class AboutPresentationModel : BasePresentationModel
    {
        public IEnumerable<Message> AboutMessages {get; set;}

        //A datasource, for example a cache, but you can also connect to a database here...
        protected Cache Cache;

        public AboutPresentationModel ()
        {
            Cache = HttpContext.Current.Cache;
            
            if (Cache["key"] == null) //Initialize the datasource
            {
                List<Message> collection = new List<Message>();

                //Some example data, for demo purpose
                collection.Add(new Message { Name = "Peter Pan", MessageText = "Ping pong pan..." });
                collection.Add(new Message { Name = "bart Simpson", MessageText = "The sky is blue, you are yellow" });
                collection.Add(new Message { Name = "John Doe", MessageText = "Hi, I'am John" });

                Cache.Insert("key", collection.AsEnumerable(), null,
                  System.Web.Caching.Cache.NoAbsoluteExpiration,
                  TimeSpan.FromDays(30));
            }

        }

        /// <summary>
        /// Initialize the model
        /// </summary>
        public override void Initialize()
        {
            //Load data from the datasource into the model properties..
            AboutMessages = (IEnumerable<Message>)Cache["key"];
            base.Initialize();
        }

        /// <summary>
        /// Function called by the PageView, to save data to a datasource..
        /// a OnChanged event is fired at the end..
        /// </summary>
        /// <param name="name"></param>
        /// <param name="message"></param>
        public void OnSaveMessage(string name, string message)
        {
            //call businesslayer or dal / save to datastore..
            List<Message> messages = new List<Message>(AboutMessages);
            messages.Add(new Message { Name = name, MessageText = message });
            AboutMessages = messages.AsEnumerable();

            Cache["key"] = AboutMessages;

            OnChanged(EventArgs.Empty); //fire the event
        }
    }
}