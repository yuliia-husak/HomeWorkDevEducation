using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Userdb_ADO
{
    class Program
    {
        SqlConnection conn = null;

        public Program()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UsersDB;Integrated Security=SSPI;";

        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            //pr.InsertQuery();
            pr.ReadData();

            Console.ReadKey();
           
        }

        public void InsertQuery()
        {
            try
            {
                conn.Open();
                string insertString = @"insert into Users (Name, Age) values ('Iaaac', '10') ('Alla', '18') ('Alex', '15') ('Inna', '13') ('Tim', '16')";
               
                SqlCommand cmd = new SqlCommand(@"insert into Users (Name, Age) values ('Tim', '16')", conn);
                
                cmd.ExecuteNonQuery();
                
                
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void ReadData()
        {
            SqlDataReader rdr = null;
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Users where Age > 15", conn);
                rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[1] + " " + rdr[2]);
                }
                //int line = 0;

                //while (rdr.Read())
                //{
                //    if (line == 0)
                //    {
                //        for (int i = 0; i < rdr.FieldCount; i++)
                //        {
                //            Console.Write(rdr.GetName(i).ToString() + " ");
                //        }
                //    }
                //    Console.WriteLine();
                //    line++;
                //    Console.WriteLine(rdr);
                //}
                //Console.WriteLine("----" + line.ToString());
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }

                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
