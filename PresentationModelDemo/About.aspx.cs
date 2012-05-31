using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using PresentationModelDemo.PresentationModel;

namespace PresentationModelDemo
{
    public partial class About : PageView<AboutPresentationModel>
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            Model.OnSaveMessage(txtName.Text, txtMessage.Text);
        }

        protected override void OnModelChanged(object sender, EventArgs e)
        {
            Messages.DataSource = Model.AboutMessages;
            Messages.DataBind();
        }
    }
}
