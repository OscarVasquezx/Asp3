﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_19795372aspx
{
    public partial class asp1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            Session["ddlCategory"] = ddlCategory.SelectedValue;
            Session["ddlSupplier"] = ddlSupplier.SelectedValue;
            Session["strProduct"] = strProduct.Text;
            Session["strDescription"] = strDescription.Text;
            Session["strImage"] = strImage.Text;
            Session["decPrice"] = decPrice.Text;
            Session["bytNumberInStock"] = bytNumberInStock.Text;
            Session["bytNumberOnOrder"] = bytNumberOnOrder.Text;
            Session["bytReorderLevel"] = bytReorderLevel.Text;

            Response.Redirect("asp2.aspx");
        }
    }
}