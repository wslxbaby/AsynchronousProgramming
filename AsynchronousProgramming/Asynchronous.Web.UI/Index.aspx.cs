using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Asynchronous.Service;

namespace Asynchronous.Web.UI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Click(object sender, EventArgs e)
        {
            AsyncMethod am = new AsyncMethod();
            am.DoSomethingAsync();
            txt.Text = "done";
        }
    }
}