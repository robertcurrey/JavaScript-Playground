﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JavaScript_Playground
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBasicOps_Click(object sender, EventArgs e)
        {
            Response.Redirect("BasicJSOps.aspx");
        }
    }
}