namespace Fitness_M
{
    partial class FitnessEquipmentSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FitnessEquipmentSchedule));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmFqTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRunningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCountBalls = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmFreeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDateToFreeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtVisit = new System.Windows.Forms.DateTimePicker();
            this.btnPrintBusyFitnessEq = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtVisit, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintBusyFitnessEq, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 622);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.splitContainer1, 4);
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 36);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(806, 582);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFqTitle,
            this.clmRunningTime,
            this.clmCountBalls});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(806, 375);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmFqTitle
            // 
            this.clmFqTitle.DataPropertyName = "Title";
            this.clmFqTitle.HeaderText = "Название тренажера";
            this.clmFqTitle.Name = "clmFqTitle";
            this.clmFqTitle.ReadOnly = true;
            this.clmFqTitle.Width = 150;
            // 
            // clmRunningTime
            // 
            this.clmRunningTime.DataPropertyName = "RunningTime";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmRunningTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.clmRunningTime.HeaderText = "Время тренировки(мин.)";
            this.clmRunningTime.Name = "clmRunningTime";
            this.clmRunningTime.ReadOnly = true;
            this.clmRunningTime.Width = 160;
            // 
            // clmCountBalls
            // 
            this.clmCountBalls.DataPropertyName = "CountBalls";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.clmCountBalls.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCountBalls.HeaderText = "Колличество баллов";
            this.clmCountBalls.Name = "clmCountBalls";
            this.clmCountBalls.ReadOnly = true;
            this.clmCountBalls.Width = 150;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmFreeTime,
            this.clmDateToFreeTime});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(806, 202);
            this.dataGridView2.TabIndex = 0;
            // 
            // clmFreeTime
            // 
            this.clmFreeTime.DataPropertyName = "DateFrom";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "t";
            dataGridViewCellStyle3.NullValue = null;
            this.clmFreeTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmFreeTime.HeaderText = "Свободно \"С\"";
            this.clmFreeTime.Name = "clmFreeTime";
            this.clmFreeTime.ReadOnly = true;
            this.clmFreeTime.Width = 150;
            // 
            // clmDateToFreeTime
            // 
            this.clmDateToFreeTime.DataPropertyName = "DateTo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "t";
            this.clmDateToFreeTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmDateToFreeTime.HeaderText = "Свободно \"ПО\"";
            this.clmDateToFreeTime.Name = "clmDateToFreeTime";
            this.clmDateToFreeTime.ReadOnly = true;
            this.clmDateToFreeTime.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Загруженность тренажеров на:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtVisit
            // 
            this.dtVisit.Location = new System.Drawing.Point(248, 4);
            this.dtVisit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtVisit.Name = "dtVisit";
            this.dtVisit.Size = new System.Drawing.Size(173, 22);
            this.dtVisit.TabIndex = 2;
            this.dtVisit.ValueChanged += new System.EventHandler(this.OnValueChanged);
            // 
            // btnPrintBusyFitnessEq
            // 
            this.btnPrintBusyFitnessEq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrintBusyFitnessEq.FlatAppearance.BorderSize = 0;
            this.btnPrintBusyFitnessEq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintBusyFitnessEq.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintBusyFitnessEq.ImageIndex = 0;
            this.btnPrintBusyFitnessEq.ImageList = this.imageList1;
            this.btnPrintBusyFitnessEq.Location = new System.Drawing.Point(462, 2);
            this.btnPrintBusyFitnessEq.Margin = new System.Windows.Forms.Padding(35, 2, 3, 2);
            this.btnPrintBusyFitnessEq.Name = "btnPrintBusyFitnessEq";
            this.btnPrintBusyFitnessEq.Size = new System.Drawing.Size(94, 28);
            this.btnPrintBusyFitnessEq.TabIndex = 3;
            this.btnPrintBusyFitnessEq.Text = "Печать...";
            this.btnPrintBusyFitnessEq.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintBusyFitnessEq.UseVisualStyleBackColor = true;
            this.btnPrintBusyFitnessEq.Click += new System.EventHandler(this.OnClickBtnPrint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "print_printer_6543.png");
            // 
            // FitnessEquipmentSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FitnessEquipmentSchedule";
            this.Size = new System.Drawing.Size(813, 622);
            this.Load += new System.EventHandler(this.FitnessEquipmentSchedule_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFqTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRunningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCountBalls;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFreeTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDateToFreeTime;
        private System.Windows.Forms.Button btnPrintBusyFitnessEq;
        private System.Windows.Forms.ImageList imageList1;

    }
}
