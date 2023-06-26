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
    internal partial class UpdateStuff : Form
    {
        public int E_ID { get; set; }
        public int S_ID { get; set; }
        public int status { get; set; }
        public DBConnection conn { get; set; }
        public UpdateStuff(int S_ID, DBConnection Connection)
        {
            this.S_ID = S_ID;
            conn = Connection;
            InitializeComponent();
            InitializeComponent();
        }

        private void UpdateStuff_Load(object sender, EventArgs e)
        {
            //this part fills the grid with non-managers
            string selectsql = "SELECT * FROM Classes";
            SqlDataAdapter adapter = new SqlDataAdapter(selectsql, conn.cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Classes");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "Classes");
            //this part fills the textbox
            SqlCommand cmd = new SqlCommand("SELECT * FROM Stuff c WHERE c.S_ID = "
                + S_ID.ToString(), conn.cnn);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                txtAddStuff.Text = r["Name"].ToString();
                E_ID = Convert.ToInt32(r["E_ID"]);
                status = Convert.ToInt32(r["Health_status"]);
            }
            else
            {
                MessageBox.Show("There Is an Error...");
            }
            r.Close();
        }

        private void btnAddStuff_Click(object sender, EventArgs e)
        {
            if ((txtAddStuff.Text != "") && (dataGridView1.Rows.Count == 0))
            {
                conn.Update_Stuff(S_ID, E_ID, txtAddStuff.Text, status);
            }
            else if ((txtAddStuff.Text != "") && (dataGridView1.Rows.Count > 0))
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                conn.Update_Stuff(S_ID, E_ID, txtAddStuff.Text, status);
            }
            else
            {
                MessageBox.Show("Please Enter a Name!");
            }
            this.Close();

        }
    }
}
