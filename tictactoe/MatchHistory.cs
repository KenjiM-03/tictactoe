using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class MatchHistory : Form
    {
        public MatchHistory()
        {
            InitializeComponent();
            LoadMatchHistory();
        }
        private void LoadMatchHistory()
        {
            string connectionString = "Your_Connection_String"; // Replace with your actual connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Player1, Player2, Winner, MatchDate FROM MatchHistory"; // Adjust the table and column names as per your database schema

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                //dataGridView1.DataSource = dataTable;
            }
        }
    }
}
