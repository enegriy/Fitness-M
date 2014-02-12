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
    public partial class DebtFormEdit : Form
    {
        /// <summary>
        /// Абонемент
        /// </summary>
        public Tickets Ticket{get;set;}

        public static DialogResult FormShow(Tickets ticket)
        {
            var frm = new DebtFormEdit();
            frm.Ticket = ticket;
            return frm.ShowDialog();
        }

        public DebtFormEdit()
        {
            InitializeComponent();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (numDebt.Text == "")
                    Ticket.Debt = 0;
                else
                    Ticket.Debt = numDebt.Value;
                Ticket.PayBefore = dateTimePayBefore.Value;
                Ticket.Update();
            }
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            numDebt.Value = Ticket.Debt;
            dateTimePayBefore.Value = Ticket.PayBefore;
        }
    }
}
