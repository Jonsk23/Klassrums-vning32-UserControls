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
    public partial class WebForm3 : System.Web.UI.Page
    {
        const string CON_STR = "Data Source=ACADEMY005-VM;Initial Catalog=AWA29Contacts;Integrated Security=SSPI";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (contactId.Text.Length != 0 && contactId.Text != null)
            {
                MySqlClass.UpdateContacts(contactId.Text, txtboxFirstName.Text, txtboxLastName.Text);
                //UpdateContacts();
                Response.Redirect("./UpdateContact.aspx");  //Laddar om sidan så att den uppdateras med nyligen tillagd information
            }    
        }

        //private void UpdateContacts()
        //{
        //    SqlConnection myConnection = new SqlConnection(CON_STR);
            
        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand("select * from Contacts", myConnection);
        //        myCommand.Connection = myConnection;
        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        myCommand.CommandText = "spUpdateContact";

        //        SqlParameter paramFirstName = new SqlParameter("@firstName", SqlDbType.VarChar);
        //        paramFirstName.Value = txtboxFirstName.Text;
        //        myCommand.Parameters.Add(paramFirstName);

        //        SqlParameter paramLastName = new SqlParameter("@lastName", SqlDbType.VarChar);
        //        paramLastName.Value = txtboxLastName.Text;
        //        myCommand.Parameters.Add(paramLastName);

        //        SqlParameter paramID = new SqlParameter("@id", SqlDbType.Int);
        //        paramID.Value = contactId.Text;
        //        myCommand.Parameters.Add(paramID);

        //        myCommand.ExecuteNonQuery();

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
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally
        //    {
        //        myConnection.Close();
        //    }

        //    if (!IsPostBack)
        //    {
        //        string contactTable = "<div class=\"container\"><h2>Table</h2><button type=\"button\"class=\"btn btn-warning btn-sm\"data-toggle=\"modal\"data-target=\"#myModal\">Update Contact</button><div class=\"table - responsive\"><table class=\"table\"><thead><tr><th>ID</th><th>Firstname</th><th>Lastname</th></tr></thead><tbody>";

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