using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Asynchronous.Service;
using System.Threading.Tasks;

namespace Asynchronous.Web.UI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected async void btn_Click(object sender, EventArgs e)
        {
            AsyncMethod am = new AsyncMethod();
            await DoSomethingAsync();
            txt.Text = "done";
        }

        async Task DoSomethingAsync()
        {
            int val = 13;
            await Task.Delay(TimeSpan.FromSeconds(1));
            val *= 2;
            await Task.Delay(TimeSpan.FromSeconds(1));
           // Trace.WriteLine(val);
        }
    }
}