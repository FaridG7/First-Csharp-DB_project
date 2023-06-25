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
    public partial class College_Form : Form
    {
        private DBConnection Conn { get; set; }

        private int C_ID { set; get; }

        public College_Form()
        {
            Conn = new DBConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void College_Form_Load(object sender, EventArgs e)
        {
            RefreshTheCollegeGrid();
        }
        public void RefreshTheCollegeGrid()
        {
            //this function fills the grid with college data
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM College", Conn.cnn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "College");
            dataGridView1.DataBindings.Clear();
            dataGridView1.DataBindings.Add("datasource", ds, "College");
            //Don't know why do I have to give those strings ("datasource", "College")
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCollegeForm ACfrm = new AddCollegeForm(Conn);
            ACfrm.ShowDialog();
            RefreshTheCollegeGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                C_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                UpdateCollege UCfrm = new UpdateCollege(C_ID, Conn);
                UCfrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select a College!");
            }
            RefreshTheCollegeGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                C_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                Conn.Delete_College(C_ID);
            }
            else
            {
                MessageBox.Show("Please Select a College!");
            }
            RefreshTheCollegeGrid();
        }

        private void btnSelectCollege_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                C_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //Open the Ali's form
            }
            else
            {
                MessageBox.Show("Please Select a College!");
            }
        }
    }
}
