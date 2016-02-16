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
    public partial class WebForm4 : System.Web.UI.Page
    {
        const string CON_STR = "Data Source=ACADEMY005-VM;Initial Catalog=AWA29Contacts;Integrated Security=SSPI";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (inputId.Text.Length != 0 && inputId.Text != null)
            {
                MySqlClass.DeleteContact(inputId.Text);
                //DeleteContact();
                Response.Redirect("./DeleteContact.aspx"); //Laddar om sidan så att den uppdateras med nyligen borttagen information
            }
        }

        //private void DeleteContact()
        //{
        //    SqlConnection myConnection = new SqlConnection(CON_STR);

        //    try
        //    {
        //        myConnection.Open();

        //        SqlCommand myCommand = new SqlCommand("select * from Contacts", myConnection);
        //        myCommand.Connection = myConnection;
        //        myCommand.CommandType = CommandType.StoredProcedure;
        //        myCommand.CommandText = "spDeleteContact";

        //        int cid;

        //        if (int.TryParse(inputId.Text, out cid))
        //        {
        //            SqlParameter paramID = new SqlParameter("@ID", SqlDbType.Int);
        //            paramID.Value = cid;
        //            myCommand.Parameters.Add(paramID);

        //            myCommand.ExecuteNonQuery();

        //            inputId.Text = "";
        //        }

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
        //    Response.Redirect("./DeleteContact.aspx"); //Laddar om sidan så att den uppdateras med nyligen borttagen information
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

        //        string contactTable = "<div class=\"container\"><h2>Table</h2><button type=\"button\"class=\"btn btn-danger btn-sm\"data-toggle=\"modal\"data-target=\"#myModal\">Delete Contact</button><div class=\"table - responsive\"><table class=\"table\"><thead><tr><th>ID</th><th>Firstname</th><th>Lastname</th></tr></thead><tbody>";
        //        //int selIndex = lboxContacts.SelectedIndex;
        //        //lboxContacts.Items.Clear();
        //        foreach (var tmpContact in contactList)
        //        {
        //            //ListItem tmpItem = new ListItem($"{tmpContact.FirstName} {tmpContact.LastName}", tmpContact.ID);
        //            //lboxContacts.Items.Add(tmpItem);
        //            contactTable += $"<tr><td> {tmpContact.ID} </td><td> {tmpContact.FirstName} </td><td> {tmpContact.LastName} </td></tr>";
        //        }
        //        contactTable += "</tbody></table></div></div>";
        //        myLiteral.Text = contactTable;

        //        //if (selIndex > 0)
        //        //    lboxContacts.SelectedIndex = selIndex;

        //    }
        //}
    }
}