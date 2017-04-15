using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Login : System.Web.UI.Page
{
    static string url;
    OleDbCommand cmd;
    OleDbConnection con;
    OleDbParameter  p2, p3;
    string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Shubham Singh\\Desktop\\Project oct 2016\\ARS.accdb";
    static string cmdstr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex.Equals(1))
        {
             cmdstr = "select * from faculty where id= @id and password=@pass";
             url = "http://localhost:49339/faculty.aspx";
        }
        else if (DropDownList1.SelectedIndex.Equals(3))
        {
             cmdstr = "select * from student where id= @id and password=@pass";
             url = "http://localhost:49339/studentlogin.aspx";
        }
        else if (DropDownList1.SelectedIndex.Equals(2))
        {
             cmdstr = "select * from eventmanager where id= @id and password=@pass";
             url = "http://localhost:49339/eventmanager.aspx";
        }
        else if (DropDownList1.SelectedIndex.Equals(4))
        {
            cmdstr = "select * from admin where id= @id and password=@pass";
            url = "http://localhost:49339/admin.aspx";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         try
         {
            con = new OleDbConnection(constr);
            con.Open();
            cmd = new OleDbCommand(cmdstr, con);
          
            p2 = new OleDbParameter("@id", OleDbType.VarChar, 50);
            p3 = new OleDbParameter("@pass", OleDbType.VarChar, 50);
           
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
           
            p2.Value = TextBox1.Text;
            p3.Value = TextBox2.Text;
            OleDbDataReader dr = cmd.ExecuteReader();
          
                if(dr.HasRows)
                {
                    
                    Response.Redirect(url);
                }
            

         }
         catch (OleDbException x)
         {
             ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Incorrect ID/Password');", true);
         }
    }
}