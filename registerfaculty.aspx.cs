using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Default2 : System.Web.UI.Page
{
    static string url;
    OleDbCommand cmd;
    OleDbConnection con;
    OleDbParameter p1,p2, p3,p4,p5,p6,p7,p8,p9;
    string constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Shubham Singh\\Desktop\\Project oct 2016\\ARS.accdb";
    static string cmdstr;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            cmdstr = "insert into faculty values(@id,@pass,@name,@gender,@phone,@email,@address,@dept,@design)";
            con = new OleDbConnection(constr);
            con.Open();
            cmd = new OleDbCommand(cmdstr, con);
            p1 = new OleDbParameter("@id", OleDbType.VarChar, 50);
            p2 = new OleDbParameter("@pass", OleDbType.VarChar, 50);
            p3 = new OleDbParameter("@name", OleDbType.VarChar, 50);
            p4 = new OleDbParameter("@gender", OleDbType.VarChar, 50);
            p5 = new OleDbParameter("@phone", OleDbType.VarChar, 50);
            p6 = new OleDbParameter("@email", OleDbType.VarChar, 50);
            p7 = new OleDbParameter("@address", OleDbType.VarChar, 50);
            p8 = new OleDbParameter("@dept", OleDbType.VarChar, 50);
            p9 = new OleDbParameter("@design", OleDbType.VarChar, 50);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            p1.Value = facultyid.Text;
            p2.Value = Password.Text;
            p3.Value = TextBox3.Text;
            p4.Value = DropDownList1.Text;
            p5.Value = TextBox4.Text;
            p6.Value = TextBox5.Text;
            p7.Value = TextBox6.Text;
            p8.Value = TextBox7.Text;
            p9.Value = TextBox8.Text;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Redirect("http://localhost:49339/About.aspx");
            }
        }
        catch (OleDbException a)
        {
            ClientScript.RegisterStartupScript(GetType(), "alert", "alert('User Exist');", true);
        }

        finally
        {
            con.Close();
        }

    }
}