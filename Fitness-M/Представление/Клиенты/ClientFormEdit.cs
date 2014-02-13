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
    public partial class ClientFormEdit : Form
    {
        private Client m_CurrentClient;

        private bool m_IsClosingForm = true;
        
        /// <summary>
        /// Действие
        /// </summary>
        private ActionState m_Action;
        /// <summary>
        /// Действие
        /// </summary>
        public ActionState Action
        {
            get { return m_Action; }
            set { m_Action = value; }
        }

        /// <summary>
        /// Значение заголовка окна
        /// </summary>
        public void SetFormTitle()
        {
            if (Action != null && Action == ActionState.Add)
                Text = "Добавить клиента";
            else if (Action != null && Action == ActionState.Edit)
                Text = "Изменить атрибуты клиента";
            else Text = "Форма редактирования";
        }

        /// <summary>
        /// Запустить форму
        /// </summary>
        public static Form FormShow(ActionState action, Client client)
        {
            if (client == null)
                throw new BussinesException("Не возможно открыть форму, не задан клиент!");

            var frm = new ClientFormEdit();
            frm.Action = action;
            frm.m_CurrentClient = client;
            frm.ShowDialog();
            return frm;
        }

        public ClientFormEdit()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Загрука формы
        /// </summary>
        private void ClientFormEdit_Load(object sender, EventArgs e)
        {
            SetFormTitle();
            BindingClient();
            SetNumberClient();
        }

        /// <summary>
        /// Установить номер клиента
        /// </summary>
        private void SetNumberClient()
        {
            textBox1.Enabled = false;
            if(Action == ActionState.Add)
                textBox1.Text = new ClientManager().GenerateNumber().ToString();
        }

        /// <summary>
        /// Биндинг
        /// </summary>
        private void BindingClient()
        {
            textBox1.DataBindings.Add("Text", m_CurrentClient, "Number");
            textBox2.DataBindings.Add("Text", m_CurrentClient, "Surname");
            textBox3.DataBindings.Add("Text", m_CurrentClient, "Name");
            textBox4.DataBindings.Add("Text", m_CurrentClient, "Lastname");
            dateTimePicker1.Value = m_CurrentClient.DateBirth;
            //dateTimePicker1.DataBindings.Add("Value", m_CurrentClient);
            textBox5.DataBindings.Add("Text", m_CurrentClient, "Phone");
            textBox6.DataBindings.Add("Text", m_CurrentClient, "Address");
            textBox7.DataBindings.Add("Text", m_CurrentClient, "Note");
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if ((DialogResult == DialogResult.OK && m_IsClosingForm) ||
                DialogResult == DialogResult.Cancel)
            {
                if (DialogResult == DialogResult.OK)
                {
                    m_CurrentClient.DateBirth = dateTimePicker1.Value;

                    if (Action == ActionState.Add)
                        m_CurrentClient.Save();
                    else if (Action == ActionState.Edit)
                        m_CurrentClient.Update();
                }
           
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void OnValidating(object sender, CancelEventArgs e)
        {
           ValidationHelper.Validating(sender, e, ref m_IsClosingForm, errorProviderClient);
        }


        
    }
}
