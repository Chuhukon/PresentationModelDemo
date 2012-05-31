using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PresentationModelDemo.DomainModel;

namespace PresentationModelDemo.PresentationModel
{
    /// <summary>
    /// Basic example of a Presentation Model
    /// For a more detailed explanation about what a model can do, see the "AboutPresentationModel"
    /// </summary>
    public class ContentPresentationModel : BasePresentationModel
    {
        public bool DisplayTitle { get; set; }
        public Content Content { get; set; }

        /// <summary>
        /// initialize the model, load base data etc.
        /// </summary>
        public override void Initialize()
        {
            bool displayTitle = false;
            Boolean.TryParse(HttpContext.Current.Request.QueryString["title"], out displayTitle);
            DisplayTitle = displayTitle;

            //Example data
            Content = new Content
            {
                Title = "Welcome at this presentation",
                Link = "http://www.koodr.com",
                ContentText = "Lorizzle ipsum dolizzle sit amizzle, yo mamma adipiscing we gonna chung. Nullizzle sapizzle velizzle, tellivizzle volutpizzle, crackalackin mofo, gravida vizzle, arcu. Crunk egizzle tortizzle. Sizzle erizzle. Funky fresh izzle dolor dapibizzle turpis tempus break it down. Bling bling funky fresh nibh et tellivizzle. Shut the shizzle up izzle tortor. Dizzle funky fresh rhoncizzle nisi. In brizzle habitasse platea dictumst. Donec dapibus. Curabitur tellizzle urna, pretizzle bling bling, gizzle pot, eleifend vitae, nunc. Crunk suscipit. Integer semper velizzle fizzle break yo neck, yall."
            };

            base.Initialize(); //finally do the base stuff
        }
    }
}