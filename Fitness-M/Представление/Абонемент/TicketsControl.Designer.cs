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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTickets = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gridAllTickets = new System.Windows.Forms.DataGridView();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateFinish = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbCountBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbCountVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAbPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmClientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageKind = new System.Windows.Forms.TabPage();
            this.gridKindTicket = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOnlyGroup = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmInactive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnInactive = new System.Windows.Forms.Button();
            this.btnActive = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageTickets.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAllTickets)).BeginInit();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 612);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageTickets
            // 
            this.tabPageTickets.Controls.Add(this.tableLayoutPanel1);
            this.tabPageTickets.Location = new System.Drawing.Point(4, 25);
            this.tabPageTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageTickets.Name = "tabPageTickets";
            this.tabPageTickets.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 575);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gridAllTickets
            // 
            this.gridAllTickets.AllowUserToAddRows = false;
            this.gridAllTickets.AllowUserToDeleteRows = false;
            this.gridAllTickets.ColumnHeadersHeight = 30;
            this.gridAllTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumber,
            this.clmDateFinish,
            this.clmBalance,
            this.clmAbCountBalls,
            this.clmAbCountVisits,
            this.clmAbPrice,
            this.clmClientNumber,
            this.clmClientFio,
            this.clmClientPhone});
            this.tableLayoutPanel1.SetColumnSpan(this.gridAllTickets, 2);
            this.gridAllTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAllTickets.Location = new System.Drawing.Point(4, 176);
            this.gridAllTickets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridAllTickets.Name = "gridAllTickets";
            this.gridAllTickets.RowTemplate.Height = 24;
            this.gridAllTickets.Size = new System.Drawing.Size(781, 395);
            this.gridAllTickets.TabIndex = 0;
            // 
            // clmNumber
            // 
            this.clmNumber.DataPropertyName = "TicketId";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmNumber.DefaultCellStyle = dataGridViewCellStyle23;
            this.clmNumber.HeaderText = "Номер";
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 50;
            // 
            // clmDateFinish
            // 
            this.clmDateFinish.DataPropertyName = "DateFinish";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmDateFinish.DefaultCellStyle = dataGridViewCellStyle24;
            this.clmDateFinish.HeaderText = "Дата окончания";
            this.clmDateFinish.Name = "clmDateFinish";
            this.clmDateFinish.ReadOnly = true;
            this.clmDateFinish.Width = 80;
            // 
            // clmBalance
            // 
            this.clmBalance.DataPropertyName = "Balance";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmBalance.DefaultCellStyle = dataGridViewCellStyle25;
            this.clmBalance.HeaderText = "Остаток";
            this.clmBalance.Name = "clmBalance";
            this.clmBalance.ReadOnly = true;
            this.clmBalance.Width = 80;
            // 
            // clmAbCountBalls
            // 
            this.clmAbCountBalls.DataPropertyName = "CountBalls";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbCountBalls.DefaultCellStyle = dataGridViewCellStyle26;
            this.clmAbCountBalls.HeaderText = "Количество баллов";
            this.clmAbCountBalls.Name = "clmAbCountBalls";
            this.clmAbCountBalls.ReadOnly = true;
            // 
            // clmAbCountVisits
            // 
            this.clmAbCountVisits.DataPropertyName = "CountVisits";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbCountVisits.DefaultCellStyle = dataGridViewCellStyle27;
            this.clmAbCountVisits.HeaderText = "Количество посещений";
            this.clmAbCountVisits.Name = "clmAbCountVisits";
            this.clmAbCountVisits.ReadOnly = true;
            this.clmAbCountVisits.Width = 80;
            // 
            // clmAbPrice
            // 
            this.clmAbPrice.DataPropertyName = "Price";
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmAbPrice.DefaultCellStyle = dataGridViewCellStyle28;
            this.clmAbPrice.HeaderText = "Цена";
            this.clmAbPrice.Name = "clmAbPrice";
            this.clmAbPrice.ReadOnly = true;
            this.clmAbPrice.Width = 80;
            // 
            // clmClientNumber
            // 
            this.clmClientNumber.DataPropertyName = "CLientNumber";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmClientNumber.DefaultCellStyle = dataGridViewCellStyle29;
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
            // tabPageKind
            // 
            this.tabPageKind.Controls.Add(this.gridKindTicket);
            this.tabPageKind.Controls.Add(this.panel1);
            this.tabPageKind.Location = new System.Drawing.Point(4, 25);
            this.tabPageKind.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageKind.Name = "tabPageKind";
            this.tabPageKind.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.gridKindTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridKindTicket.Name = "gridKindTicket";
            this.gridKindTicket.RowTemplate.Height = 24;
            this.gridKindTicket.Size = new System.Drawing.Size(789, 538);
            this.gridKindTicket.TabIndex = 1;
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить...";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmPrice.DefaultCellStyle = dataGridViewCellStyle30;
            this.clmPrice.HeaderText = "Цена";
            this.clmPrice.MinimumWidth = 100;
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.ReadOnly = true;
            // 
            // clmPeriod
            // 
            this.clmPeriod.DataPropertyName = "Period";
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmPeriod.DefaultCellStyle = dataGridViewCellStyle31;
            this.clmPeriod.HeaderText = "Период действия(месяц)";
            this.clmPeriod.Name = "clmPeriod";
            this.clmPeriod.ReadOnly = true;
            this.clmPeriod.Width = 198;
            // 
            // clmCountBalls
            // 
            this.clmCountBalls.DataPropertyName = "CountBalls";
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCountBalls.DefaultCellStyle = dataGridViewCellStyle32;
            this.clmCountBalls.HeaderText = "Количество баллов";
            this.clmCountBalls.Name = "clmCountBalls";
            this.clmCountBalls.ReadOnly = true;
            this.clmCountBalls.Width = 162;
            // 
            // clmVisits
            // 
            this.clmVisits.DataPropertyName = "CountVisits";
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmVisits.DefaultCellStyle = dataGridViewCellStyle33;
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
            // btnInactive
            // 
            this.btnInactive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInactive.FlatAppearance.BorderSize = 0;
            this.btnInactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInactive.Location = new System.Drawing.Point(360, 0);
            this.btnInactive.Margin = new System.Windows.Forms.Padding(4);
            this.btnInactive.Name = "btnInactive";
            this.btnInactive.Size = new System.Drawing.Size(138, 37);
            this.btnInactive.TabIndex = 3;
            this.btnInactive.Text = "Недействителен...";
            this.btnInactive.UseVisualStyleBackColor = true;
            this.btnInactive.Click += new System.EventHandler(this.btnInactive_Click);
            // 
            // btnActive
            // 
            this.btnActive.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActive.FlatAppearance.BorderSize = 0;
            this.btnActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActive.Location = new System.Drawing.Point(498, 0);
            this.btnActive.Margin = new System.Windows.Forms.Padding(4);
            this.btnActive.Name = "btnActive";
            this.btnActive.Size = new System.Drawing.Size(136, 37);
            this.btnActive.TabIndex = 4;
            this.btnActive.Text = "Действителен...";
            this.btnActive.UseVisualStyleBackColor = true;
            this.btnActive.Click += new System.EventHandler(this.btnActive_Click);
            // 
            // TicketsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TicketsControl";
            this.Size = new System.Drawing.Size(805, 612);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPageTickets.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAllTickets)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateFinish;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbCountBalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbCountVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmClientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountBalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVisits;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmOnlyGroup;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmInactive;
        private System.Windows.Forms.Button btnInactive;
        private System.Windows.Forms.Button btnActive;

    }
}
