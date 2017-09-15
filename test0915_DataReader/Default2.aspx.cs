using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace test0915_DataReader {
    public partial class Default2 : System.Web.UI.Page {
        public DataSet ds;
        protected void Page_Load(object sender, EventArgs e) {
            SqlConnection cn =  new SqlConnection(@"Server=.\SQLExpress;database=Northwind;uid=sa;password=P@ssw0rd");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Products", cn);
            ds= new DataSet(); //1個資料集實體
            da.Fill(ds,"Prod");  //資料匯入 指定一個資料表名稱

            foreach (DataRow dr in ds.Tables["Prod"].Rows) {  //找出資料表Prod的每一筆ROWS
                
            }
        }
    }
}