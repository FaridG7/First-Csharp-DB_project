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
    internal partial class MainForm : Form
    {
        public DBConnection Connection;
        public int C_ID { get; set; }
        public int E_ID { get; set; }
        public MainForm(int C_ID)
        {
            this.C_ID = C_ID;
            InitializeComponent();
        }
        public string CurrentTab { get; set; }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CurrentTab = "Class";
            Connection = new DBConnection();
        }

        private void rbnPanel_Click(object sender, EventArgs e)
        {

        }

        private void ribbonTab1_ActiveChanged(object sender, EventArgs e)
        {
            CurrentTab = "Class";
            RefreshGrid();
        }

        private void ribbonTab2_ActiveChanged(object sender, EventArgs e)
        {
            CurrentTab = "Laboratory";
            RefreshGrid();
        }

        private void ribbonTab3_ActiveChanged(object sender, EventArgs e)
        {
            CurrentTab = "Storage";
            RefreshGrid();
        }

        private void ribbonTab4_ActiveChanged(object sender, EventArgs e)
        {
            CurrentTab = "Other_E";
            RefreshGrid();

        }

        private void ribbonTab5_ActiveChanged(object sender, EventArgs e)
        {
            CurrentTab = "Stuff";
            RefreshGrid();
        }

        private void ribbonTab6_ActiveChanged(object sender, EventArgs e)
        {
            CurrentTab = "Staff";
            RefreshGrid();
        }
        public void RefreshGrid()
        {
            SqlDataAdapter adapter;
            DataSet ds;

            switch (CurrentTab)
            {
                case "Class":
                    adapter = new SqlDataAdapter("SELECT * FROM Classes", Connection.cnn);
                    ds = new DataSet();
                    adapter.Fill(ds, "Class");
                    dataGridView1.DataBindings.Clear();
                    dataGridView1.DataBindings.Add("datasource", ds, "Class");
                    break;
                case "Laboratory":
                    adapter = new SqlDataAdapter("SELECT * FROM Laboratories", Connection.cnn);
                    ds = new DataSet();
                    adapter.Fill(ds, "Laboratories");
                    dataGridView1.DataBindings.Clear();
                    dataGridView1.DataBindings.Add("datasource", ds, "Laboratories");
                    break;
                case "Storage":
                    adapter = new SqlDataAdapter("SELECT * FROM Storages", Connection.cnn);
                    ds = new DataSet();
                    adapter.Fill(ds, "Storages");
                    dataGridView1.DataBindings.Clear();
                    dataGridView1.DataBindings.Add("datasource", ds, "Storages");
                    break;
                case "Other_E":
                    adapter = new SqlDataAdapter("SELECT * FROM Other_Evironments", Connection.cnn);
                    ds = new DataSet();
                    adapter.Fill(ds, "Other_Evironments");
                    dataGridView1.DataBindings.Clear();
                    dataGridView1.DataBindings.Add("datasource", ds, "Other_Evironments");
                    break;
                case "Stuff":
                    adapter = new SqlDataAdapter("SELECT * FROM Stuff", Connection.cnn);
                    ds = new DataSet();
                    adapter.Fill(ds, "Stuff");
                    dataGridView1.DataBindings.Clear();
                    dataGridView1.DataBindings.Add("datasource", ds, "Stuff");
                    break;
                case "Staff":
                    adapter = new SqlDataAdapter("SELECT * FROM Staff", Connection.cnn);
                    ds = new DataSet();
                    adapter.Fill(ds, "Staff");
                    dataGridView1.DataBindings.Clear();
                    dataGridView1.DataBindings.Add("datasource", ds, "Staff");
                    break;
            }

        }

        private void rbnAddClass_Click(object sender, EventArgs e)
        {
            AddClass Afrm = new AddClass(C_ID, Connection);
            Afrm.ShowDialog();
            RefreshGrid();
        }

        private void rbnUpdateClass_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be changed
                UpdateClass Afrm = new UpdateClass(C_ID, E_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }

        }

        private void rbnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be changed
                Connection.Delete_Class(E_ID);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }
        }

        private void rbnAddLab_Click(object sender, EventArgs e)
        {
            AddLab Afrm = new AddLab(C_ID, Connection);
            Afrm.ShowDialog();
            RefreshGrid();
        }

        private void rbnUpdateLab_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be changed
                UpdateClass Afrm = new UpdateClass(C_ID, E_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }

        }

        private void rbnDeleteLab_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be changed
                Connection.Delete_Laboratory(E_ID);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a laboratory!");
            }

        }

        private void rbnAddStorage_Click(object sender, EventArgs e)
        {
            AddStorage Afrm = new AddStorage(C_ID, Connection);
            Afrm.ShowDialog();
            RefreshGrid();

        }

        private void rbnUpdateStorage_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be changed
                UpdateStorage Afrm = new UpdateStorage(C_ID, E_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }
        }

        private void rbnDeleteStorage_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be changed
                Connection.Delete_Laboratory(E_ID);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Storage!");
            }
        }

        private void ribbonPanel7_Click(object sender, EventArgs e)
        {
            AddOther_E Afrm = new AddOther_E(C_ID, Connection);
            Afrm.ShowDialog();
            RefreshGrid();
        }

        private void rbnUpdateEnv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be changed
                UpdateOther_E Afrm = new UpdateOther_E(C_ID, E_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Environment!");
            }
        }

        private void rbnDeleteEnv_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be changed
                Connection.Delete_Environment(E_ID);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Environment!");
            }
        }

        private void ribbonPanel10_Click(object sender, EventArgs e)
        {
        }

        private void rbnUpdateStuff_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int S_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be checked
                UpdateStuff Afrm = new UpdateStuff(S_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Stuff!");
            }
        }

        private void rbnDeleteStuff_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int S_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be checked
                Connection.Delete_Stuff(S_ID);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a laboratory!");
            }
        }

        private void rbnDamagedStuff_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int S_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int E_ID2;
                string Name;
                SqlCommand cmd = new SqlCommand("SELECT * FROM Stuff c WHERE c.S_ID = "
                       + S_ID.ToString(), Connection.cnn);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    E_ID2 = Convert.ToInt32(r["E_ID"]);
                    Name = r["Name"].ToString();
                    Connection.Update_Stuff(S_ID, E_ID2,Name, 1);
                }
                else
                {
                    MessageBox.Show("There Is an Error In rbnDamagedStuff_Click!");
                }
                r.Close();
                //the E_ID column should be checked
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Stuff!");
            }
        }

        private void rbnFixedStuff_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int S_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                int E_ID2;
                string Name;
                SqlCommand cmd = new SqlCommand("SELECT * FROM Stuff c WHERE c.S_ID = "
                       + S_ID.ToString(), Connection.cnn);
                SqlDataReader r = cmd.ExecuteReader();
                if (r.Read())
                {
                    E_ID2 = Convert.ToInt32(r["E_ID"]);
                    Name = r["Name"].ToString();
                    Connection.Update_Stuff(S_ID, E_ID2, Name, 0);
                }
                else
                {
                    MessageBox.Show("There Is an Error In rbnDamagedStuff_Click!");
                }
                r.Close();
                //the E_ID column should be checked
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Stuff!");
            }
        }

        private void rbnAddStuffC_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be checked
                AddStuff Afrm = new AddStuff(E_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }
        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be checked
                AddStuff Afrm = new AddStuff(E_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }
        }

        private void ribbonPanel3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be checked
                AddStuff Afrm = new AddStuff(E_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }

        }

        private void ribbonPanel4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                E_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be checked
                AddStuff Afrm = new AddStuff(E_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Class!");
            }

        }

        private void rbnKeyHolders_Click(object sender, EventArgs e)
        {

        }

        private void ribbonPanel13_Click(object sender, EventArgs e)
        {
            AddStaff Afrm = new AddStaff(C_ID, Connection);
            Afrm.ShowDialog();
            RefreshGrid();
        }

        private void rbnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int Staff_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the E_ID column should be checked
                UpdateStaff Afrm = new UpdateStaff(C_ID, Staff_ID, Connection);
                Afrm.ShowDialog();
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Staff!");
            }

        }

        private void rbnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int Staff_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                //the Staff_ID column should be checked
                Connection.Delete_Staff(Staff_ID);
                RefreshGrid();
            }
            else
            {
                MessageBox.Show("Please Select a Staff!");
            }
        }
    }
}
