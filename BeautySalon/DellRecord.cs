﻿using System;
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
    public partial class DellRecord : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public DellRecord()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void DellRecord_Load(object sender, EventArgs e)
        {
            DellRecordCombo.Items.Clear();
            var cmd = new SqlCommand("SELECT ID_Record, Surname_Client, Name_Client, Servic.Name_Servic\r\nFROM Record\r\ninner join Client on Client.ID_Client = Record.ID_Client\r\ninner join Servic on Servic.ID_Servic = Record.ID_Servic", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string surname = reader.GetString(1);
                string name = reader.GetString(2);
                string nameServic = reader.GetString(3);
                string comboBoxItem = $"{id} {surname} {name} {nameServic}";
                DellRecordCombo.Items.Add(comboBoxItem);
            }
            reader.Close();
        }

        private void EnterOK_Click(object sender, EventArgs e)
        {
            string combotxt = DellRecordCombo.Text;
            string[] words = combotxt.Split(' ');
            string id = words[0];

            if (DellRecordCombo.SelectedItem != null)
            {
                var cmd = new SqlCommand("DellRecordAndCheck", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                DellRecordCombo.Items.Remove(DellRecordCombo.SelectedItem);
                MessageBox.Show("Запис видалено", "Успіх", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Помилка у видаленні", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
