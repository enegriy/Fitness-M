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
    public partial class DateFinishChangeFormEdit : Form
    {
        /// <summary>
        /// Абонемент
        /// </summary>
        public Tickets Ticket { get; set; }

        public DateFinishChangeFormEdit()
        {
            InitializeComponent();
        }

        public static DialogResult FormShow(Tickets ticket)
        {
            var frm = new DateFinishChangeFormEdit();
            frm.Ticket = ticket;
            return frm.ShowDialog();
        }

        private void OnForm_Load(object sender, EventArgs e)
        {
            dtFinishDate.Value = Ticket.DateFinish;
        }

        private void OnForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var oldDateFinish = Ticket.DateFinish;
                if (dtFinishDate.Value != DateTime.MinValue)
                    Ticket.DateFinish = dtFinishDate.Value;

                Ticket.Update();

                Logger.WriteLine(string.Format("{0} - Клиент:[{1}]   [{2}] => [{3}]", 
                    DateTime.Now.ToString("d"),
                    Ticket.ClientRef.FullName,
                    oldDateFinish.ToString("d"),
                    Ticket.DateFinish.ToString("d")), "extension");
            }
        }
    }
}
