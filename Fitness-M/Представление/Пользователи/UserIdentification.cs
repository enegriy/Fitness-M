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
        private ValidationProvider validationProvider;


        public static DialogResult ShowUserIdentity()
        {
            var form = new UserIdentification();
            return form.ShowDialog();
        }


        public UserIdentification()
        {
            InitializeComponent();

            var acsc = new AutoCompleteStringCollection();
            acsc.Add("Подоля");
            acsc.Add("Админ");

            textBox1.AutoCompleteCustomSource = acsc;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

            validationProvider = new ValidationProvider(errorProvider1);
            
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
        	ValidationInit();
			comboBox1.SelectedIndex = 0;
        }

		private void ValidationInit()
		{
			validationProvider.OnValidationChange += ValidationChange;

			validationProvider.AddValidation(textBox1, typeof(ValidationStrategyNotNull));
			validationProvider.AddValidation(textBox2, typeof(ValidationStrategyNotNull));
			validationProvider.AddValidation(comboBox1, typeof(ValidationStrategyComboBox));

			validationProvider.Validate();
		}

        private void ValidationChange(bool isValid)
        {
			btnOk.Enabled = isValid;
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

            if(e.Cancel)
            {
                validationProvider.OnValidationChange -= ValidationChange;
            }
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

        private void UserIdentification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && validationProvider.IsValid)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void OnTextChange(object sender, EventArgs e)
        {
            validationProvider.Validate(sender as Control);
        }

        private void OnSelectedIndexChange(object sender, EventArgs e)
        {
            validationProvider.Validate(sender as Control);
        }

    }

}
