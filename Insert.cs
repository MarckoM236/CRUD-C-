using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string name=txb_name.Text;
            string lastname = txb_lastname.Text;
            string address = txb_address.Text;
            string phone = txb_phone.Text;
            string email = txb_email.Text;

          int result= controller.Insertar(name, lastname, address, phone, email);
            if (result > 1)
            {
                MessageBox.Show("Saved successfully");
            }
            else
            {
                MessageBox.Show("Could not save");
            }

        }
    }
}
