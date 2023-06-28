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
    internal partial class UpdateCollege : Form
    {
        private DBConnection conn { get; set; }
        private int C_ID { get; set; }
        private int Manager_ID { get; set; }

        public UpdateCollege(int C_ID, DBConnection conn)
        {
            this.C_ID = C_ID;
            this.conn = conn;
            InitializeComponent();
        }

        private void UpdateCollege_Load(object sender, EventArgs e)
        {
            //this part fills the grid with non-managers
            string selectsql = "SELECT * FROM non_managers";
            SqlDataAdapter adapter = new SqlDataAdapter(selectsql, conn.cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "non_Managers");
            grdManagersForCollege.DataBindings.Clear();
            grdManagersForCollege.DataBindings.Add("datasource", ds, "non_managers");
            //this part fills the textbox
            SqlCommand cmd = new SqlCommand("SELECT * FROM College c WHERE c.C_ID = "
                + C_ID.ToString(), conn.cnn);
            SqlDataReader r = cmd.ExecuteReader();
            if(r.Read())
            {
                txtBoxTitleCollege.Text = r["Title"].ToString();
                Manager_ID = Convert.ToInt32(r["Manager_ID"]);
            }
            else
            {
                MessageBox.Show("There Is an Error...");
            }
            r.Close();
        }

        private void btnUpdateCollege_Click(object sender, EventArgs e)
        {
            if ((txtBoxTitleCollege.Text != "") && (grdManagersForCollege.Rows.Count == 0))
            {
                conn.Update_College(C_ID, txtBoxTitleCollege.Text, Manager_ID);
            }
            else if((txtBoxTitleCollege.Text != "") && (grdManagersForCollege.Rows.Count > 0)) {
                int Manager_ID = Convert.ToInt32(grdManagersForCollege.SelectedRows[0].Cells[0].Value);
                conn.Update_College(C_ID, txtBoxTitleCollege.Text, Manager_ID);
            }
            else
            {
                MessageBox.Show("Please Enter a Title!");
            }
            this.Close();
        }
    }
}
