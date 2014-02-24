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
    public partial class ReportFitnessEquipmentBusy : Form
    {
        public DateTime Date { get; set; }
        
        private int countPage = 1;
        private ClientUseFitnessEquipment[] listUseFitEquipment = null;
        private ClientUseFitnessEquipment storeCufe = null;
        bool MustContinue = true;

        public static void ShowReport(DateTime date)
        {
            var frm = new ReportFitnessEquipmentBusy();
            frm.Date = date;
            frm.ShowDialog();
        }

        public void OnFormLoad(object sender, EventArgs e)
        {
            var dataset = ClientDataSet.Get();

            listUseFitEquipment = dataset.ListUseFitnessEquipment
                .Where(x => x.VisitRef.PlanFrom.Date == Date)
                .OrderBy(x => x.FitnessEquipmentRef.Title)
                .ThenBy(x => x.TimeFrom)
                .ToArray();
        }


        public ReportFitnessEquipmentBusy()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Печать
        /// </summary>
        private void OnPrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float fieldSize = 40;

            float textSizeHeader = 12;
            float textSize = 10;
            float space = 8;

            var fontHeader = new Font(FontFamily.GenericSansSerif, textSizeHeader,FontStyle.Bold);
            var fontFitness = new Font(FontFamily.GenericSansSerif, textSize, FontStyle.Bold);
            var fontTime = new Font(FontFamily.GenericSansSerif, textSize);

            var brush = Brushes.Black;

            int line = 1;
            int countLine = 60;

            if (countPage == 1)
            {
                e.Graphics.DrawString("График загруженности тренажеров на " + Date.ToString("dd.MM.yyyy"), fontHeader, brush, fieldSize, textSizeHeader+space);
                line+=2;
            }

            
            int storeFeId = 0;

            foreach (var fe in listUseFitEquipment)
            {
                if (!MustContinue && storeCufe == fe)
                    MustContinue = true;

                if (!MustContinue) continue;

                if (storeFeId != fe.FitnessEquipmentId)
                {
                    if (line > countLine)
                    {
                        e.HasMorePages = true;
                        storeCufe = fe;
                        countPage++;
                        MustContinue = false;
                        break;
                    }

                    e.Graphics.DrawString(fe.FitnessEquipmentRef.Title, fontFitness, brush, fieldSize, line * (textSize + space));
                    line++;
                    storeFeId = fe.FitnessEquipmentId;
                }


                if (line > 62)
                {
                    e.HasMorePages = true;
                    storeCufe = fe;
                    countPage++;
                    MustContinue = false;
                    break;
                }
                e.Graphics.DrawString(
                    string.Format("{0} - {1}   {2}", fe.TimeFrom.ToShortTime(), fe.TimeTo.ToShortTime(), fe.VisitRef.ClientRef.SurName),
                    fontTime, brush, fieldSize, line * (textSize + space));
                line++;
            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnBtnPrint_Click(object sender, EventArgs e)
        {
            printDoc.Print();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.StartPage > 0)
                printPreviewControl1.StartPage -= 1;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (printPreviewControl1.StartPage < countPage)
                printPreviewControl1.StartPage += 1;
        }

    }
}
