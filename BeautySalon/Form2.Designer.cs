namespace BeautySalon
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStripView = new System.Windows.Forms.MenuStrip();
            this.ViewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMasters = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewServic = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewChecks = new System.Windows.Forms.ToolStripMenuItem();
            this.CentralText = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.ControlBtn = new System.Windows.Forms.Button();
            this.ReportBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStripView.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.menuStripView);
            this.panel1.Location = new System.Drawing.Point(199, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 514);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(869, 486);
            this.dataGridView1.TabIndex = 3;
            // 
            // menuStripView
            // 
            this.menuStripView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(185)))), ((int)(((byte)(120)))));
            this.menuStripView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewClient,
            this.ViewMasters,
            this.ViewRecord,
            this.ViewServic,
            this.ViewChecks});
            this.menuStripView.Location = new System.Drawing.Point(0, 0);
            this.menuStripView.Name = "menuStripView";
            this.menuStripView.Size = new System.Drawing.Size(869, 28);
            this.menuStripView.TabIndex = 2;
            this.menuStripView.Text = "menuStripView";
            // 
            // ViewClient
            // 
            this.ViewClient.Name = "ViewClient";
            this.ViewClient.Size = new System.Drawing.Size(75, 24);
            this.ViewClient.Text = "Клієнти";
            this.ViewClient.Click += new System.EventHandler(this.ViewClient_Click);
            // 
            // ViewMasters
            // 
            this.ViewMasters.Name = "ViewMasters";
            this.ViewMasters.Size = new System.Drawing.Size(84, 24);
            this.ViewMasters.Text = "Майстри";
            this.ViewMasters.Click += new System.EventHandler(this.ViewMasters_Click);
            // 
            // ViewRecord
            // 
            this.ViewRecord.Name = "ViewRecord";
            this.ViewRecord.Size = new System.Drawing.Size(73, 24);
            this.ViewRecord.Text = "Записи";
            this.ViewRecord.Click += new System.EventHandler(this.ViewRecord_Click);
            // 
            // ViewServic
            // 
            this.ViewServic.Name = "ViewServic";
            this.ViewServic.Size = new System.Drawing.Size(80, 24);
            this.ViewServic.Text = "Послуги";
            this.ViewServic.Click += new System.EventHandler(this.ViewServic_Click);
            // 
            // ViewChecks
            // 
            this.ViewChecks.Name = "ViewChecks";
            this.ViewChecks.Size = new System.Drawing.Size(57, 24);
            this.ViewChecks.Text = "Чеки";
            this.ViewChecks.Click += new System.EventHandler(this.ViewChecks_Click);
            // 
            // CentralText
            // 
            this.CentralText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CentralText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CentralText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CentralText.Location = new System.Drawing.Point(0, -1);
            this.CentralText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CentralText.Name = "CentralText";
            this.CentralText.Size = new System.Drawing.Size(1068, 43);
            this.CentralText.TabIndex = 1;
            this.CentralText.Text = "Перегляд";
            this.CentralText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(88, 28);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.dToolStripMenuItem.Text = "d";
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(191)))), ((int)(((byte)(120)))));
            this.ViewBtn.FlatAppearance.BorderSize = 0;
            this.ViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewBtn.Location = new System.Drawing.Point(5, 206);
            this.ViewBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(185, 37);
            this.ViewBtn.TabIndex = 4;
            this.ViewBtn.Text = "Перегляд";
            this.ViewBtn.UseVisualStyleBackColor = false;
            this.ViewBtn.Click += new System.EventHandler(this.ViewBtn_Click);
            // 
            // ControlBtn
            // 
            this.ControlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(191)))), ((int)(((byte)(120)))));
            this.ControlBtn.FlatAppearance.BorderSize = 0;
            this.ControlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlBtn.Location = new System.Drawing.Point(5, 266);
            this.ControlBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ControlBtn.Name = "ControlBtn";
            this.ControlBtn.Size = new System.Drawing.Size(185, 37);
            this.ControlBtn.TabIndex = 5;
            this.ControlBtn.Text = "Управління";
            this.ControlBtn.UseVisualStyleBackColor = false;
            this.ControlBtn.Click += new System.EventHandler(this.ControlBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(191)))), ((int)(((byte)(120)))));
            this.ReportBtn.FlatAppearance.BorderSize = 0;
            this.ReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBtn.Location = new System.Drawing.Point(5, 326);
            this.ReportBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.Size = new System.Drawing.Size(185, 37);
            this.ReportBtn.TabIndex = 6;
            this.ReportBtn.Text = "Звіти";
            this.ReportBtn.UseVisualStyleBackColor = false;
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(191)))), ((int)(((byte)(120)))));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(5, 502);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(185, 37);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Вихід";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ReportBtn);
            this.Controls.Add(this.ControlBtn);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.CentralText);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripView;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "АРМ Салона краси";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStripView.ResumeLayout(false);
            this.menuStripView.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CentralText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStripView;
        private System.Windows.Forms.ToolStripMenuItem ViewClient;
        private System.Windows.Forms.ToolStripMenuItem ViewMasters;
        private System.Windows.Forms.ToolStripMenuItem ViewRecord;
        private System.Windows.Forms.ToolStripMenuItem ViewServic;
        private System.Windows.Forms.ToolStripMenuItem ViewChecks;
        private System.Windows.Forms.Button ViewBtn;
        private System.Windows.Forms.Button ControlBtn;
        private System.Windows.Forms.Button ReportBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}