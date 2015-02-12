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
    public partial class TicketDetailsFormEdit : Form
    {
        /// <summary>
        /// Абонемент
        /// </summary>
        public Tickets Ticket { get; set; }

        public static void Show(Tickets ticket)
        {
            var frm = new TicketDetailsFormEdit();
            frm.Ticket = ticket;
            frm.ShowDialog();
        }

        public TicketDetailsFormEdit()
        {
            InitializeComponent();
        }

        private void TicketDetailsFormEdit_Load(object sender, EventArgs e)
        {
            FillFields();
        }

        private void FillFields()
        {
            tbDataFinish.Text = Ticket.DateFinish.ToString("dd.MM.yyyy");
            tbBalance.Text = Ticket.Balance.ToString();
            if (Ticket.Debt > 0)
            {
                tbDebt.Text = Ticket.Debt.ToString();
                tbPayBefore.Text = Ticket.PayBefore.ToString("dd.MM.yyyy");
            }

            tbCountVisit.Text = Ticket.KindTicketsRef.CountVisits.ToString();
            tbPrice.Text = Ticket.KindTicketsRef.Price.ToString();
            cbDisable.Checked = Ticket.KindTicketsRef.IsInactive;
        }
    }
}
