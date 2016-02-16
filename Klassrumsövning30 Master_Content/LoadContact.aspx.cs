using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klassrumsövning32classlibrary;

namespace Klassrumsövning30_Master_Content
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        const string CON_STR = "Data Source=ACADEMY005-VM;Initial Catalog=AWA29Contacts;Integrated Security=SSPI";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(txtboxFirstName.Text.Length !=0 && txtboxFirstName.Text != null)
            {
                MySqlClass.AddContact(txtboxFirstName.Text, txtboxLastName.Text);
                //AddContact();
                Response.Redirect("./LoadContact.aspx");  //Laddar om sidan så att den uppdateras med nyligen tillagd information
            }
        }

        //private void AddContact()
        //{
        //    // Creates a SqlConnection and specifies the connection string.
        //    SqlConnection myConnection = new SqlConnection(CON_STR);

        //    try
        //    {
        //        // Opens a connection to the database
        //        myConnection.Open();

        //        // Creates a SqlCommand and specifies the connection and the stored procedure
        //        SqlCommand myCommand = new SqlCommand();
        //        myCommand.Connection = myConnection;
        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        myCommand.CommandText = "spAddContact";

        //        SqlParameter paramFirstName = new SqlParameter("@firstname", SqlDbType.VarChar);
        //        paramFirstName.Value = txtboxFirstName.Text;
        //        myCommand.Parameters.Add(paramFirstName);

        //        SqlParameter paramLastName = new SqlParameter("@lastname", SqlDbType.VarChar);
        //        paramLastName.Value = txtboxLastName.Text;
        //        myCommand.Parameters.Add(paramLastName);

        //        SqlParameter paramID = new SqlParameter("@new_id", SqlDbType.Int);
        //        paramID.Direction = ParameterDirection.Output;
        //        myCommand.Parameters.Add(paramID);

        //        myCommand.ExecuteNonQuery();

        //        //int newID = (int)paramID.Value;

        //        myCommand.CommandType = CommandType.Text;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }
        //}
    
        //private void LoadContacts()
        //{
        //    SqlConnection myConnection = new SqlConnection(CON_STR);
        //    SqlCommand myCommand = new SqlCommand("select * from Contacts", myConnection);

        //    try
        //    {
        //        myConnection.Open();

        //        SqlDataReader myReader = myCommand.ExecuteReader();

        //        while (myReader.Read())
        //        {
        //            string id = myReader["ID"].ToString();
        //            string firstName = myReader["FirstName"].ToString();
        //            string lastName = myReader["LastName"].ToString();

        //            contactList.Add(new Contact(id, firstName, lastName));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write($"<script>alert('{ex.Message}');</script>");
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }

        //    if (!IsPostBack)
        //    {
        //        string contactTable = "<div class=\"container\"><h2>Table</h2><button type=\"button\"class=\"btn btn-success btn-sm\"data-toggle=\"modal\"data-target=\"#myModal\">Add Contact</button><div class=\"table - responsive\"><table class=\"table\"><thead><tr><th>ID</th><th>Firstname</th><th>Lastname</th></tr></thead><tbody>";

        //        foreach (var tmpContact in contactList)
        //        {
        //            contactTable += $"<tr><td> {tmpContact.ID} </td><td> {tmpContact.FirstName} </td><td> {tmpContact.LastName} </td></tr>";
        //        }
        //        contactTable += "</tbody></table></div></div>";
        //        myLiteral.Text = contactTable;
        //    }
        //}

    }
}