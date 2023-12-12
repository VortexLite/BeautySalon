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
    public partial class DellMasters : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellMasters()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = DellMastersCombo.Text;
            string[] words = combotxt.Split(' ');
            string id = words[0];

            if (DellMastersCombo.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellMasters", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                DellMastersCombo.Items.Remove(DellMastersCombo.SelectedItem);
                MessageBox.Show("Майстра звільнено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у звільнені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DellMasters_Load(object sender, EventArgs e)
        {
            DellMastersCombo.Items.Clear();
            var cmd = new SqlCommand("SELECT ID_Masters, Surname_Masters, Name_Masters\r\nFROM Masters", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string surname = reader.GetString(1);
                string name = reader.GetString(2);
                string comboBoxItem = $"{id} {surname} {name}";
                DellMastersCombo.Items.Add(comboBoxItem);
            }
            reader.Close();
        }
    }
}
