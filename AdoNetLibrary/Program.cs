using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetLibrary
{
    class Program
    {
        SqlConnection conn = null;

        public Program()
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=SSPI;";

        }
        
        static void Main(string[] args)
        {
            Program pr = new Program();
            pr.InsertQuery();
            pr.ReadData();

            Console.ReadKey();
            
        }

        public void InsertQuery()
        {
            try
            {
                conn.Open();
                string insertString = @"insert into Authors (FirstName, LastName) values ('Roger', 'Zelazny')";
                string insert2String = @"insert into Authors (FirstName, LastName) values ('Andrew', 'Troelsen')";
                string insert3String = @"insert into Authors (FirstName, LastName) values ('Gerbert', 'Shild')";
                SqlCommand cmd = new SqlCommand(insertString, conn);
                SqlCommand cmd2 = new SqlCommand(insert2String, conn);
                SqlCommand cmd3 = new SqlCommand(insert3String, conn);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                
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
                SqlCommand cmd = new SqlCommand("select * from Authors", conn);
                rdr = cmd.ExecuteReader();
                int line = 0;

                while (rdr.Read()) 
                {
                    if (line == 0)
                    {
                        for(int i = 0; i < rdr.FieldCount; i++)
                        {
                            Console.Write(rdr.GetName(i).ToString() + " ");
                        }
                    }
                    Console.WriteLine();
                    line++;
                    Console.WriteLine(rdr[1] + " " + rdr[2]);
                }
                Console.WriteLine("O///// " + line.ToString());
            }
            finally
            {
                if(rdr != null)
                {
                    rdr.Close();
                }

                if(conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
