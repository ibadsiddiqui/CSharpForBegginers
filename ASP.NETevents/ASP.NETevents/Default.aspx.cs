using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NETevents
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyButton.Click += MyButton_Click;
        }

        void MyButton_Click(object sender, EventArgs e)
        {
               //throw new NotImplementedException();
            MyLabel.Text = "Hello world";
        }
    }
}