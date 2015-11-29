﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Joymononline.Account
{
    public partial class Login : System.Web.UI.Page
    {
        public string WhatsNew { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                WhatsNew = DataProviderFactory.GetWhoAmIDataProvider().GetData();
            }
            catch (Exception ex)
            {
                WhatsNew = ex.GetFullMessageInHTML();
            }
        }
    }
}