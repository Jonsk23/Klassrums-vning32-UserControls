using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Klassrumsövning30_Master_Content
{
    public class Contact7
    {
        private string firstName;
        private string lastName;
        private string id;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public Contact7(string Id, string fn, string ln)
        {
            id = Id;
            firstName = fn;
            lastName = ln;
        }
    }
}