using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL
{
    internal partial class AddCollegeForm : Form
    {
        private DBConnection conn { get; set; }
        public AddCollegeForm(DBConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btnAddCollege_Click(object sender, EventArgs e)
        {
            if (txtBoxTitleCollege.Text != "")
            {
                if (grdManagersForCollege.Rows.Count > 0)
                {
                    int Manager_ID = Convert.ToInt32(grdManagersForCollege.SelectedRows[0].Cells[0].Value);
                    conn.Add_College(txtBoxTitleCollege.Text, Manager_ID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Select a Manager!");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Title!");
            }
        }

        private void AddCollegeForm_Load(object sender, EventArgs e)
        {
            //in here we should fill the grdview with staffs information that are not a manager
            string selectsql = "SELECT * FROM non_managers";
            SqlDataAdapter adapter = new SqlDataAdapter(selectsql, conn.cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "non_managers");
            grdManagersForCollege.DataBindings.Clear();
            grdManagersForCollege.DataBindings.Add("datasource", ds, "non_managers");
        }

        private void grdManagersForCollege_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
