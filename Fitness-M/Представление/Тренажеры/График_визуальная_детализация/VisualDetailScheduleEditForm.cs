using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
    public partial class VisualDetailScheduleEditForm : Form
    {
        public VisualDetailScheduleEditForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static Form FormShow(
            IList<FitnessEquipment> listFitnessEq, 
            DateTime dateVisit,
            TimeSpan timeFrom,
            TimeSpan timeTo)
        {
            var frm = new VisualDetailScheduleEditForm();

            frm.visualDetailSchedule1.ListFitnessEquipment = listFitnessEq;
            frm.visualDetailSchedule1.DateVisit = dateVisit;
            frm.visualDetailSchedule1.TimeFrom = timeFrom;
            frm.visualDetailSchedule1.TimeTo = timeTo;
            frm.visualDetailSchedule1.ToUseControl = UseControl.AsDialog;

            frm.ShowDialog();
            return frm;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            visualDetailSchedule1.btnClose.Click += btnClose_Click;
        }

        public void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
