using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace LOL
{
    internal class DBConnection : Working_with_DB
    {
        public string scnn { get; set; }

        public SqlConnection cnn { get; set; }

        public DBConnection()
        {
            scnn = "Data Source = .; Initial Catalog = Uneversity_DB; Integrated Security = True";

            try
            {
                cnn = new SqlConnection(scnn);
                cnn.Open();
            }
            catch
            {
                MessageBox.Show("Error in opening Database Connection!...");
            }
        }
        public void Disconnection()
        {
            if (cnn.State == ConnectionState.Open)
                cnn.Close();
        }

        public void Add_Class(int C_ID, string Title, int chair_count)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Classes(chair_count,Title,C_ID)" + 
                    " VALUES(@chair_count, @Title, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", chair_count);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Add_College(string Title, int Manager_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO College(Title,Manager_ID)" +
                    " VALUES(@chair_count, @Title, @Manager_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@Manager_ID", Manager_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Add_Environment(int C_ID, string Title, int chair_count)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Other_Environments(chair_count,Title,C_ID)" +
                    " VALUES(@chair_count, @Title, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", chair_count);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }


        public void Add_Laboratory(int C_ID, string Title, int chair_count)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Laboratories(chair_count,Title,C_ID)" +
                    " VALUES(@chair_count, @Title, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", chair_count);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Add_Staff(string Firstname, string Lastname, string Meli_code, string Zip_code, int C_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Staff(First_name,Last_name, Meli_code, Zip_code,C_ID)" +
                    " VALUES(@firstname, @lastname, @meliCode, @zipCode, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@firstname", Firstname);
                sqlcmd.Parameters.AddWithValue("@lastname", Lastname);
                sqlcmd.Parameters.AddWithValue("@meliCode", Meli_code);
                sqlcmd.Parameters.AddWithValue("@zipCode", Zip_code);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Add_Storage(int C_ID, string Title, int chair_count)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Storages(chair_count,Title,C_ID)" +
                    " VALUES(@chair_count, @Title, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", chair_count);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Delete_Class(int E_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM Classes Where E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@E_ID", E_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Delete_College(int C_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM Classes Where C_ID = @C_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Delete_Environment(int E_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM Other_environments Where E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@E_ID", E_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }


        public void Delete_Laboratory(int E_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM Laboratories Where E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@E_ID", E_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Delete_Staff(int S_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM Staff Where S_ID = @S_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@S_ID", S_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Delete_Storage(int E_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM Storages Where E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@E_ID", E_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Update_Class(int E_ID, int C_ID, string Title, int chair_count)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Classes " +
                    "SET C_ID = @C_ID , Chair_count = @chaircount, Title = @Title" +
                    " WHERE E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", chair_count);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Update_College(int C_ID, string Title, int Manager_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE College " +
                    "SET  Title = @Title, Manager_ID = @Manager_ID" +
                    " WHERE C_ID = @C_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@Manager_ID", Manager_ID);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Update_Environment(int E_ID, int C_ID, string Title, int chair_count)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Other_Environments " +
                    "SET C_ID = @C_ID , Chair_count = @chaircount, Title = @Title" +
                    " WHERE E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", chair_count);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }


        public void Update_Laboratory(int E_ID, int C_ID, string Title, int chair_count)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Laboratories " +
                    "SET C_ID = @C_ID , Chair_count = @chaircount, Title = @Title" +
                    " WHERE E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", chair_count);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Update_Staff(int S_ID, string Firstname, string Lastname, string Meli_code, string Zip_code, int C_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Staff " +
                    "SET C_ID = @C_ID , First_name = @Firstname, Last_name = @Lastname, Meli_code = @Meli_code, Zip_code = @Zip_code" +
                    " WHERE S_ID = @S_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@Firstname", Firstname);
                sqlcmd.Parameters.AddWithValue("@Lastname", Lastname);
                sqlcmd.Parameters.AddWithValue("@Meli_code", Meli_code);
                sqlcmd.Parameters.AddWithValue("@Zip_code", Zip_code);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.Parameters.AddWithValue("@S_ID", S_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Update_Storage(int E_ID, int C_ID, string Title, int chair_count)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Storages " +
                    "SET C_ID = @C_ID , Chair_count = @chaircount, Title = @Title" +
                    " WHERE E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", chair_count);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }
    }
}
