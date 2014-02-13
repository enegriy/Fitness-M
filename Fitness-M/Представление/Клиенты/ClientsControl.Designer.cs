namespace Fitness_M
{
    partial class ClientsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridClients = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmStartVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFinishVisit = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridVisits = new System.Windows.Forms.DataGridView();
            this.clmVisitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVisitFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVisitTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPlanTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIsDisabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnViewVisit = new System.Windows.Forms.Button();
            this.btnAddPlan = new System.Windows.Forms.Button();
            this.btnDisable = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridTickets = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDebt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPayBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnDebt = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisits)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTickets)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.btnAddClient);
            this.flowLayoutPanel1.Controls.Add(this.btnEditClient);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Controls.Add(this.btnUpdate);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(873, 65);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddClient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddClient.ImageIndex = 2;
            this.btnAddClient.ImageList = this.imageList1;
            this.btnAddClient.Location = new System.Drawing.Point(3, 3);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(94, 55);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Добавить...";
            this.btnAddClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.OnClientAdd_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "deletered_5927.png");
            this.imageList1.Images.SetKeyName(1, "pencil3_1379.png");
            this.imageList1.Images.SetKeyName(2, "users_two_add_48_6492.png");
            this.imageList1.Images.SetKeyName(3, "deletered_3524.ico");
            this.imageList1.Images.SetKeyName(4, "refreshblue_5698.ico");
            // 
            // btnEditClient
            // 
            this.btnEditClient.FlatAppearance.BorderSize = 0;
            this.btnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditClient.ImageIndex = 1;
            this.btnEditClient.ImageList = this.imageList1;
            this.btnEditClient.Location = new System.Drawing.Point(104, 4);
            this.btnEditClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(93, 55);
            this.btnEditClient.TabIndex = 1;
            this.btnEditClient.Text = "Изменить...";
            this.btnEditClient.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.ImageIndex = 3;
            this.btnDelete.ImageList = this.imageList1;
            this.btnDelete.Location = new System.Drawing.Point(204, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 55);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить...";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.ImageIndex = 4;
            this.btnUpdate.ImageList = this.imageList1;
            this.btnUpdate.Location = new System.Drawing.Point(289, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 55);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.textBoxFind);
            this.panel1.Location = new System.Drawing.Point(370, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 46);
            this.panel1.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.ImageIndex = 0;
            this.btnClear.ImageList = this.imageList1;
            this.btnClear.Location = new System.Drawing.Point(143, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(36, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBoxFind
            // 
            this.textBoxFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFind.Location = new System.Drawing.Point(3, 10);
            this.textBoxFind.Multiline = true;
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(134, 29);
            this.textBoxFind.TabIndex = 0;
            this.textBoxFind.TextChanged += new System.EventHandler(this.OnFindChange);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridClients, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(881, 296);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gridClients
            // 
            this.gridClients.AllowUserToAddRows = false;
            this.gridClients.AllowUserToOrderColumns = true;
            this.gridClients.ColumnHeadersHeight = 30;
            this.gridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.clmNumber,
            this.clmSurname,
            this.clmName,
            this.clmLastName,
            this.clmDateBirth,
            this.clmPhone,
            this.clmAddress,
            this.clmNote});
            this.tableLayoutPanel1.SetColumnSpan(this.gridClients, 2);
            this.gridClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClients.Location = new System.Drawing.Point(4, 77);
            this.gridClients.Margin = new System.Windows.Forms.Padding(4);
            this.gridClients.Name = "gridClients";
            this.gridClients.RowTemplate.Height = 24;
            this.gridClients.Size = new System.Drawing.Size(873, 190);
            this.gridClients.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 44;
            // 
            // clmNumber
            // 
            this.clmNumber.DataPropertyName = "Number";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmNumber.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmNumber.Frozen = true;
            this.clmNumber.HeaderText = "Номер";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            // 
            // clmSurname
            // 
            this.clmSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSurname.DataPropertyName = "Surname";
            this.clmSurname.HeaderText = "Фамилия";
            this.clmSurname.Name = "clmSurname";
            this.clmSurname.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmName.DataPropertyName = "Name";
            this.clmName.HeaderText = "Имя";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmLastName
            // 
            this.clmLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmLastName.DataPropertyName = "Lastname";
            this.clmLastName.HeaderText = "Отчество";
            this.clmLastName.Name = "clmLastName";
            this.clmLastName.ReadOnly = true;
            // 
            // clmDateBirth
            // 
            this.clmDateBirth.DataPropertyName = "DateBirth";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.clmDateBirth.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmDateBirth.HeaderText = "Дата рождения";
            this.clmDateBirth.Name = "clmDateBirth";
            this.clmDateBirth.ReadOnly = true;
            this.clmDateBirth.Width = 135;
            // 
            // clmPhone
            // 
            this.clmPhone.DataPropertyName = "Phone";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmPhone.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmPhone.HeaderText = "Телефон";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
            this.clmPhone.Width = 120;
            // 
            // clmAddress
            // 
            this.clmAddress.DataPropertyName = "Address";
            this.clmAddress.HeaderText = "Адрес";
            this.clmAddress.Name = "clmAddress";
            this.clmAddress.ReadOnly = true;
            this.clmAddress.Width = 120;
            // 
            // clmNote
            // 
            this.clmNote.DataPropertyName = "Note";
            this.clmNote.HeaderText = "Примечание";
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            this.clmNote.Width = 120;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmStartVisit,
            this.cmFinishVisit});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(208, 48);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.OnContextMenuOpening);
            // 
            // cmStartVisit
            // 
            this.cmStartVisit.Name = "cmStartVisit";
            this.cmStartVisit.Size = new System.Drawing.Size(207, 22);
            this.cmStartVisit.Text = "Начать посещение...";
            this.cmStartVisit.Click += new System.EventHandler(this.OnStartVisitClick);
            // 
            // cmFinishVisit
            // 
            this.cmFinishVisit.Name = "cmFinishVisit";
            this.cmFinishVisit.Size = new System.Drawing.Size(207, 22);
            this.cmFinishVisit.Text = "Закончить посещение...";
            this.cmFinishVisit.Click += new System.EventHandler(this.OnFinishVisitClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(881, 472);
            this.splitContainer1.SplitterDistance = 296;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(881, 172);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridVisits);
            this.tabPage1.Controls.Add(this.flowLayoutPanel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(873, 146);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сеанс";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridVisits
            // 
            this.gridVisits.AllowUserToAddRows = false;
            this.gridVisits.AllowUserToDeleteRows = false;
            this.gridVisits.BackgroundColor = System.Drawing.Color.White;
            this.gridVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmVisitId,
            this.clmVisitFrom,
            this.clmVisitTo,
            this.clmPlanFrom,
            this.clmPlanTo,
            this.clmIsDisabled});
            this.gridVisits.ContextMenuStrip = this.contextMenu;
            this.gridVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVisits.Location = new System.Drawing.Point(4, 35);
            this.gridVisits.Margin = new System.Windows.Forms.Padding(4);
            this.gridVisits.Name = "gridVisits";
            this.gridVisits.RowHeadersVisible = false;
            this.gridVisits.RowTemplate.Height = 24;
            this.gridVisits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVisits.Size = new System.Drawing.Size(865, 107);
            this.gridVisits.TabIndex = 1;
            this.gridVisits.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnMouseDoubleClick);
            this.gridVisits.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OnCellMouseDown);
            // 
            // clmVisitId
            // 
            this.clmVisitId.DataPropertyName = "Id";
            this.clmVisitId.HeaderText = "Ид";
            this.clmVisitId.Name = "clmVisitId";
            this.clmVisitId.ReadOnly = true;
            this.clmVisitId.Visible = false;
            // 
            // clmVisitFrom
            // 
            this.clmVisitFrom.DataPropertyName = "VisitFrom";
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clmVisitFrom.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmVisitFrom.HeaderText = "Посещение С";
            this.clmVisitFrom.Name = "clmVisitFrom";
            this.clmVisitFrom.ReadOnly = true;
            this.clmVisitFrom.Width = 150;
            // 
            // clmVisitTo
            // 
            this.clmVisitTo.DataPropertyName = "VisitTo";
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clmVisitTo.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmVisitTo.HeaderText = "Посещение ПО";
            this.clmVisitTo.Name = "clmVisitTo";
            this.clmVisitTo.ReadOnly = true;
            this.clmVisitTo.Width = 150;
            // 
            // clmPlanFrom
            // 
            this.clmPlanFrom.DataPropertyName = "PlanFrom";
            this.clmPlanFrom.HeaderText = "Бронь С";
            this.clmPlanFrom.Name = "clmPlanFrom";
            this.clmPlanFrom.ReadOnly = true;
            this.clmPlanFrom.Width = 150;
            // 
            // clmPlanTo
            // 
            this.clmPlanTo.DataPropertyName = "PlanTo";
            this.clmPlanTo.HeaderText = "Бронь ПО";
            this.clmPlanTo.Name = "clmPlanTo";
            this.clmPlanTo.ReadOnly = true;
            this.clmPlanTo.Width = 150;
            // 
            // clmIsDisabled
            // 
            this.clmIsDisabled.DataPropertyName = "IsDisabled";
            this.clmIsDisabled.HeaderText = "Анулирован";
            this.clmIsDisabled.Name = "clmIsDisabled";
            this.clmIsDisabled.ReadOnly = true;
            this.clmIsDisabled.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmIsDisabled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnViewVisit);
            this.flowLayoutPanel3.Controls.Add(this.btnAddPlan);
            this.flowLayoutPanel3.Controls.Add(this.btnDisable);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(865, 31);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // btnViewVisit
            // 
            this.btnViewVisit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnViewVisit.FlatAppearance.BorderSize = 0;
            this.btnViewVisit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewVisit.Location = new System.Drawing.Point(3, 3);
            this.btnViewVisit.Name = "btnViewVisit";
            this.btnViewVisit.Size = new System.Drawing.Size(109, 24);
            this.btnViewVisit.TabIndex = 3;
            this.btnViewVisit.Text = "Просмотреть...";
            this.btnViewVisit.UseVisualStyleBackColor = true;
            this.btnViewVisit.Click += new System.EventHandler(this.OnBtnViewVisitClick);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.FlatAppearance.BorderSize = 0;
            this.btnAddPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlan.Location = new System.Drawing.Point(118, 3);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(75, 24);
            this.btnAddPlan.TabIndex = 1;
            this.btnAddPlan.Text = "Бронь...";
            this.btnAddPlan.UseVisualStyleBackColor = true;
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // btnDisable
            // 
            this.btnDisable.FlatAppearance.BorderSize = 0;
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisable.Location = new System.Drawing.Point(199, 3);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(93, 24);
            this.btnDisable.TabIndex = 2;
            this.btnDisable.Text = "Анулировать...";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.OnBtnDisable);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(873, 146);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Абонемент";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridTickets);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 76);
            this.panel2.TabIndex = 2;
            // 
            // gridTickets
            // 
            this.gridTickets.AllowUserToAddRows = false;
            this.gridTickets.AllowUserToDeleteRows = false;
            this.gridTickets.BackgroundColor = System.Drawing.Color.White;
            this.gridTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmDateFinish,
            this.clmBalance,
            this.clmDebt,
            this.clmPayBefore});
            this.gridTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTickets.Location = new System.Drawing.Point(0, 0);
            this.gridTickets.Margin = new System.Windows.Forms.Padding(4);
            this.gridTickets.Name = "gridTickets";
            this.gridTickets.RowHeadersVisible = false;
            this.gridTickets.RowTemplate.Height = 24;
            this.gridTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTickets.Size = new System.Drawing.Size(868, 76);
            this.gridTickets.TabIndex = 0;
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "Id";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmId.DefaultCellStyle = dataGridViewCellStyle6;
            this.clmId.HeaderText = "Номер";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            // 
            // clmDateFinish
            // 
            this.clmDateFinish.DataPropertyName = "DateFinish";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "d";
            dataGridViewCellStyle7.NullValue = null;
            this.clmDateFinish.DefaultCellStyle = dataGridViewCellStyle7;
            this.clmDateFinish.HeaderText = "Дата окончания";
            this.clmDateFinish.Name = "clmDateFinish";
            this.clmDateFinish.ReadOnly = true;
            this.clmDateFinish.Width = 140;
            // 
            // clmBalance
            // 
            this.clmBalance.DataPropertyName = "Balance";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmBalance.DefaultCellStyle = dataGridViewCellStyle8;
            this.clmBalance.HeaderText = "Остаток";
            this.clmBalance.Name = "clmBalance";
            this.clmBalance.ReadOnly = true;
            this.clmBalance.Width = 140;
            // 
            // clmDebt
            // 
            this.clmDebt.DataPropertyName = "Debt";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle9.Format = "N2";
            dataGridViewCellStyle9.NullValue = null;
            this.clmDebt.DefaultCellStyle = dataGridViewCellStyle9;
            this.clmDebt.HeaderText = "Долг";
            this.clmDebt.Name = "clmDebt";
            this.clmDebt.ReadOnly = true;
            // 
            // clmPayBefore
            // 
            this.clmPayBefore.DataPropertyName = "PayBefore";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle10.Format = "d";
            this.clmPayBefore.DefaultCellStyle = dataGridViewCellStyle10;
            this.clmPayBefore.HeaderText = "Оплатить до";
            this.clmPayBefore.Name = "clmPayBefore";
            this.clmPayBefore.ReadOnly = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNewTicket);
            this.flowLayoutPanel2.Controls.Add(this.btnDebt);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(868, 31);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // btnNewTicket
            // 
            this.btnNewTicket.FlatAppearance.BorderSize = 0;
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.Location = new System.Drawing.Point(4, 4);
            this.btnNewTicket.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(75, 24);
            this.btnNewTicket.TabIndex = 0;
            this.btnNewTicket.Text = "Новый...";
            this.btnNewTicket.UseVisualStyleBackColor = true;
            this.btnNewTicket.Click += new System.EventHandler(this.btnNewTicket_Click);
            // 
            // btnDebt
            // 
            this.btnDebt.FlatAppearance.BorderSize = 0;
            this.btnDebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebt.Location = new System.Drawing.Point(86, 4);
            this.btnDebt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDebt.Name = "btnDebt";
            this.btnDebt.Size = new System.Drawing.Size(75, 24);
            this.btnDebt.TabIndex = 1;
            this.btnDebt.Text = "Долг...";
            this.btnDebt.UseVisualStyleBackColor = true;
            this.btnDebt.Click += new System.EventHandler(this.btnDebt_Click);
            // 
            // ClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientsControl";
            this.Size = new System.Drawing.Size(881, 472);
            this.Load += new System.EventHandler(this.OnClientControlLoad);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClients)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisits)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTickets)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView gridClients;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem cmStartVisit;
        private System.Windows.Forms.ToolStripMenuItem cmFinishVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVisitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVisitFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVisitTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPlanTo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmIsDisabled;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnViewVisit;
        private System.Windows.Forms.Button btnAddPlan;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridTickets;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnNewTicket;
        private System.Windows.Forms.Button btnDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDebt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPayBefore;



    }
}
