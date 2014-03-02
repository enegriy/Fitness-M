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
    public partial class DigitalCardEditForm : Form
    {
        /// <summary>
        /// Клиент
        /// </summary>
        private Client m_CurrentClient{get;set;}

        public static void ShowForm(Client client)
        {
            var frm = new DigitalCardEditForm();
            frm.m_CurrentClient = client;
            frm.ShowDialog();
        }

        public DigitalCardEditForm()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            Scaner.ActionWithCode -= ClientController.ActionCodeWasScaned;
            Scaner.ActionWithCode += ActionWithCode;
            timer1.Start();
        }

        public void ActionWithCode(uint code)
        {
            var listClients = ClientDataSet.Get().ListClients.Where(x => x.Code == code).ToArray();
            if (listClients.Any())
            {
                if (MessageHelper.ShowQuestion(
                    string.Format("Эта карта уже назначена клиенту {0}, хотите назначить её и этому клиенту ?", listClients.First().FullName)) == System.Windows.Forms.DialogResult.Yes)
                {
                    m_CurrentClient.Code = code;
                    m_CurrentClient.Update();
                }
            }
            else
            {
                m_CurrentClient.Code = code;
                m_CurrentClient.Update();
            }
            
            Close();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void OnTimer_Tick(object sender, EventArgs e)
        {
            if (label1.Text.Length == 33)
            {
                label1.Text = "Поднесите карту к считывателю ";
            }
            else if (label1.Text.Length == 30)
            {
                label1.Text = "Поднесите карту к считывателю .";
            }
            else if (label1.Text.Length == 31)
            {
                label1.Text = "Поднесите карту к считывателю ..";
            }
            else if (label1.Text.Length == 32)
            {
                label1.Text = "Поднесите карту к считывателю ...";
            }
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Scaner.ActionWithCode -= ActionWithCode;
            timer1.Stop();
            MessageHelper.ShowInfo("Электронная карта присвоенная клиенту!");
            Scaner.ActionWithCode += ClientController.ActionCodeWasScaned;
            
        }

    }
}
