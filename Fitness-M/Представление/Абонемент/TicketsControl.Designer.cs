namespace Fitness_M
{
    partial class TicketsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTickets = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPageKind = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOnlyGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmInactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbCountBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbCountVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageTickets.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPageKind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTickets);
            this.tabControl1.Controls.Add(this.tabPageKind);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTickets
            // 
            this.tabPageTickets.Controls.Add(this.tableLayoutPanel1);
            this.tabPageTickets.Location = new System.Drawing.Point(4, 25);
            this.tabPageTickets.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTickets.Name = "tabPageTickets";
            this.tabPageTickets.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTickets.Size = new System.Drawing.Size(797, 583);
            this.tabPageTickets.TabIndex = 0;
            this.tabPageTickets.Text = " Абонементы клиентов ";
            this.tabPageTickets.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumber,
            this.clmDateFinish,
            this.clmBalance,
            this.clmAbCountBalls,
            this.clmAbCountVisits,
            this.clmAbPrice,
            this.clmClientNumber,
            this.clmClientFio,
            this.clmClientPhone});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView2, 2);
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 176);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(781, 395);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPageKind
            // 
            this.tabPageKind.Controls.Add(this.dataGridView1);
            this.tabPageKind.Controls.Add(this.panel1);
            this.tabPageKind.Location = new System.Drawing.Point(4, 25);
            this.tabPageKind.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageKind.Name = "tabPageKind";
            this.tabPageKind.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageKind.Size = new System.Drawing.Size(797, 583);
            this.tabPageKind.TabIndex = 1;
            this.tabPageKind.Text = " Виды абонементов ";
            this.tabPageKind.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmPrice,
            this.clmPeriod,
            this.clmCountBalls,
            this.clmVisits,
            this.clmOnlyGroup,
            this.clmInactive});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 538);
            this.dataGridView1.TabIndex = 1;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "Id";
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            // 
            // clmPrice
            // 
            this.clmPrice.DataPropertyName = "Price";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmPrice.HeaderText = "Цена";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // clmPeriod
            // 
            this.clmPeriod.DataPropertyName = "Period";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmPeriod.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmPeriod.HeaderText = "Период действия(месяц)";
            this.clmPeriod.Name = "clmPeriod";
            this.clmPeriod.ReadOnly = true;
            this.clmPeriod.Width = 165;
            // 
            // clmCountBalls
            // 
            this.clmCountBalls.DataPropertyName = "CountBalls";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCountBalls.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmCountBalls.HeaderText = "Количество баллов";
            this.clmCountBalls.Name = "clmCountBalls";
            this.clmCountBalls.ReadOnly = true;
            this.clmCountBalls.Width = 130;
            // 
            // clmVisits
            // 
            this.clmVisits.DataPropertyName = "CountVisits";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmVisits.DefaultCellStyle = dataGridViewCellStyle11;
            this.clmVisits.HeaderText = "Количество посещений";
            this.clmVisits.Name = "clmVisits";
            this.clmVisits.ReadOnly = true;
            this.clmVisits.Width = 155;
            // 
            // clmOnlyGroup
            // 
            this.clmOnlyGroup.DataPropertyName = "IsOnlyGroup";
            this.clmOnlyGroup.HeaderText = "Только групповые занятия";
            this.clmOnlyGroup.Name = "clmOnlyGroup";
            this.clmOnlyGroup.ReadOnly = true;
            this.clmOnlyGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmOnlyGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmOnlyGroup.Width = 130;
            // 
            // clmInactive
            // 
            this.clmInactive.DataPropertyName = "IsInactive";
            this.clmInactive.HeaderText = "Недействителен";
            this.clmInactive.Name = "clmInactive";
            this.clmInactive.ReadOnly = true;
            this.clmInactive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmInactive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(240, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(120, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 37);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить...";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить...";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // clmNumber
            // 
            this.clmNumber.DataPropertyName = "TicketId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmNumber.HeaderText = "Номер";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 50;
            // 
            // clmDateFinish
            // 
            this.clmDateFinish.DataPropertyName = "DateFinish";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDateFinish.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmDateFinish.HeaderText = "Дата окончания";
            this.clmDateFinish.Name = "clmDateFinish";
            this.clmDateFinish.ReadOnly = true;
            this.clmDateFinish.Width = 80;
            // 
            // clmBalance
            // 
            this.clmBalance.DataPropertyName = "Balance";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmBalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmBalance.HeaderText = "Остаток";
            this.clmBalance.Name = "clmBalance";
            this.clmBalance.ReadOnly = true;
            this.clmBalance.Width = 80;
            // 
            // clmAbCountBalls
            // 
            this.clmAbCountBalls.DataPropertyName = "CountBalls";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbCountBalls.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmAbCountBalls.HeaderText = "Количество баллов";
            this.clmAbCountBalls.Name = "clmAbCountBalls";
            this.clmAbCountBalls.ReadOnly = true;
            // 
            // clmAbCountVisits
            // 
            this.clmAbCountVisits.DataPropertyName = "CountVisits";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbCountVisits.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmAbCountVisits.HeaderText = "Количество посещений";
            this.clmAbCountVisits.Name = "clmAbCountVisits";
            this.clmAbCountVisits.ReadOnly = true;
            this.clmAbCountVisits.Width = 80;
            // 
            // clmAbPrice
            // 
            this.clmAbPrice.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmAbPrice.HeaderText = "Цена";
            this.clmAbPrice.Name = "clmAbPrice";
            this.clmAbPrice.ReadOnly = true;
            this.clmAbPrice.Width = 80;
            // 
            // clmClientNumber
            // 
            this.clmClientNumber.DataPropertyName = "CLientNumber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmClientNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmClientNumber.HeaderText = "Клиент-Номер";
            this.clmClientNumber.Name = "clmClientNumber";
            this.clmClientNumber.ReadOnly = true;
            this.clmClientNumber.Width = 90;
            // 
            // clmClientFio
            // 
            this.clmClientFio.DataPropertyName = "FUllName";
            this.clmClientFio.HeaderText = "Клиент-ФИО";
            this.clmClientFio.Name = "clmClientFio";
            this.clmClientFio.ReadOnly = true;
            this.clmClientFio.Width = 200;
            // 
            // clmClientPhone
            // 
            this.clmClientPhone.DataPropertyName = "Phone";
            this.clmClientPhone.HeaderText = "Клиент-Телефон";
            this.clmClientPhone.Name = "clmClientPhone";
            this.clmClientPhone.ReadOnly = true;
            // 
            // TicketsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TicketsControl";
            this.Size = new System.Drawing.Size(805, 612);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTickets.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPageKind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTickets;
        private System.Windows.Forms.TabPage tabPageKind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountBalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVisits;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmOnlyGroup;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmInactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbCountBalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbCountVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientPhone;

    }
}
