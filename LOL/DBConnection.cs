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
            scnn = "Data Source = ALI; Initial Catalog = Uneversity_DB; Integrated Security = True";

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

        public void Add_Class(int C_ID, string Title)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO environment(chair_count,Title, type,C_ID)" + 
                    " VALUES(@chair_count, @title, 1, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", 0);
                sqlcmd.Parameters.AddWithValue("@title", Title);
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

        public void Add_Environment(int C_ID, string Title)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Environment(chair_count,Title,type,C_ID)" +
                    " VALUES(@chair_count, @Title, @Type, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", 0);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@Type", 4);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }


        public void Add_Laboratory(int C_ID, string Title)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO environment(chair_count,Title,type,C_ID)" +
                    " VALUES(@chair_count, @Title, 2, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", 0);
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Add_Staff(string Firstname, string Lastname, string Phone_num, string Meli_code, string Zip_code, int C_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Staff(First_name,Last_name,@phone_number Meli_code, Zip_code,C_ID)" +
                    " VALUES(@firstname, @lastname, @Phone_num, @meliCode, @zipCode, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@firstname", Firstname);
                sqlcmd.Parameters.AddWithValue("@lastname", Lastname);
                sqlcmd.Parameters.AddWithValue("@Phone_num", Phone_num);
                sqlcmd.Parameters.AddWithValue("@meliCode", Meli_code);
                sqlcmd.Parameters.AddWithValue("@zipCode", Zip_code);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Add_Storage(int C_ID, string Title)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Storages(chair_count,Title,C_ID)" +
                    " VALUES(@chair_count, @Title, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@chair_count", 0);
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

        public void Delete_Environment(int E_ID )
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
      
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM other_evironments Where E_ID = @E_ID";
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
                sqlcmd.CommandText = "DELETE FROM Staff Where Staff_ID = @S_ID";
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

        public void Update_Class(int E_ID, int C_ID, string Title)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Classes " +
                    "SET C_ID = +" + @C_ID.ToString() + ", Chair_count = 0, Title =  @Title "  +
                    " WHERE E_ID = " + @E_ID.ToString();
                sqlcmd.Connection = cnn;
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

        public void Update_Environment(int E_ID, int C_ID, string Title)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Environment " +
                    "SET C_ID = @C_ID , Chair_count = 0, Title = @Title" +
                    " WHERE E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.Parameters.AddWithValue("@E_ID", E_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }


        public void Update_Laboratory(int E_ID, int C_ID, string Title)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Laboratories " +
                    "SET C_ID = @C_ID , Chair_count = 0, Title = @Title" +
                    " WHERE E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Update_Staff(int S_ID, string Firstname, string Lastname, string Phone_num, string Meli_code, string Zip_code, int C_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Staff " +
                    "SET C_ID = @C_ID , First_name = @Firstname, Last_name = @Lastname,  Phone_number = @phone_num, Meli_code = @Meli_code, Zip_code = @Zip_code" +
                    " WHERE Staff_ID = @S_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@Firstname", Firstname);
                sqlcmd.Parameters.AddWithValue("@Lastname", Lastname);
                sqlcmd.Parameters.AddWithValue("@phone_num", Phone_num);
                sqlcmd.Parameters.AddWithValue("@Meli_code", Meli_code);
                sqlcmd.Parameters.AddWithValue("@Zip_code", Zip_code);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.Parameters.AddWithValue("@S_ID", S_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Update_Storage(int E_ID, int C_ID, string Title)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Storages " +
                    "SET C_ID = @C_ID , Chair_count = 0, Title = @Title" +
                    " WHERE E_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@Title", Title);
                sqlcmd.Parameters.AddWithValue("@C_ID", C_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Add_Stuff(int E_ID, string Name)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Stuff(Name, Health_status, E_ID)" +
                    " VALUES(@Name, @Health_status, @C_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@Name", Name);
                sqlcmd.Parameters.AddWithValue("@Health_status", 0);
                sqlcmd.Parameters.AddWithValue("@C_ID", E_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Update_Stuff(int S_ID, int E_ID, string Name, int Status)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "UPDATE Stuff " +
                    "SET E_ID = @E_ID, Name = @Name, Health_status = @Status" +
                    " WHERE S_ID = "+ @S_ID.ToString();
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@E_ID", E_ID);
                sqlcmd.Parameters.AddWithValue("@Name", Name);
                sqlcmd.Parameters.AddWithValue("@Status", Status);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Delete_Stuff(int S_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM Stuff Where S_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@E_ID", S_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Add_KeyHolder(int E_ID, int Staff_ID)
        {

            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "INSERT INTO Key_holders(E_ID, Staff_ID)" +
                    " VALUES(@E_ID, @Staff_ID)";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@E_ID", E_ID);
                sqlcmd.Parameters.AddWithValue("@Staff_ID", Staff_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }

        public void Delete_KeyHolder(int KH_ID)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandText = "DELETE FROM Key_holders Where KH_ID = @E_ID";
                sqlcmd.Connection = cnn;
                sqlcmd.Parameters.AddWithValue("@E_ID", KH_ID);
                sqlcmd.ExecuteNonQuery();
            }
        }
    }
}
