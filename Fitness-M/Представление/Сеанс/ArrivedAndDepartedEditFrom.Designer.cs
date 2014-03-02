namespace Fitness_M
{
    partial class ArrivedAndDepartedEditFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArrivedAndDepartedEditFrom));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblPayBefore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDebtClient = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridVisit = new System.Windows.Forms.DataGridView();
            this.clmVisitFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmVisitTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookingFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBookingTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.53527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.46473F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPayBefore, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDebtClient, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDebt, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFullName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gridVisit, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 239);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(259, 205);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(253, 31);
            this.tableLayoutPanel2.TabIndex = 22;
            this.tableLayoutPanel2.TabStop = true;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(129, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 25);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 25);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Начать сеанс";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblPayBefore
            // 
            this.lblPayBefore.AutoSize = true;
            this.lblPayBefore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPayBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPayBefore.Location = new System.Drawing.Point(165, 52);
            this.lblPayBefore.Name = "lblPayBefore";
            this.lblPayBefore.Size = new System.Drawing.Size(347, 26);
            this.lblPayBefore.TabIndex = 5;
            this.lblPayBefore.Text = "Оплатить до";
            this.lblPayBefore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Оплатить до:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDebtClient
            // 
            this.lblDebtClient.AutoSize = true;
            this.lblDebtClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDebtClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDebtClient.Location = new System.Drawing.Point(165, 26);
            this.lblDebtClient.Name = "lblDebtClient";
            this.lblDebtClient.Size = new System.Drawing.Size(347, 26);
            this.lblDebtClient.TabIndex = 3;
            this.lblDebtClient.Text = "Долг";
            this.lblDebtClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDebt.Location = new System.Drawing.Point(3, 26);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(156, 26);
            this.lblDebt.TabIndex = 2;
            this.lblDebt.Text = "Долг:";
            this.lblDebt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFullName.Location = new System.Drawing.Point(165, 0);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(347, 26);
            this.lblFullName.TabIndex = 1;
            this.lblFullName.Text = "ФИО Клиента";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Клиент:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridVisit
            // 
            this.gridVisit.AllowUserToAddRows = false;
            this.gridVisit.AllowUserToDeleteRows = false;
            this.gridVisit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVisit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmVisitFrom,
            this.clmVisitTo,
            this.clmBookingFrom,
            this.clmBookingTo});
            this.tableLayoutPanel1.SetColumnSpan(this.gridVisit, 2);
            this.gridVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVisit.Location = new System.Drawing.Point(3, 81);
            this.gridVisit.Name = "gridVisit";
            this.gridVisit.Size = new System.Drawing.Size(509, 118);
            this.gridVisit.TabIndex = 6;
            // 
            // clmVisitFrom
            // 
            this.clmVisitFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmVisitFrom.DataPropertyName = "VisitFrom";
            this.clmVisitFrom.HeaderText = "Посещение с";
            this.clmVisitFrom.Name = "clmVisitFrom";
            this.clmVisitFrom.ReadOnly = true;
            // 
            // clmVisitTo
            // 
            this.clmVisitTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmVisitTo.DataPropertyName = "VisitTo";
            this.clmVisitTo.HeaderText = "Посещение по";
            this.clmVisitTo.Name = "clmVisitTo";
            this.clmVisitTo.ReadOnly = true;
            // 
            // clmBookingFrom
            // 
            this.clmBookingFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmBookingFrom.DataPropertyName = "PlanFrom";
            this.clmBookingFrom.HeaderText = "Бронь с";
            this.clmBookingFrom.Name = "clmBookingFrom";
            this.clmBookingFrom.ReadOnly = true;
            // 
            // clmBookingTo
            // 
            this.clmBookingTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmBookingTo.DataPropertyName = "PlanTo";
            this.clmBookingTo.HeaderText = "Бронь по";
            this.clmBookingTo.Name = "clmBookingTo";
            this.clmBookingTo.ReadOnly = true;
            // 
            // ArrivedAndDepartedEditFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 239);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ArrivedAndDepartedEditFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посещение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVisit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.Label lblDebtClient;
        private System.Windows.Forms.Label lblPayBefore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridVisit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVisitFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmVisitTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookingFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBookingTo;
    }
}