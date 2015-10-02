namespace Fitness_M
{
    partial class BrowseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowseForm));
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStrip = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.treeViewRegims = new System.Windows.Forms.TreeView();
			this.panelFormConteiner = new System.Windows.Forms.Panel();
			this.timerForToday = new System.Windows.Forms.Timer(this.components);
			this.statusStrip1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStrip,
            this.lblDate,
            this.lblTime});
			this.statusStrip1.Location = new System.Drawing.Point(0, 566);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new System.Drawing.Size(893, 25);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStrip
			// 
			this.lblStrip.Name = "lblStrip";
			this.lblStrip.Size = new System.Drawing.Size(69, 20);
			this.lblStrip.Text = "Сегодня:";
			// 
			// lblDate
			// 
			this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(0, 20);
			// 
			// lblTime
			// 
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(0, 20);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 267F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.treeViewRegims, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelFormConteiner, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(893, 566);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// treeViewRegims
			// 
			this.treeViewRegims.BackColor = System.Drawing.SystemColors.Info;
			this.treeViewRegims.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewRegims.Location = new System.Drawing.Point(4, 4);
			this.treeViewRegims.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.treeViewRegims.Name = "treeViewRegims";
			this.treeViewRegims.Size = new System.Drawing.Size(259, 558);
			this.treeViewRegims.TabIndex = 0;
			this.treeViewRegims.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OnAfterSelect);
			// 
			// panelFormConteiner
			// 
			this.panelFormConteiner.BackColor = System.Drawing.SystemColors.Control;
			this.panelFormConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelFormConteiner.Location = new System.Drawing.Point(271, 4);
			this.panelFormConteiner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panelFormConteiner.Name = "panelFormConteiner";
			this.panelFormConteiner.Size = new System.Drawing.Size(618, 558);
			this.panelFormConteiner.TabIndex = 1;
			// 
			// timerForToday
			// 
			this.timerForToday.Interval = 1000;
			this.timerForToday.Tick += new System.EventHandler(this.timerForToday_Tick);
			// 
			// BrowseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(893, 591);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "BrowseForm";
			this.Text = "Фитнес-М";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.OnForm_Load);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnForm_Closing);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeViewRegims;
        private System.Windows.Forms.Panel panelFormConteiner;
        private System.Windows.Forms.ToolStripStatusLabel lblStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.Timer timerForToday;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
    }
}

