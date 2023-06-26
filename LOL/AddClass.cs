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
    internal partial class AddClass : Form
    {
        public int C_ID { get; set; }
        public DBConnection conn { get; set; }
        public AddClass(int C_ID, DBConnection Connection)
        {
            this.C_ID = C_ID;
            conn = Connection;
            InitializeComponent();
        }

        private void AddClass_Load(object sender, EventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (textBoxAddClass.Text != "")
                conn.Add_Class(C_ID, textBoxAddClass.Text);
            else
                MessageBox.Show("Please enter Title!");
        }
    }
}
