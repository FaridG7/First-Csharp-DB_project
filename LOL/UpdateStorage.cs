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
    internal partial class UpdateStorage : Form
    {
        public int C_ID { get; set; }
        public int E_ID { get; set; }
        DBConnection conn;
        public UpdateStorage(int C_ID, int E_ID, DBConnection Connection)
        {
            this.conn = Connection;
            this.C_ID = C_ID;
            this.E_ID = E_ID;
            InitializeComponent();
        }

        private void UpdateStorage_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Storages c WHERE c.E_ID = "
               + E_ID.ToString(), conn.cnn);
            SqlDataReader r = cmd.ExecuteReader();
            if (r.Read())
            {
                txtBoxUpdateStorage.Text = r["Title"].ToString();
            }
            else
            {
                MessageBox.Show("There Is an Error...");
            }
            r.Close();

        }

        private void btnUpdateStorage_Click(object sender, EventArgs e)
        {
            if (txtBoxUpdateStorage.Text != "")
            {
                conn.Update_Storage(E_ID, C_ID, txtBoxUpdateStorage.Text);
                this.Close();
            }
        }
    }
}
