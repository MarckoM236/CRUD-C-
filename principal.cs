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
            dgv.DataSource = controller.Query();
            dgv.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert I= new Insert();
            this.Hide();
            I.ShowDialog();
            this.Show();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dgv.DataSource = controller.Query();
            dgv.AutoResizeColumns();

            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            update U = new update(id);
            this.Hide();
            U.ShowDialog();
            this.Show();
            

        }
    }
}
