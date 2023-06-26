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
    internal partial class AddLab : Form
    {
        public int C_ID { get; set; }
        public DBConnection conn { get; set; }
        public AddLab(int C_ID, DBConnection Connection)
        {
            this.C_ID = C_ID;
            conn = Connection;
            InitializeComponent();
        }

        private void btnAddLab_Click(object sender, EventArgs e)
        {
            if (textBoxAddLab.Text != "")
                conn.Add_Laboratory(C_ID, textBoxAddLab.Text);
            else
                MessageBox.Show("Please enter Title!");
        }

        private void AddLab_Load(object sender, EventArgs e)
        {

        }
    }
}
