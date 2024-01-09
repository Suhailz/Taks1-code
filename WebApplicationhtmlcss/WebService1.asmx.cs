using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace WebApplicationhtmlcss
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        SqlConnection con = new SqlConnection("data source=DESKTOP-QAJJN4R\\MSSQLSERVER01,initial catalog=html9124,integrated security=true");
        [WebMethod]

        public void Insert (string A, string B, string C, int D, int E)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("employee_insert",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", A);
            cmd.Parameters.AddWithValue("@empid ", B);
            cmd.Parameters.AddWithValue("@adress", C);
            cmd.Parameters.AddWithValue("@age", D);
            cmd.Parameters.AddWithValue("@salary", E);
            con.Close();
        }
    }
}
