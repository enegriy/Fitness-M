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
    public partial class PlanFormEdit : Form
    {
        public static void FormShow()
        {
            var frm = new PlanFormEdit();
            frm.ShowDialog();
        }

        public PlanFormEdit()
        {
            InitializeComponent();
        }

        private void btnAddFQ_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
