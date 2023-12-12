using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class AddClient : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddClient()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FirstnameClient.Text) &&
                !string.IsNullOrEmpty(SurnameClient.Text) &&
                !string.IsNullOrEmpty(PhoneClient.Text))
            {
                string idClient = "";
                var command = new SqlCommand("SELECT MAX(CAST(ID_Client AS INT)) AS max_id FROM Client", connection);
                try
                {
                    idClient = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idClient = "1";
                }

                var cmd = new SqlCommand("AddClient", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Client", idClient);
                cmd.Parameters.AddWithValue("@Name_Client", FirstnameClient.Text);
                cmd.Parameters.AddWithValue("@Surname_Client", SurnameClient.Text);
                cmd.Parameters.AddWithValue("@Phone_Client", PhoneClient.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Клієнт доданий", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
