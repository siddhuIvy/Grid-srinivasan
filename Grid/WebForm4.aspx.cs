using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Grid
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/Data/XMLFile.xml"));
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
}