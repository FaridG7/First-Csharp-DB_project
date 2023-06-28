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
    internal partial class KeyHolders : Form
    {
        public int C_ID { get; set; }
        public DBConnection conn { get; set; }
        public KeyHolders(int C_ID, DBConnection Connection)
        {
            this.C_ID = C_ID;
            conn = Connection;
            InitializeComponent();
        }

        private void KeyHolders_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddClass Afrm = new AddClass(C_ID, conn);
            Afrm.ShowDialog();
            refreshGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int KH_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                conn.Delete_KeyHolder(KH_ID);
                refreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }
        }

        private void refreshGrid()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM KH_procedure", conn.cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Key_holders");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "Key_holders");

        }
    }
}
