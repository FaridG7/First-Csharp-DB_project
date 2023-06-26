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
    internal partial class AddStorage : Form
    {
        public int C_ID { get; set; }
        public DBConnection conn { get; set; }
        public AddStorage(int C_ID, DBConnection Connection)
        {
            this.C_ID = C_ID;
            conn = Connection;
            InitializeComponent();
        }

        private void btnAddStorage_Click(object sender, EventArgs e)
        {
            if (textBoxAddStorage.Text != "")
                conn.Add_Storage(C_ID, textBoxAddStorage.Text);
            else
                MessageBox.Show("Please enter Title!");

        }

        private void AddStorage_Load(object sender, EventArgs e)
        {

        }
    }
}
