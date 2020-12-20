using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class contact
    {
        private string name;
        private string lastname;
        private string address;
        private string phone;
        private string email;
        

        public contact() { }
        public contact(string nam, string lname, string add, string pho, string ema) {
            name = nam;
            lastname = lname;
            address = add;
            phone = pho;
            email = ema;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
