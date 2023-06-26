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
    internal partial class AddStaff : Form
    {
        int C_ID { get; set; }
        DBConnection conn;
        public AddStaff(int C_ID, DBConnection Connection)
        {
            this.C_ID = C_ID;
            conn = Connection;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" 
                && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                conn.Add_Staff(textBox1.Text, textBox2.Text, textBox3.Text,
                    textBox4.Text, textBox5.Text, C_ID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please Enter the Values");
            }
        }
    }
}
