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
    internal partial class UpdateLab : Form
    {
        public int C_ID { get; set; }
        public int E_ID { get; set; }
        DBConnection conn;
        public UpdateLab(int C_ID, int E_ID, DBConnection Connection)
        {
            this.conn = Connection;
            this.C_ID = C_ID;
            this.E_ID = E_ID;
            InitializeComponent();
        }

        private void UpdateLab_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Laboratories c WHERE c.E_ID = "
               + E_ID.ToString(), conn.cnn);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                txtBoxUpdateLab.Text = r["Title"].ToString();
            }
            else
            {
                MessageBox.Show("There Is an Error...");
            }
            r.Close();

        }

        private void btnUpdateLab_Click(object sender, EventArgs e)
        {
            if (txtBoxUpdateLab.Text != "")
            {
                conn.Update_Laboratory(E_ID, C_ID, txtBoxUpdateLab.Text);
                this.Close();
            }
        }
    }
}
