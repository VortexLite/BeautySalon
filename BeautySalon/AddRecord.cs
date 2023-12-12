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
using System.Text.RegularExpressions;

namespace BeautySalon
{
    public partial class AddRecord : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public AddRecord()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            ClientCombo.Items.Clear();
            var cmd = new SqlCommand("SELECT ID_Client, Surname_Client, Name_Client, Phone_Client\r\nFROM Client", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string surname = reader.GetString(1);
                string name = reader.GetString(2);
                string phone = reader.GetString(3);
                string comboBoxItem = $"{id} {surname} {name} {phone}";
                ClientCombo.Items.Add(comboBoxItem);
            }
            reader.Close();

            ServicCombo.Items.Clear();
            cmd = new SqlCommand("SELECT ID_Servic, Name_Servic, Price_Servic\r\nFROM Servic", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string name = reader.GetString(1);
                string price = reader.GetString(2);
                string comboBoxItem = $"{id} {name} {price}";
                ServicCombo.Items.Add(comboBoxItem);
            }
            reader.Close();

            MasterCombo.Items.Clear();
            cmd = new SqlCommand("SELECT ID_Masters, Surname_Masters, Name_Masters\r\nFROM Masters", connection);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string surname = reader.GetString(1);
                string name = reader.GetString(2);
                string comboBoxItem = $"{id} {surname} {name}";
                MasterCombo.Items.Add(comboBoxItem);
            }
            reader.Close();

            DateRecord.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm");
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClientCombo.Text) &&
                !string.IsNullOrEmpty(ServicCombo.Text) &&
                !string.IsNullOrEmpty(MasterCombo.Text) &&
                !string.IsNullOrEmpty(DateRecord.Text))
            {
                string idRecord = "";
                var command = new SqlCommand("SELECT MAX(CAST(ID_Record AS INT)) AS max_id FROM Record", connection);
                try
                {
                    idRecord = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idRecord = "1";
                }

                string combotxt = ClientCombo.Text;
                string[] words = combotxt.Split(' ');

                string idClient = words[0];

                combotxt = ServicCombo.Text;
                words = combotxt.Split(' ');
                
                string idServic = words[0];
                string priceServic = GetNumberFromString(combotxt);

                combotxt = MasterCombo.Text;
                words = combotxt.Split(' ');

                string idMaster = words[0];

                var cmd = new SqlCommand("AddRecord", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Record", idRecord);
                cmd.Parameters.AddWithValue("@ID_Client", idClient);
                cmd.Parameters.AddWithValue("@ID_Servic", idServic);
                cmd.Parameters.AddWithValue("@ID_Masters", idMaster);
                cmd.Parameters.AddWithValue("@Date_Record", DateRecord.Text);

                cmd.ExecuteNonQuery();



                string idChecks = "";
                command = new SqlCommand("SELECT MAX(CAST(ID_Checks AS INT)) AS max_id FROM Checks", connection);
                try
                {
                    idChecks = Convert.ToString(Convert.ToInt32(command.ExecuteScalar().ToString()) + 1);
                }
                catch
                {
                    idChecks = "1";
                }



                cmd = new SqlCommand("AddCheck", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID_Checks", idChecks);
                cmd.Parameters.AddWithValue("@ID_Client", idClient);
                cmd.Parameters.AddWithValue("@ID_Servic", idServic);
                cmd.Parameters.AddWithValue("@ID_Record", idRecord);
                cmd.Parameters.AddWithValue("@Date_Checks", DateRecord.Text);
                cmd.Parameters.AddWithValue("@Final_Price", priceServic);

                cmd.ExecuteNonQuery();


                MessageBox.Show("Запис пройшов успішно", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка у введені даних", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static string GetNumberFromString(string input)
        {
            // Використовуємо регулярний вираз для знаходження числа в кінці рядка
            Match match = Regex.Match(input, @"\d+$");
            if (match.Success)
            {
                return match.Value;
            }

            return "";
        }
    }
}
