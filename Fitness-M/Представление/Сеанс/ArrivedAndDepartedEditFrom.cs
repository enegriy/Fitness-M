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
    public partial class ArrivedAndDepartedEditFrom : Form
    {
        private static ArrivedAndDepartedEditFrom frm;
        private static bool isShown = false; 
        private Visit[] m_ListVisit;

        public static void FormShow(Visit[] listVisit)
        {
            if (isShown)
                frm.Focus();
            else
            {
                frm = new ArrivedAndDepartedEditFrom();
                frm.m_ListVisit = listVisit;
                frm.ShowDialog();
            }

        }

        public ArrivedAndDepartedEditFrom()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            isShown = true;
            var visit = m_ListVisit.FirstOrDefault();
            if (visit != null)
            {
                var client = visit.ClientRef;
                lblFullName.Text = client.FullName;
                var debt = client.ListTicketsActive.FirstOrDefault(x => x.Debt != 0);
                if (debt != null)
                {
                    lblDebtClient.Text = debt.Debt.ToString();
                    lblPayBefore.Text = debt.PayBefore.ToString("dd.MM.yyyy");
                }
                else
                {
                    lblDebtClient.Text = "";
                    lblPayBefore.Text = "";
                }
            }

            GridHelper.SetGridStyle(gridVisit);

            var source = new BindingSource(m_ListVisit,"");
            gridVisit.DataSource = source;
            source.PositionChanged += PositionChange;
            PositionChange(sender, null);

        }

        public void PositionChange(object sender, EventArgs e)
        {
            var source = (BindingSource)gridVisit.DataSource;
            if (source.Current == null)
            {
                btnOk.Enabled = false;
            }
            else
            {
                btnOk.Enabled = true;
                var visit = (Visit)source.Current;
                if (visit.VisitFrom != DateTime.MinValue && visit.VisitTo != DateTime.MinValue)
                {
                    btnOk.Enabled = false;
                }
                else if (visit.VisitFrom == DateTime.MinValue)
                {
                    btnOk.Text = "Начать сеанс";
                }
                else
                {
                    btnOk.Text = "Закончить сеанс";
                }
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var source = (BindingSource)gridVisit.DataSource;
                var visit = (Visit)source.Current;
                if (visit.VisitFrom == DateTime.MinValue)
                {
                    visit.VisitFrom = DateTime.Now;
                }
                else
                {
                    visit.VisitTo = DateTime.Now;
                }
                visit.Update();
            }
            isShown = false;
        }
    }
}
