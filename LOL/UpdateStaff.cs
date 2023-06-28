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
    internal partial class UpdateStaff : Form
    {
        int Staff_ID { get; set; }
        int C_ID { get; set; }
        DBConnection conn;
        public UpdateStaff(int C_ID, int Staff_ID, DBConnection Connection)
        {
            this.Staff_ID = Staff_ID;
            this.C_ID = C_ID;
            conn = Connection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text != "" && textBox2.Text != ""
                && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                && (dataGridView1.Rows.Count == 0))
            {
                conn.Update_Staff(Staff_ID, textBox1.Text,
                     textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, C_ID);
            }
            else if ((textBox1.Text != "" && textBox2.Text != ""
                && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                && (dataGridView1.Rows.Count > 0))
            {
                C_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[7].Value);
                conn.Update_Staff(Staff_ID, textBox1.Text,
                     textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, C_ID);
            }
            else
            {
                MessageBox.Show("Please Enter a Name!");
            }
            this.Close();
        }

        private void UpdateStaff_Load(object sender, EventArgs e)
        {
            //this part fills the grid with Colleges
            string selectsql = "SELECT * FROM College";
            SqlDataAdapter adapter = new SqlDataAdapter(selectsql, conn.cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "College");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "College");
            //this part fills the textbox
            SqlCommand cmd = new SqlCommand("SELECT * FROM Staff c WHERE c.Staff_ID = "
                + Staff_ID.ToString(), conn.cnn);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                textBox1.Text = r["First_name"].ToString();
                textBox2.Text = r["Last_name"].ToString();
                textBox3.Text = r["Phone_number"].ToString();
                textBox4.Text = r["Meli_code"].ToString();
                textBox5.Text = r["Zip_code"].ToString();
            }
            else
            {
                MessageBox.Show("There Is an Error...");
            }
            r.Close();
        }
    }
}
