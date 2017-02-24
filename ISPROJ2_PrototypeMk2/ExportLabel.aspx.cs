using PROJ2_PTE.Class;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Export2
{
    public partial class ExportLabel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Business logic = new Business();
            GridView1.DataSource = logic.getbillingitem();
            GridView1.DataBind();
            GridView1.AllowPaging = true;
            GridView2.DataSource = logic.getbillingtask();
            GridView2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button1.Visible = false;
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition",
             "attachment;filename=BillingInfo.xls");
            Response.Charset = "";
            Response.ContentType = "application/vnd.ms-excel";

            //Change the Header Row back to white color
            GridView1.HeaderRow.Style.Add("background-color", "#FFFFFF");

            //Apply style to Individual Cells
            GridView1.HeaderRow.Cells[0].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[1].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[2].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[3].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[4].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[5].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[6].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[7].Style.Add("background-color", "green");
            GridView1.HeaderRow.Cells[8].Style.Add("background-color", "green");
            


            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                GridViewRow row = GridView1.Rows[i];

                //Change Color back to white
                row.BackColor = System.Drawing.Color.White;

                //Apply text style to each Row
                row.Attributes.Add("class", "textmode");

                //Apply style to Individual Cells of Alternating Row
                if (i % 2 != 0)
                {
                    row.Cells[0].Style.Add("background-color", "#C2D69B");
                    row.Cells[1].Style.Add("background-color", "#C2D69B");
                    row.Cells[2].Style.Add("background-color", "#C2D69B");
                    row.Cells[3].Style.Add("background-color", "#C2D69B");
                    row.Cells[4].Style.Add("background-color", "#C2D69B");
                    row.Cells[5].Style.Add("background-color", "#C2D69B");
                    row.Cells[6].Style.Add("background-color", "#C2D69B");
                    row.Cells[7].Style.Add("background-color", "#C2D69B");
                    row.Cells[8].Style.Add("background-color", "#C2D69B");
                }
            }

        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }
    }
}