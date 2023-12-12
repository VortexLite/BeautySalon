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
using BeautySalon.Report;

namespace BeautySalon
{
    public partial class Form2 : Form
    {
        private ConnectionDB dbconnection;
        private SqlConnection connection;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private string login;

        public Form2(string login)
        {
            InitializeComponent();
            this.login = login;
            dbconnection = new ConnectionDB();
            connection = dbconnection.GetConnection();
            dataGridView1.Hide();

            if (login != "directors") ReportBtn.Hide();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            bool hasOpenForms = Application.OpenForms.Cast<Form>().Any(form => form.Visible);

            // Якщо немає відкритих форм, закриваємо програму
            if (!hasOpenForms)
            {
                Application.Exit();
            }
        }

        private void ViewMenuStrip()
        {
            ToolStripMenuItem ViewClient = new ToolStripMenuItem("Клієнти");
            ToolStripMenuItem ViewMasters = new ToolStripMenuItem("Майстри");
            ToolStripMenuItem ViewRecord = new ToolStripMenuItem("Записи");
            ToolStripMenuItem ViewServic = new ToolStripMenuItem("Послуги");
            ToolStripMenuItem ViewChecks = new ToolStripMenuItem("Чеки");

            menuStripView.Items.Add(ViewClient);
            menuStripView.Items.Add(ViewMasters);
            menuStripView.Items.Add(ViewRecord);
            menuStripView.Items.Add(ViewServic);
            menuStripView.Items.Add(ViewChecks);

            ViewClient.Click += ViewClient_Click;
            ViewMasters.Click += ViewMasters_Click;
            ViewRecord.Click += ViewRecord_Click;
            ViewServic.Click += ViewServic_Click;
            ViewChecks.Click += ViewChecks_Click;
        }

        private void ViewClient_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Client", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Client");

            dataGridView1.DataSource = dataSet.Tables["Client"];
        }

        private void ViewMasters_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Masters", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Masters");

            dataGridView1.DataSource = dataSet.Tables["Masters"];
        }

        private void ViewRecord_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Record", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Record");

            dataGridView1.DataSource = dataSet.Tables["Record"];
        }

        private void ViewServic_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Servic", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Servic");

            dataGridView1.DataSource = dataSet.Tables["Servic"];
        }

        private void ViewChecks_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.Show();
            dataAdapter = new SqlDataAdapter("SELECT * FROM Checks", connection);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Checks");

            dataGridView1.DataSource = dataSet.Tables["Checks"];
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            CentralText.Text = ViewBtn.Text;

            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Show();

            ViewMenuStrip();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            var auth = new Form1();
            this.Hide();
            auth.ShowDialog();
        }

        private void ControlmenuStrip()
        {
            if (login == "directors")
            {
                ToolStripMenuItem ControlClient = new ToolStripMenuItem("Клієнти");
                ToolStripMenuItem ControlMasters = new ToolStripMenuItem("Майстри");
                ToolStripMenuItem ControlRecord = new ToolStripMenuItem("Записи");

                ToolStripMenuItem AddClient = new ToolStripMenuItem("Додати клієнта");
                ToolStripMenuItem DellClient = new ToolStripMenuItem("Видалити клієнта");
                ToolStripMenuItem AddMasters = new ToolStripMenuItem("Додати майстра");
                ToolStripMenuItem DellMasters = new ToolStripMenuItem("Видалити майстра");
                ToolStripMenuItem AddRecord = new ToolStripMenuItem("Додати запис");
                ToolStripMenuItem DellRecord = new ToolStripMenuItem("Видалити запис");

                ControlClient.DropDownItems.Add(AddClient);
                ControlClient.DropDownItems.Add(DellClient);
                ControlMasters.DropDownItems.Add(AddMasters);
                ControlMasters.DropDownItems.Add(DellMasters);
                ControlRecord.DropDownItems.Add(AddRecord);
                ControlRecord.DropDownItems.Add(DellRecord);

                menuStripView.Items.Add(ControlClient);
                menuStripView.Items.Add(ControlMasters);
                menuStripView.Items.Add(ControlRecord);

                AddClient.Click += AddClient_Click;
                DellClient.Click += DellClient_Click;
                AddMasters.Click += AddMasters_Click;
                DellMasters.Click += DellMasters_Click;
                AddRecord.Click += AddRecord_Click;
                DellRecord.Click += DellRecord_Click;
            }
            else
            {
                ToolStripMenuItem ControlClient = new ToolStripMenuItem("Клієнти");
                ToolStripMenuItem ControlRecord = new ToolStripMenuItem("Записи");

                ToolStripMenuItem AddClient = new ToolStripMenuItem("Додати клієнта");
                ToolStripMenuItem DellClient = new ToolStripMenuItem("Видалити клієнта");
                ToolStripMenuItem AddRecord = new ToolStripMenuItem("Додати запис");
                ToolStripMenuItem DellRecord = new ToolStripMenuItem("Видалити запис");

                ControlClient.DropDownItems.Add(AddClient);
                ControlClient.DropDownItems.Add(DellClient);
                ControlRecord.DropDownItems.Add(AddRecord);
                ControlRecord.DropDownItems.Add(DellRecord);

                menuStripView.Items.Add(ControlClient);
                menuStripView.Items.Add(ControlRecord);

                AddClient.Click += AddClient_Click;
                DellClient.Click += DellClient_Click;
                AddRecord.Click += AddRecord_Click;
                DellRecord.Click += DellRecord_Click;
            }
            
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            var addClient = new AddClient();
            addClient.ShowDialog();
        }

        private void DellClient_Click(object sender, EventArgs e)
        {
            var dellClient = new DellClient();
            dellClient.ShowDialog();
        }

        private void AddMasters_Click(object sender, EventArgs e)
        {
            var addMaster = new AddMasters();
            addMaster.ShowDialog();
        }

        private void DellMasters_Click(object sender, EventArgs e)
        {
            var dellMaster = new DellMasters();
            dellMaster.ShowDialog();
        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            var addRecord = new AddRecord();
            addRecord.ShowDialog();
        }

        private void DellRecord_Click(object sender, EventArgs e)
        {
            var dellRecord = new DellRecord();
            dellRecord.ShowDialog();
        }

        private void ControlBtn_Click(object sender, EventArgs e)
        {
            CentralText.Text = ControlBtn.Text;

            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Hide();

            ControlmenuStrip();
        }

        private void ReportMenuStip()
        {
            ToolStripMenuItem ReportRecord = new ToolStripMenuItem("Звіт по записам до салона краси");
            ToolStripMenuItem ReportChecks = new ToolStripMenuItem("Звіт по виданим чекам");


            menuStripView.Items.Add(ReportRecord);
            menuStripView.Items.Add(ReportChecks);

            ReportRecord.Click += ReportRecord_Click;
            ReportChecks.Click += ReportChecks_Click;
        }

        private void ReportRecord_Click(object sender, EventArgs e)
        {
            var reportRecord = new ReportRec();
            reportRecord.ShowDialog();
        }

        private void ReportChecks_Click(object sender, EventArgs e)
        {
            var reportChecks = new ReportChecks();
            reportChecks.ShowDialog();
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            CentralText.Text = ReportBtn.Text;

            menuStripView.Items.Clear();
            dataGridView1.ClearSelection();
            dataGridView1.Hide();

            ReportMenuStip();
        }
    }
}
