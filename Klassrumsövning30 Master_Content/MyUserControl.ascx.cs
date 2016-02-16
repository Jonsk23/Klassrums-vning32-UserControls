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
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        //const string CON_STR = "Data Source=ACADEMY005-VM;Initial Catalog=AWA29Contacts;Integrated Security=SSPI";

        List<Contact> contactList = new List<Contact>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //LoadContacts();

            contactList.Clear();
            contactList = MySqlClass.LoadContacts();
            
            if (!IsPostBack)
            {
                string contactTable = "<div class=\"container\"><h2>Table</h2><button type=\"button\"class=\"btn btn-success btn-sm\"data-toggle=\"modal\"data-target=\"#myModal\">Interact with list</button><div class=\"table - responsive\"><table class=\"table\"><thead><tr><th>ID</th><th>Firstname</th><th>Lastname</th></tr></thead><tbody>";

                foreach (var tmpContact in contactList)
                {
                    contactTable += $"<tr><td> {tmpContact.ID} </td><td> {tmpContact.FirstName} </td><td> {tmpContact.LastName} </td></tr>";
                }
                contactTable += "</tbody></table></div></div>";

                myLiteral.Text = contactTable;
            }
        }

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

        //            contactList.Add(new Contact7(id, firstName, lastName));
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
        //        string contactTable = "<div class=\"container\"><h2>Table</h2><button type=\"button\"class=\"btn btn-success btn-sm\"data-toggle=\"modal\"data-target=\"#myModal\">Interact with list</button><div class=\"table - responsive\"><table class=\"table\"><thead><tr><th>ID</th><th>Firstname</th><th>Lastname</th></tr></thead><tbody>";

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
