using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisconectedModeADO_Fill_Update_WF
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;       
        String connectionString = null;
        SqlDataAdapter sqlDataAdapter = null;
        DataSet dataSet = null;
        SqlCommandBuilder sqlCommandBuilder = null;
        
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.
                ConnectionStrings["MyConnString"].
                ConnectionString;
            dataSet = new DataSet();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlDataAdapter = new SqlDataAdapter(textBox1.Text, sqlConnection);
                dataGridView1.DataSource = null;
                sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Fill(dataSet, "myTable");
                dataGridView1.DataSource = dataSet.Tables["myTable"];    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            sqlDataAdapter.Update(dataSet, "myTable");
        }
    }
}
