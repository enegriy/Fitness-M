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
    public partial class UserIdentification : Form
    {
        private bool m_IsClosingForm = true;

        public static DialogResult ShowUserIdentity()
        {
            var form = new UserIdentification();
            return form.ShowDialog();
        }


        public UserIdentification()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            Focus();
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            Close();
        }


        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                e.Cancel = false;
                return;
            }

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    CheckNameAndPass();
                    SignUp();
                }
                catch (BussinesException ex)
                {
                    MessageHelper.ShowError(ex.Message);
                    e.Cancel = true;
                }
            }
            else
                e.Cancel = true;
        }

        private void SignUp()
        {
            string name = textBox1.Text;
            string pasw = textBox2.Text;
            int role = comboBox1.SelectedIndex;

            var m_Connection =
                new MySql.Data.MySqlClient.MySqlConnection(
                    ProgOptions.mConnectionString);

            if (m_Connection.State != ConnectionState.Open)
                m_Connection.Open();
            
            var cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.Connection = m_Connection;

            string sql = string.Format("select id from users where name = '{0}' and passwd = '{1}' and role_number = {2};", name, pasw, role);
            cmd.CommandText = sql;
            var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                CurrentUser.Id = (int)reader["id"];
                if (role == 1)
                    CurrentUser.Role = Roles.User;
                else
                    CurrentUser.Role = Roles.Administrator;
            }
            else
                throw new BussinesException("Пользователь с такими реквизитами не найден!");

            if (m_Connection.State != System.Data.ConnectionState.Closed)
                m_Connection.Close();

        }


        private void CheckNameAndPass()
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text))
            {
                throw new BussinesException("Заполните имя пользователя и пароль!");
            }

            if (comboBox1.SelectedIndex == 0)
            {
                throw new BussinesException("Выберите роль!");
            }
        }

        private void OnValidating(object sender, CancelEventArgs e)
        {
            ValidationHelper.Validating(sender, e, ref m_IsClosingForm, errorProvider1);
        }

        private void UserIdentification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }

}
