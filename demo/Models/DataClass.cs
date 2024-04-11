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
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-N9J4H06Q\MSSQLSERVER01;Initial Catalog=script;Integrated Security=True");

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

