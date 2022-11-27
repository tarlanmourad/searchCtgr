using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace searchCtgr
{
    public partial class index : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Data Source=TARLAN\\LOCALHOST;Initial Catalog=Northwind;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM prdctCtgr WHERE CategoryName = '" + txtCtgr.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();

            if(ds.Tables[0].Rows.Count > 0)
            {
                grdTable.Visible = true;
                lblResult.Text = "";
                conn.Open();
                string queryFill = "SELECT * FROM prdctCtgr WHERE CategoryName = '" + txtCtgr.Text + "'";
                SqlCommand cmdx = new SqlCommand(queryFill, conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmdx);
                DataTable dta = new DataTable();
                sda.Fill(dta);
                grdTable.DataSource = dta;
                grdTable.DataBind();
            }
            else
            {
                grdTable.Visible = false;
                lblResult.Text = "No matching row to this search";
            }
        }
    }
}