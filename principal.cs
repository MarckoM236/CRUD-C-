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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();

            //fill table with all record
            dgv.DataSource = controller.Query();
            dgv.AutoResizeColumns();
        }

        //open new window (insert form)
        private void button1_Click(object sender, EventArgs e)
        {
            Insert I= new Insert();
            this.Hide();
            I.ShowDialog();
            this.Show();
        }
        
        //update table
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv.DataSource = controller.Query();
            //dgv.AutoResizeColumns();      
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        //BTN update
        private void button2_Click(object sender, EventArgs e)
        {
            var id = this.dgv.CurrentRow.Cells[0].Value.ToString();//capture id of selected record
            //open new window and send id
            update U = new update(id);
            this.Hide();
            U.ShowDialog();
            this.Show();
            

        }

        //BTN delete
        private void button3_Click(object sender, EventArgs e)
        {
            var id = this.dgv.CurrentRow.Cells[0].Value.ToString();//capture id of selected record
            int result = controller.Delete(id);

            if(result > 0)
            {
                MessageBox.Show("The record was deleted successfully");
            }
            else
            {
                MessageBox.Show("Record could not be deleted");
            }
        }
    }
}
