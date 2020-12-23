using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class contact
    {
        private string Id;
        private string name;
        private string lastname;
        private string address;
        private string phone;
        private string email;
        private string created_at;
        

        public contact() { }
        public contact(string id, string nam, string lname, string add, string pho, string ema, string cr_at) {
            Id = id;
            name = nam;
            lastname = lname;
            address = add;
            phone = pho;
            email = ema;
            created_at = cr_at;
        }

        public string Idd
        {
            get { return Id; }
            set { Id = value; }
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
        public string Created
        {
            get { return created_at; }
            set { created_at = value; }
        }
    }
}
