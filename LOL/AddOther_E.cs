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
    internal partial class AddOther_E : Form
    {
        public int C_ID { get; set; }
        public DBConnection conn { get; set; }
        public AddOther_E(int C_ID, DBConnection Connection)
        {
            this.C_ID = C_ID;
            conn = Connection;
            InitializeComponent();
        }

        private void btnAddOther_E_Click(object sender, EventArgs e)
        {
            if (textBoxAddOther_E.Text != "")
                conn.Add_Environment(C_ID, textBoxAddOther_E.Text);
            else
                MessageBox.Show("Please enter Title!");
        }

        private void AddOther_E_Load(object sender, EventArgs e)
        {

        }
    }
}
