namespace Fitness_M
{
    partial class VisualDetailScheduleEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualDetailScheduleEditForm));
            this.visualDetailSchedule1 = new Fitness_M.VisualDetailSchedule();
            this.SuspendLayout();
            // 
            // visualDetailSchedule1
            // 
            this.visualDetailSchedule1.DateVisit = new System.DateTime(2014, 4, 22, 20, 55, 20, 278);
            this.visualDetailSchedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visualDetailSchedule1.ListFitnessEquipment = null;
            this.visualDetailSchedule1.Location = new System.Drawing.Point(0, 0);
            this.visualDetailSchedule1.Name = "visualDetailSchedule1";
            this.visualDetailSchedule1.Size = new System.Drawing.Size(821, 428);
            this.visualDetailSchedule1.TabIndex = 0;
            this.visualDetailSchedule1.TimeFrom = System.TimeSpan.Parse("20:55:20.2785972");
            this.visualDetailSchedule1.TimeTo = System.TimeSpan.Parse("20:55:20.2785972");
            this.visualDetailSchedule1.ToUseControl = Fitness_M.UseControl.AsRegim;
            // 
            // VisualDetailScheduleEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 428);
            this.Controls.Add(this.visualDetailSchedule1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 370);
            this.Name = "VisualDetailScheduleEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "График занятости тренажеров";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VisualDetailSchedule visualDetailSchedule1;

    }
}