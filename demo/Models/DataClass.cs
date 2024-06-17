using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Models
{
    internal class DataClass
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-K259ROS\SQLEXPRESS;Initial Catalog=Demo_ex;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        public void openConnection()

        {

            if (con.State == System.Data.ConnectionState.Closed)

            {

                con.Open();

            }

        }


        public void closeConnection()

        {

            if (con.State == System.Data.ConnectionState.Open)

            {

                con.Close();

            }

        }

        public SqlConnection getConnection()

        {

            return con;

        }

    }
}

