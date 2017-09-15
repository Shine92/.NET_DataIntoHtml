using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace test0915_DataReader {
    public partial class Default : System.Web.UI.Page {
        public SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e) {
            SqlConnection cn = new SqlConnection(@"Server=.\SQLExpress;database=Northwind;uid=sa;password=P@ssw0rd");
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Products",cn);
            dr = cmd.ExecuteReader();
        }
    }
}