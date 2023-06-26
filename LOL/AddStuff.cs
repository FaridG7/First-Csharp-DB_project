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
    internal partial class AddStuff : Form
    {
        public int E_ID { get; set; }
        public DBConnection conn { get; set; }
        public AddStuff(int E_ID, DBConnection Connection)
        {
            this.E_ID = E_ID;
            conn = Connection;
            InitializeComponent();
        }

        private void btnAddStuff_Click(object sender, EventArgs e)
        {
            if (txtAddStuff.Text != "")
                conn.Add_Stuff(E_ID, txtAddStuff.Text);
            else
                MessageBox.Show("Please enter Title!");
        }

        private void AddStuff_Load(object sender, EventArgs e)
        {

        }
    }
}
