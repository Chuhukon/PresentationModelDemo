using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PresentationModelDemo.PresentationModel;

namespace PresentationModelDemo
{
    public partial class _Default : PageView<ContentPresentationModel>
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnModelChanged(object sender, EventArgs e)
        {

            //TODO Implement binding... see PageView for details...
        }
    }
}
