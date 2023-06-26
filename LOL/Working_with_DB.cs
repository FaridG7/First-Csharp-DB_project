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
    internal interface Working_with_DB
    {
        string scnn { get; set; }

        SqlConnection cnn { get; set; }

        void Disconnection();

        void Add_College(string Title, int Manager_ID);
        void Update_College(int C_ID, string Title, int Manager_ID);
        void Delete_College(int C_ID);

        void Add_Staff(string Firstname, string Lastname, string Phone_num, string Meli_code, string Zip_code, int C_ID);
        void Update_Staff(int S_ID, string Firstname, string Lastname, string Phone_num, string Meli_code, string Zip_code, int C_ID);
        void Delete_Staff(int S_ID);

        void Add_Class(int C_ID, string Title);
        void Update_Class(int E_ID, int C_ID, string Title);
        void Delete_Class(int E_ID);

        void Add_Storage(int C_ID, string Title);
        void Update_Storage(int E_ID, int C_ID, string Title);
        void Delete_Storage(int E_ID);

        void Add_Laboratory(int C_ID, string Title);
        void Update_Laboratory(int E_ID, int C_ID, string Title);
        void Delete_Laboratory(int E_ID);

        void Add_Environment(int C_ID, string Title);
        void Update_Environment(int E_ID, int C_ID, string Title);
        void Delete_Environment(int E_ID);

        void Add_Stuff(int E_ID, string Name);
        void Update_Stuff(int S_ID, int E_ID, string Name, int Status);
        void Delete_Stuff(int S_ID);

    }
}
