using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M.Представление.Абонемент
{
    public partial class CountVisitEditForm : Form
    {
        /// <summary>
        /// Абонемент
        /// </summary>
        public Tickets Ticket { get; set; }

        public CountVisitEditForm()
        {
            InitializeComponent();
        }

        public static DialogResult FormShow(Tickets ticket)
        {
            var frm = new CountVisitEditForm();
            frm.Ticket = ticket;
            return frm.ShowDialog();
        }

        private void OnForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = 1;
        }

        private void OnForm_Closing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var balance = Ticket.Balance;
                Ticket.Balance = Ticket.Balance + (int)numericUpDown1.Value;

                Ticket.Update();

                Logger.WriteLine(string.Format("{0} - Клиент:[{1}]   [{2} + {3}] => [{4}]",
                    DateTime.Now.ToString("d"),
                    Ticket.ClientRef.FullName,
                    balance,
                    (int)numericUpDown1.Value,
                    Ticket.Balance), "extension");
            }
        }
    }
}
