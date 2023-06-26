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
    internal partial class UpdateClass : Form
    {
        public int C_ID { get; set; }
        public int E_ID { get; set; }
        DBConnection conn;
        public UpdateClass(int C_ID, int E_ID, DBConnection Connection)
        {
            this.conn = Connection;
            this.C_ID = C_ID;
            this.E_ID = E_ID;
            InitializeComponent();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (txtBoxUpdateClass.Text != "")
            {
                conn.Update_Class(E_ID, C_ID, txtBoxUpdateClass.Text);
                this.Close();
            }
        }

        private void UpdateClass_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Classes c WHERE c.E_ID = "
               + E_ID.ToString(), conn.cnn);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                txtBoxUpdateClass.Text = r["Title"].ToString();
            }
            else
            {
                MessageBox.Show("There Is an Error...");
            }
            r.Close();
        }
    }
}
