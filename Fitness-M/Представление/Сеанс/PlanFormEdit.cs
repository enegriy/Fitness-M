using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Fitness_M
{
    public partial class PlanFormEdit : Form
    {
        #region Prop
        /// <summary>
        /// Форма просмотра
        /// </summary>
        public bool IsFormView
        {
            get;
            set;
        }

        /// <summary>
        /// Клиент
        /// </summary>
        public Client CurrentClient
        {
            get;
            set;
        }

        /// <summary>
        /// Набор данных
        /// </summary>
        public ClientDataSet DataSet
        {
            get;
            set;
        }

        private TimeSpan m_PeriodTrainingStart;
        private TimeSpan m_PeriodTrainingFinish;

        /// <summary>
        /// Период тренировки с
        /// </summary>
        public TimeSpan PeriodTrainingStart
        {
            get { return m_PeriodTrainingStart; }
        }
        /// <summary>
        /// Период тренировки по
        /// </summary>
        public TimeSpan PeriodTrainingFinish
        {
            get { return m_PeriodTrainingFinish; }
        }

        /// <summary>
        /// Новое посещение
        /// </summary>
        public Visit NewVisit { get; set; }
        #endregion
        /// <summary>
        /// Показать форму редактирования
        /// </summary>
        public static Visit FormShow(ClientDataSet dataSet, Client client)
        {
            if (client == null)
                throw new BussinesException("Бронирование не возможно, выберите клиента!");

            var frm = new PlanFormEdit();
            frm.DataSet = dataSet;
            frm.CurrentClient = client;
            if (frm.ShowDialog() == DialogResult.OK)
                return frm.NewVisit;
            return null;
            
        }

        public static void FormViewVisit(Visit visit)
        {
            var frm = new PlanFormEdit();

            if(visit.VisitFrom != DateTime.MinValue)
            {
                frm.dtDateVisit.Value = visit.VisitFrom;
                frm.tbTimeFrom.Text = visit.VisitFrom.TimeOfDay.ToShortTime();
                frm.tbTimeTo.Text = visit.VisitTo.TimeOfDay.ToShortTime();
            }
            else
            {
                frm.dtDateVisit.Value = visit.PlanFrom;
                frm.tbTimeFrom.Text = visit.PlanFrom.TimeOfDay.ToShortTime();
                frm.tbTimeTo.Text = visit.PlanTo.TimeOfDay.ToShortTime();
            }

            frm.cbGroupVisit.Checked = visit.IsOnlyGroup;

            var feManager = new FitnessEquipmentManager();

            var visitSpec = new List<FitnessEquipmentWillBeReserve>();
            if (visit.ClientUseFitnessEquipmentSpec != null)
            {
                foreach (var clientUseFitEq in visit.ClientUseFitnessEquipmentSpec)
                {
                    var fitWillBeReserve = new FitnessEquipmentWillBeReserve();
                    fitWillBeReserve.FitnessEquipmentReserve = feManager.Get(clientUseFitEq.FitnessEquipmentId);
                    fitWillBeReserve.TimeFrom = clientUseFitEq.TimeFrom;
                    fitWillBeReserve.TimeTo = clientUseFitEq.TimeTo;
                    visitSpec.Add(fitWillBeReserve);
                }
            }
            frm.grid1.AutoGenerateColumns = false;
            frm.grid1.DataSource = new BindingSource(visitSpec,"");

            frm.SetReadOnly();
            frm.IsFormView = true;
            frm.ShowDialog();
        }

        

        public PlanFormEdit()
        {
            InitializeComponent(); 
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            GridHelper.SetGridStyle(grid1);
            if(!IsFormView) InitGrid();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            //Логирование
            if(!IsFormView)
                Logger.WriteLine(string.Format("{0}  {1} - {2}", 
                    System.DateTime.Now, 
                    CurrentClient.FullName, 
                    DialogResult.ToString()));

            try
            {
                if (DialogResult == System.Windows.Forms.DialogResult.OK && !IsFormView)
                {
                    ValidationPlan();

                    if (cbGroupVisit.Checked)
                    {
                        TicketsController.CheckExistGroupVisitTicket(CurrentClient.ListTickets);

                        TimeSpan timeFrom = TimeHelper.CompileDate(tbTimeFrom.Text);
                        TimeSpan timeTo = TimeHelper.CompileDate(tbTimeTo.Text);

                        if (timeFrom > timeTo)
                            throw new BussinesException("Время 'с' не божет быть больше времени 'по'!");

                        Visit newVisit = new Visit();
                        newVisit.ClientId = CurrentClient.Id;
                        newVisit.PlanFrom = dtDateVisit.Value.Date.Add(timeFrom);
                        newVisit.PlanTo = dtDateVisit.Value.Date.Add(timeTo);
                        newVisit.IsDisabled = false;
                        newVisit.IsOnlyGroup = true;

                        TicketsController.DeductGroupVisit(CurrentClient.ListTickets);
                        newVisit.Save();
                        NewVisit = newVisit;
                    }
                    else
                    {
                        IList<ClientUseFitnessEquipment> listUseFitness =
                            new List<ClientUseFitnessEquipment>();

                        var om = new ObjectManager();
                        om.OpenConnection();
                        var tr = om.Connection.BeginTransaction();
                        try
                        {
                            TicketsController.CheckExistBallsTicket(CurrentClient.ListTickets);

                            Visit newVisit = new Visit();
                            newVisit.ClientId = CurrentClient.Id;
                            newVisit.PlanFrom = dtDateVisit.Value.Date.Add(PeriodTrainingStart);
                            newVisit.PlanTo = dtDateVisit.Value.Date.Add(PeriodTrainingFinish);
                            newVisit.IsDisabled = false;
                            newVisit.IsOnlyGroup = false;
                            

                            var source = (BindingSource)grid1.DataSource;
                            int countBalls = 0;
                            foreach (var boundItem in source)
                            {
                                var fitnessEqWillBeReseve = (FitnessEquipmentWillBeReserve)boundItem;

                                FitnessEquipmentController.CheckInterval(
                                    CurrentClient,
                                    fitnessEqWillBeReseve.FitnessEquipmentReserve,
                                    dtDateVisit.Value.Date,
                                    fitnessEqWillBeReseve.TimeFrom);
                                
                                var useFitnessEq = new ClientUseFitnessEquipment();
                                useFitnessEq.FitnessEquipmentId = fitnessEqWillBeReseve.FitnessEquipmentReserve.Id;
                                useFitnessEq.TimeFrom = fitnessEqWillBeReseve.TimeFrom;
                                useFitnessEq.TimeTo = fitnessEqWillBeReseve.TimeTo;
                                countBalls += fitnessEqWillBeReseve.FitnessEquipmentReserve.CountBalls;
                                listUseFitness.Add(useFitnessEq);
                            }

                            TicketsController.DeductBalls(CurrentClient.ListTickets, countBalls);

                            tr.Commit();

                            newVisit.Save();
                            foreach (var clientUse in listUseFitness)
                            {
                                clientUse.VisitId = newVisit.Id;
                                clientUse.Save();
                                DataSet.ListUseFitnessEquipment.Add(clientUse);
                            }

                            NewVisit = newVisit;
                        }
                        catch (Exception exc)
                        {
                            tr.Rollback();
                            throw new BussinesException(exc.Message, exc);
                        }
                        finally
                        {
                            om.CloseConnection();
                        }
                    }
                }
            }
            catch (BussinesException exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }

        private void ValidationPlan()
        {
            if (cbGroupVisit.Checked)
            {
                if (tbTimeFrom.Text == "  :")
                    throw new BussinesException("'Время с' не может быть пустым!");

                if (tbTimeTo.Text == "  :")
                    throw new BussinesException("'Время по' не может быть пустым!");
            }
            else
            {
                var source = (BindingSource)grid1.DataSource;
                if (source.Count == 0)
                    throw new BussinesException("Необходимо выбрать тренажеры!");
            }
        }

        private void InitGrid()
        {
            grid1.AutoGenerateColumns = false;
            var source = new BindingSource(new List<FitnessEquipmentWillBeReserve>(), "");
            grid1.DataSource = source;
        }

        private void btnAddFQ_Click(object sender, EventArgs e)
        {
            var curDate = System.DateTime.Now.Date;
            var visDate = dtDateVisit.Value.Date;

            if (curDate > visDate)
                throw new BussinesException("Нельзя бронировать на дату меньше текущей!");

            try
            {
                var timeFrom = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeFrom);
                var timeTo = ParamsManager.TryGetParamsDateTime(ParamsConstant.WorkTimeTo);

                var listFqWillBeReserve = VisualDetailScheduleEditForm.FormShow(DataSet.ListFitnessEquipment, visDate, timeFrom.TimeOfDay, timeTo.TimeOfDay);
                if (listFqWillBeReserve.Any())
                {
                    foreach (var fitnessWillBeReserve in listFqWillBeReserve)
                    {
                        ((BindingSource)grid1.DataSource).Add(fitnessWillBeReserve);
                        SetPeriodTraining(fitnessWillBeReserve.TimeFrom, fitnessWillBeReserve.TimeTo);
                    }
                }
            }
            catch (BussinesException ex)
            {
                MessageHelper.ShowError(ex.Message);
            }
        }

        private void SetPeriodTraining(TimeSpan timeFrom, TimeSpan timeTo)
        {
            var valTimeFrom = tbTimeFrom.Text.Replace(" ", "").Replace(":", "");
            var valTimeTo = tbTimeTo.Text.Replace(" ", "").Replace(":", "");

            if (timeFrom < m_PeriodTrainingStart || string.IsNullOrEmpty(valTimeFrom))
            {
                m_PeriodTrainingStart = timeFrom;
                tbTimeFrom.Text = timeFrom.ToShortTime();
            }
            if (timeTo > m_PeriodTrainingFinish || string.IsNullOrEmpty(valTimeTo))
            {
                m_PeriodTrainingFinish = timeTo;
                tbTimeTo.Text = timeTo.ToShortTime();
            } 
        }

        private void RecalcPeriodTraining()
        {
            var source = grid1.DataSource as BindingSource;
            if (source.Count == 0)
            {
                tbTimeFrom.Text = "";
                tbTimeTo.Text = "";
            }
            else
            {
                var listSource = (List<FitnessEquipmentWillBeReserve>)source.List;
                m_PeriodTrainingStart = listSource.Where(x => x.TimeFrom == listSource.Min(s => s.TimeFrom)).Select(x => x.TimeFrom).First();
                m_PeriodTrainingFinish = listSource.Where(x => x.TimeTo == listSource.Max(s => s.TimeTo)).Select(x => x.TimeTo).First();
                tbTimeFrom.Text = m_PeriodTrainingStart.ToShortTime();
                tbTimeTo.Text = m_PeriodTrainingFinish.ToShortTime();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var source = (BindingSource) grid1.DataSource;
            if (source.Current == null) return;

            if (MessageHelper.ShowQuestion(
                "Вы уверены что хоитет удалить объект?") == DialogResult.Yes)
            {
                source.RemoveCurrent();
                grid1.Refresh();
                RecalcPeriodTraining();
            }
        }

        private void OnCellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var currObj = (FitnessEquipmentWillBeReserve)grid1.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == 1)
                e.Value = currObj.FitnessEquipmentReserve.Title;
            else if (e.ColumnIndex == 2)
                e.Value = currObj.FitnessEquipmentReserve.CountBalls;
            else if (e.ColumnIndex == 3)
                e.Value = currObj.TimeFrom.ToShortTime();
            else if (e.ColumnIndex == 4)
                e.Value = currObj.TimeTo.ToShortTime();
        }

        private void OnDateVisitChanged(object sender, EventArgs e)
        {
            if (grid1.DataSource != null)
                ((BindingSource)grid1.DataSource).Clear();
            
            tbTimeFrom.Text = "";
            tbTimeTo.Text = "";
        }

        private void SetReadOnly()
        {
            dtDateVisit.Enabled = false;
            btnAddFQ.Enabled = false;
            btnDelete.Enabled = false;
            cbGroupVisit.Enabled = false;
            tbTimeFrom.Enabled = false;
            tbTimeTo.Enabled = false;
        }

        private void OnCheckedChange(object sender, EventArgs e)
        {
            if (cbGroupVisit.Checked)
            {
                groupBox1.Enabled = false;
                tbTimeFrom.Enabled = true;
                tbTimeTo.Enabled = true;
            }
            else
            {
                tbTimeFrom.Enabled = false;
                tbTimeTo.Enabled = false;
                groupBox1.Enabled = true;
            }
        }
        
    }
}
