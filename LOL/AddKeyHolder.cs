using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOL
{
    internal partial class AddKeyHolder : Form
    {
        public DBConnection conn { get; set; }
        public AddKeyHolder(DBConnection Connection)
        {
            conn = Connection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    int E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    int Staff_ID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                    conn.Add_KeyHolder(E_ID, Staff_ID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please Select a Laboratory!");
                }
            }
            else
            {
                MessageBox.Show("Please Select a Laboratory!");
            }
        }
    }
}
