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

namespace BeautySalon
{
    public partial class AddMasters : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddMasters()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FirstnameMasters.Text) &&
                !string.IsNullOrEmpty(SurnameMasters.Text))
            {
                string idMasters = "";
                var command = new SqlCommand("SELECT MAX(CAST(ID_Masters AS INT)) AS max_id FROM Masters", connection);
                try
                {
                    idMasters = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idMasters = "1";
                }

                var cmd = new SqlCommand("AddMasters", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Masters", idMasters);
                cmd.Parameters.AddWithValue("@Name_Masters", FirstnameMasters.Text);
                cmd.Parameters.AddWithValue("@Surname_Masters", SurnameMasters.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Майстер найнятий", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
