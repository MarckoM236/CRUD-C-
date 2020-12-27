using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace CRUD
{
    public partial class update : Form
    {
        string id;
        public update(string Id)
        {
            InitializeComponent();
            this.id = Id;

            //fill fields
            var result=controller.QueryID(int.Parse(this.id));
            txbname.Text = result.GetValue(1).ToString();
            txblastname.Text = result.GetValue(2).ToString();
            txbaddress.Text = result.GetValue(3).ToString();
            txbphone.Text = result.GetValue(4).ToString();
            txbemail.Text = result.GetValue(5).ToString();
        }

        private void update_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txbname.Text;
            string lastname = txblastname.Text;
            string address = txbaddress.Text;
            string phone = txbphone.Text;
            string email = txbemail.Text;

            int result = controller.update(this.id,name, lastname, address, phone, email);
            if (result > 0)
            {
                MessageBox.Show("updated successfully");
            }
            else
            {
                MessageBox.Show("Could not update");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //close the windows
            this.Close();
        }
    }
}
