﻿using Microsoft.ReportingServices.Diagnostics.Internal;
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
using Microsoft.Reporting.WinForms;

namespace BeautySalon.Report
{
    public partial class ReportRec : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        public ReportRec()
        {
            InitializeComponent();
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
        }

        private void ReportRec_Load(object sender, EventArgs e)
        {

            string quary = $"select * from InfoRecord";

            SqlCommand comand = new SqlCommand(quary, connection);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(comand);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("DataSet1", dataTable);
            reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);

            reportViewer1.RefreshReport();
        }
    }
}
