namespace Fitness_M
{
    partial class PlanFormEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanFormEdit));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.clmFitnessEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNameFq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountBallsFq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeFq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddFQ = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dtDateVisit = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGroupVisit = new System.Windows.Forms.CheckBox();
            this.tbTimeFrom = new System.Windows.Forms.MaskedTextBox();
            this.tbTimeTo = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtDateVisit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbGroupVisit, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTimeFrom, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbTimeTo, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 322);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOk, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(436, 280);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(337, 38);
            this.tableLayoutPanel2.TabIndex = 21;
            this.tableLayoutPanel2.TabStop = true;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(172, 4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(4, 4);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(160, 30);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 5);
            this.groupBox1.Controls.Add(this.grid1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(769, 199);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тренажеры";
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.BackgroundColor = System.Drawing.Color.White;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFitnessEquipment,
            this.clmNameFq,
            this.clmCountBallsFq,
            this.clmTimeFq,
            this.clmTimeTo});
            this.grid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid1.Location = new System.Drawing.Point(4, 58);
            this.grid1.Margin = new System.Windows.Forms.Padding(4);
            this.grid1.Name = "grid1";
            this.grid1.RowHeadersVisible = false;
            this.grid1.RowTemplate.Height = 24;
            this.grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid1.Size = new System.Drawing.Size(761, 137);
            this.grid1.TabIndex = 1;
            this.grid1.VirtualMode = true;
            this.grid1.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.OnCellValueNeeded);
            // 
            // clmFitnessEquipment
            // 
            this.clmFitnessEquipment.DataPropertyName = "FitnessEquipmentReserve";
            this.clmFitnessEquipment.HeaderText = "Тренажер";
            this.clmFitnessEquipment.Name = "clmFitnessEquipment";
            this.clmFitnessEquipment.ReadOnly = true;
            this.clmFitnessEquipment.Visible = false;
            // 
            // clmNameFq
            // 
            this.clmNameFq.HeaderText = "Название";
            this.clmNameFq.Name = "clmNameFq";
            this.clmNameFq.ReadOnly = true;
            this.clmNameFq.Width = 200;
            // 
            // clmCountBallsFq
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCountBallsFq.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmCountBallsFq.HeaderText = "Колличество баллов";
            this.clmCountBallsFq.Name = "clmCountBallsFq";
            this.clmCountBallsFq.ReadOnly = true;
            this.clmCountBallsFq.Width = 140;
            // 
            // clmTimeFq
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = null;
            this.clmTimeFq.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmTimeFq.HeaderText = "Время c";
            this.clmTimeFq.Name = "clmTimeFq";
            this.clmTimeFq.ReadOnly = true;
            // 
            // clmTimeTo
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmTimeTo.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmTimeTo.HeaderText = "Время по";
            this.clmTimeTo.Name = "clmTimeTo";
            this.clmTimeTo.ReadOnly = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAddFQ);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 20);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(761, 38);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAddFQ
            // 
            this.btnAddFQ.FlatAppearance.BorderSize = 0;
            this.btnAddFQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFQ.Location = new System.Drawing.Point(4, 4);
            this.btnAddFQ.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFQ.Name = "btnAddFQ";
            this.btnAddFQ.Size = new System.Drawing.Size(109, 30);
            this.btnAddFQ.TabIndex = 0;
            this.btnAddFQ.Text = "Добавить...";
            this.btnAddFQ.UseVisualStyleBackColor = true;
            this.btnAddFQ.Click += new System.EventHandler(this.btnAddFQ_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(121, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Удалить...";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dtDateVisit
            // 
            this.dtDateVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDateVisit.Location = new System.Drawing.Point(191, 4);
            this.dtDateVisit.Margin = new System.Windows.Forms.Padding(4);
            this.dtDateVisit.Name = "dtDateVisit";
            this.dtDateVisit.Size = new System.Drawing.Size(179, 22);
            this.dtDateVisit.TabIndex = 22;
            this.dtDateVisit.ValueChanged += new System.EventHandler(this.OnDateVisitChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Время с:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(405, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 37);
            this.label3.TabIndex = 24;
            this.label3.Text = "Время по:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbGroupVisit
            // 
            this.cbGroupVisit.AutoSize = true;
            this.cbGroupVisit.Location = new System.Drawing.Point(405, 4);
            this.cbGroupVisit.Margin = new System.Windows.Forms.Padding(4);
            this.cbGroupVisit.Name = "cbGroupVisit";
            this.cbGroupVisit.Size = new System.Drawing.Size(158, 21);
            this.cbGroupVisit.TabIndex = 27;
            this.cbGroupVisit.Text = "Групповое занятие";
            this.cbGroupVisit.UseVisualStyleBackColor = true;
            this.cbGroupVisit.CheckedChanged += new System.EventHandler(this.OnCheckedChange);
            // 
            // tbTimeFrom
            // 
            this.tbTimeFrom.Enabled = false;
            this.tbTimeFrom.Location = new System.Drawing.Point(191, 36);
            this.tbTimeFrom.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimeFrom.Mask = "00:00";
            this.tbTimeFrom.Name = "tbTimeFrom";
            this.tbTimeFrom.Size = new System.Drawing.Size(92, 22);
            this.tbTimeFrom.TabIndex = 28;
            this.tbTimeFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbTimeFrom.ValidatingType = typeof(System.DateTime);
            // 
            // tbTimeTo
            // 
            this.tbTimeTo.Enabled = false;
            this.tbTimeTo.Location = new System.Drawing.Point(592, 36);
            this.tbTimeTo.Margin = new System.Windows.Forms.Padding(4);
            this.tbTimeTo.Mask = "00:00";
            this.tbTimeTo.Name = "tbTimeTo";
            this.tbTimeTo.Size = new System.Drawing.Size(92, 22);
            this.tbTimeTo.TabIndex = 29;
            this.tbTimeTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PlanFormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(793, 354);
            this.Name = "PlanFormEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Бронировать";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddFQ;
        private System.Windows.Forms.DataGridView grid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dtDateVisit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFitnessEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNameFq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountBallsFq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeFq;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimeTo;
        private System.Windows.Forms.CheckBox cbGroupVisit;
        private System.Windows.Forms.MaskedTextBox tbTimeFrom;
        private System.Windows.Forms.MaskedTextBox tbTimeTo;
    }
}