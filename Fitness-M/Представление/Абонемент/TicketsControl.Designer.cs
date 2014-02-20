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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketsControl));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTickets = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridAllTickets = new System.Windows.Forms.DataGridView();
            this.clmClientNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbCountBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbCountVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbClientSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbClientNumber = new System.Windows.Forms.TextBox();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.cbNotExist = new System.Windows.Forms.CheckBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.tabPageKind = new System.Windows.Forms.TabPage();
            this.gridKindTicket = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOnlyGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmInactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnActive = new System.Windows.Forms.Button();
            this.btnInactive = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageTickets.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllTickets)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            this.tabPageKind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKindTicket)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.gridAllTickets, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridAllTickets
            // 
            this.gridAllTickets.AllowUserToAddRows = false;
            this.gridAllTickets.AllowUserToDeleteRows = false;
            this.gridAllTickets.ColumnHeadersHeight = 30;
            this.gridAllTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmClientNumber,
            this.clmClientFio,
            this.clmClientPhone,
            this.clmNumber,
            this.clmDateFinish,
            this.clmBalance,
            this.clmAbCountBalls,
            this.clmAbCountVisits,
            this.clmAbPrice,
            this.clmDebt});
            this.tableLayoutPanel1.SetColumnSpan(this.gridAllTickets, 2);
            this.gridAllTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAllTickets.Location = new System.Drawing.Point(4, 164);
            this.gridAllTickets.Margin = new System.Windows.Forms.Padding(4);
            this.gridAllTickets.Name = "gridAllTickets";
            this.gridAllTickets.RowTemplate.Height = 24;
            this.gridAllTickets.Size = new System.Drawing.Size(781, 407);
            this.gridAllTickets.TabIndex = 0;
            this.gridAllTickets.VirtualMode = true;
            this.gridAllTickets.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.OnCellValueNeed);
            // 
            // clmClientNumber
            // 
            this.clmClientNumber.DataPropertyName = "CLientNumber";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmClientNumber.DefaultCellStyle = dataGridViewCellStyle25;
            this.clmClientNumber.HeaderText = "Клиент-Номер";
            this.clmClientNumber.Name = "clmClientNumber";
            this.clmClientNumber.ReadOnly = true;
            this.clmClientNumber.Width = 110;
            // 
            // clmClientFio
            // 
            this.clmClientFio.DataPropertyName = "FUllName";
            this.clmClientFio.HeaderText = "Клиент-ФИО";
            this.clmClientFio.Name = "clmClientFio";
            this.clmClientFio.ReadOnly = true;
            this.clmClientFio.Width = 210;
            // 
            // clmClientPhone
            // 
            this.clmClientPhone.DataPropertyName = "Phone";
            this.clmClientPhone.HeaderText = "Клиент-Телефон";
            this.clmClientPhone.Name = "clmClientPhone";
            this.clmClientPhone.ReadOnly = true;
            this.clmClientPhone.Width = 130;
            // 
            // clmNumber
            // 
            this.clmNumber.DataPropertyName = "TicketId";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmNumber.DefaultCellStyle = dataGridViewCellStyle26;
            this.clmNumber.HeaderText = "Номер абонемента";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 140;
            // 
            // clmDateFinish
            // 
            this.clmDateFinish.DataPropertyName = "DateFinish";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDateFinish.DefaultCellStyle = dataGridViewCellStyle27;
            this.clmDateFinish.HeaderText = "Дата окончания";
            this.clmDateFinish.Name = "clmDateFinish";
            this.clmDateFinish.ReadOnly = true;
            this.clmDateFinish.Width = 130;
            // 
            // clmBalance
            // 
            this.clmBalance.DataPropertyName = "Balance";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmBalance.DefaultCellStyle = dataGridViewCellStyle28;
            this.clmBalance.HeaderText = "Остаток";
            this.clmBalance.Name = "clmBalance";
            this.clmBalance.ReadOnly = true;
            this.clmBalance.Width = 80;
            // 
            // clmAbCountBalls
            // 
            this.clmAbCountBalls.DataPropertyName = "CountBalls";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbCountBalls.DefaultCellStyle = dataGridViewCellStyle29;
            this.clmAbCountBalls.HeaderText = "Количество баллов";
            this.clmAbCountBalls.Name = "clmAbCountBalls";
            this.clmAbCountBalls.ReadOnly = true;
            this.clmAbCountBalls.Width = 150;
            // 
            // clmAbCountVisits
            // 
            this.clmAbCountVisits.DataPropertyName = "CountVisits";
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbCountVisits.DefaultCellStyle = dataGridViewCellStyle30;
            this.clmAbCountVisits.HeaderText = "Количество посещений";
            this.clmAbCountVisits.Name = "clmAbCountVisits";
            this.clmAbCountVisits.ReadOnly = true;
            this.clmAbCountVisits.Width = 170;
            // 
            // clmAbPrice
            // 
            this.clmAbPrice.DataPropertyName = "Price";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbPrice.DefaultCellStyle = dataGridViewCellStyle31;
            this.clmAbPrice.HeaderText = "Цена";
            this.clmAbPrice.Name = "clmAbPrice";
            this.clmAbPrice.ReadOnly = true;
            this.clmAbPrice.Width = 80;
            // 
            // clmDebt
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmDebt.DefaultCellStyle = dataGridViewCellStyle32;
            this.clmDebt.HeaderText = "Долг";
            this.clmDebt.Name = "clmDebt";
            this.clmDebt.ReadOnly = true;
            this.clmDebt.Width = 80;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(783, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Условия отбора";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 171F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbClientSurname, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbClientNumber, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbPeriod, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.numBalance, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbNotExist, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSelect, 0, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(777, 137);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(705, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "и менее";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(365, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Остаток:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(365, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Абонемент закончится:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbClientSurname
            // 
            this.tbClientSurname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClientSurname.Location = new System.Drawing.Point(174, 34);
            this.tbClientSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientSurname.Name = "tbClientSurname";
            this.tbClientSurname.Size = new System.Drawing.Size(165, 22);
            this.tbClientSurname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия клиента:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер клиента:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbClientNumber
            // 
            this.tbClientNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbClientNumber.Location = new System.Drawing.Point(174, 2);
            this.tbClientNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbClientNumber.Name = "tbClientNumber";
            this.tbClientNumber.Size = new System.Drawing.Size(165, 22);
            this.tbClientNumber.TabIndex = 1;
            // 
            // cbPeriod
            // 
            this.cbPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "",
            "В течении 2 дней",
            "В течении 7 дней",
            "В течении 10 дней",
            "В течении 15 дней"});
            this.cbPeriod.Location = new System.Drawing.Point(541, 2);
            this.cbPeriod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(158, 24);
            this.cbPeriod.TabIndex = 5;
            // 
            // numBalance
            // 
            this.numBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numBalance.Location = new System.Drawing.Point(541, 34);
            this.numBalance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBalance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numBalance.Name = "numBalance";
            this.numBalance.Size = new System.Drawing.Size(158, 22);
            this.numBalance.TabIndex = 7;
            this.numBalance.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cbNotExist
            // 
            this.cbNotExist.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.cbNotExist, 2);
            this.cbNotExist.Location = new System.Drawing.Point(3, 66);
            this.cbNotExist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNotExist.Name = "cbNotExist";
            this.cbNotExist.Size = new System.Drawing.Size(237, 21);
            this.cbNotExist.TabIndex = 8;
            this.cbNotExist.Text = "Нет действующих абонементов";
            this.cbNotExist.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(3, 98);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(165, 30);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Отобрать";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.OnBtnSelect_Click);
            // 
            // tabPageKind
            // 
            this.tabPageKind.Controls.Add(this.gridKindTicket);
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
            // gridKindTicket
            // 
            this.gridKindTicket.AllowUserToAddRows = false;
            this.gridKindTicket.AllowUserToDeleteRows = false;
            this.gridKindTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gridKindTicket.ColumnHeadersHeight = 30;
            this.gridKindTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmPrice,
            this.clmPeriod,
            this.clmCountBalls,
            this.clmVisits,
            this.clmOnlyGroup,
            this.clmInactive});
            this.gridKindTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKindTicket.Location = new System.Drawing.Point(4, 41);
            this.gridKindTicket.Margin = new System.Windows.Forms.Padding(4);
            this.gridKindTicket.Name = "gridKindTicket";
            this.gridKindTicket.RowTemplate.Height = 24;
            this.gridKindTicket.Size = new System.Drawing.Size(789, 538);
            this.gridKindTicket.TabIndex = 1;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "Id";
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Visible = false;
            this.clmId.Width = 44;
            // 
            // clmPrice
            // 
            this.clmPrice.DataPropertyName = "Price";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmPrice.DefaultCellStyle = dataGridViewCellStyle33;
            this.clmPrice.HeaderText = "Цена";
            this.clmPrice.MinimumWidth = 100;
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // clmPeriod
            // 
            this.clmPeriod.DataPropertyName = "Period";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmPeriod.DefaultCellStyle = dataGridViewCellStyle34;
            this.clmPeriod.HeaderText = "Период действия(месяц)";
            this.clmPeriod.Name = "clmPeriod";
            this.clmPeriod.ReadOnly = true;
            this.clmPeriod.Width = 198;
            // 
            // clmCountBalls
            // 
            this.clmCountBalls.DataPropertyName = "CountBalls";
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCountBalls.DefaultCellStyle = dataGridViewCellStyle35;
            this.clmCountBalls.HeaderText = "Количество баллов";
            this.clmCountBalls.Name = "clmCountBalls";
            this.clmCountBalls.ReadOnly = true;
            this.clmCountBalls.Width = 162;
            // 
            // clmVisits
            // 
            this.clmVisits.DataPropertyName = "CountVisits";
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmVisits.DefaultCellStyle = dataGridViewCellStyle36;
            this.clmVisits.HeaderText = "Количество посещений";
            this.clmVisits.Name = "clmVisits";
            this.clmVisits.ReadOnly = true;
            this.clmVisits.Width = 189;
            // 
            // clmOnlyGroup
            // 
            this.clmOnlyGroup.DataPropertyName = "IsOnlyGroup";
            this.clmOnlyGroup.HeaderText = "Только групповые занятия";
            this.clmOnlyGroup.Name = "clmOnlyGroup";
            this.clmOnlyGroup.ReadOnly = true;
            this.clmOnlyGroup.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmOnlyGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmOnlyGroup.Width = 211;
            // 
            // clmInactive
            // 
            this.clmInactive.DataPropertyName = "IsInactive";
            this.clmInactive.HeaderText = "Недействителен";
            this.clmInactive.Name = "clmInactive";
            this.clmInactive.ReadOnly = true;
            this.clmInactive.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmInactive.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmInactive.Width = 143;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnActive);
            this.panel1.Controls.Add(this.btnInactive);
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
            // btnActive
            // 
            this.btnActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Location = new System.Drawing.Point(535, 0);
            this.btnActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(136, 37);
            this.btnActive.TabIndex = 4;
            this.btnActive.Text = "Действителен...";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // btnInactive
            // 
            this.btnInactive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInactive.FlatAppearance.BorderSize = 0;
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Location = new System.Drawing.Point(383, 0);
            this.btnInactive.Margin = new System.Windows.Forms.Padding(4);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(152, 37);
            this.btnInactive.TabIndex = 3;
            this.btnInactive.Text = "Недействителен...";
            this.btnInactive.UseVisualStyleBackColor = true;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.ImageIndex = 0;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(259, 0);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(124, 37);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить...";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.ImageIndex = 1;
            this.btnEdit.ImageList = this.imageList1;
            this.btnEdit.Location = new System.Drawing.Point(131, 0);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(128, 37);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Изменить...";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 2;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить...";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "deletered_3945.png");
            this.imageList1.Images.SetKeyName(1, "edit_9831.png");
            this.imageList1.Images.SetKeyName(2, "edit_add_1624.png");
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
            ((System.ComponentModel.ISupportInitialize)(this.gridAllTickets)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            this.tabPageKind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKindTicket)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTickets;
        private System.Windows.Forms.TabPage tabPageKind;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridKindTicket;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView gridAllTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountBalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVisits;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmOnlyGroup;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmInactive;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.Button btnActive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbClientNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbClientSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.CheckBox cbNotExist;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbCountBalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbCountVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDebt;
        private System.Windows.Forms.ImageList imageList1;

    }
}
