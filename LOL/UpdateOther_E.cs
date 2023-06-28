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
    internal partial class UpdateOther_E : Form
    {
        public int C_ID { get; set; }
        public int E_ID { get; set; }
        DBConnection conn;
        public UpdateOther_E(int C_ID, int E_ID, DBConnection Connection)
        {
            this.conn = Connection;
            this.C_ID = C_ID;
            this.E_ID = E_ID;
            InitializeComponent();
        }

        private void UpdateOther_E_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Environment c WHERE c.E_ID = "
               + E_ID.ToString() + "and c.Type = 4 ", conn.cnn);
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

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            if (txtBoxUpdateClass.Text != "")
            {
                conn.Update_Environment(E_ID, C_ID, txtBoxUpdateClass.Text);
                this.Close();
            }
        }
    }
}
