using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace DisconnectedModeADO_WF
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;
        DataTable dataTable = null;
        SqlCommand sqlCommand = null;
        String connectionString = null;
        SqlDataReader reader = null;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["MyConnString"].ConnectionString;
            string sql = "select * from @p1";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", textBox1.Text);   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlCommand = new SqlCommand();
                sqlCommand.CommandText = textBox1.Text;
                sqlCommand.Connection = sqlConnection;
                dataGridView1.DataSource = null;
                sqlConnection.Open();
                dataTable = new DataTable();
                reader = sqlCommand.ExecuteReader();
                int line = 0;
                do
                {
                    while (reader.Read())
                    {
                        if(line == 0)
                        {
                            for(int i=0;i<reader.FieldCount; i++)
                            {
                                dataTable.Columns.Add(reader.GetName(i));
                            }
                            line++;
                        }
                        DataRow row = dataTable.NewRow();
                        for (int i = 0; i < reader.FieldCount; i++) 
                        {
                            row[i] = reader[i];
                        }
                        dataTable.Rows.Add(row);
                    }
                } while (reader.NextResult());
                dataGridView1.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }
    }
}
