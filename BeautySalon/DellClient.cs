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
    public partial class DellClient : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellClient()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = DellClientCombo.Text;
            string[] words = combotxt.Split(' ');
            string id = words[0];

            if (DellClientCombo.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellClient", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                DellClientCombo.Items.Remove(DellClientCombo.SelectedItem);
                MessageBox.Show("Клієнта видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DellClient_Load(object sender, EventArgs e)
        {
            DellClientCombo.Items.Clear();
            var cmd = new SqlCommand("select ID_Client,Surname_Client, Name_Client, Phone_Client\r\nfrom Client", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string surname = reader.GetString(1);
                string name = reader.GetString(2);
                string phone = reader.GetString(3);
                string comboBoxItem = $"{id} {surname} {name} {phone}";
                DellClientCombo.Items.Add(comboBoxItem);
            }
            reader.Close();
        }
    }
}
