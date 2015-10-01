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
			validationProvider = new ValidationProvider(errorProvider1);
		}


    	private void OnFormLoad(object sender, EventArgs e)
        {
			var userManager = new UserManager();
			TextBoxAutoComplete.Initializer(tbUserName, userManager.GetUsersName());

        	ValidationInit();
			cbRole.SelectedIndex = 0;
        }


		private void ValidationInit()
		{
			validationProvider.OnValidationChange += OnValidationChange;

			validationProvider.AddValidation(tbUserName, OnItemChange, typeof(ValidationStrategyNotNull));
			validationProvider.AddValidation(tbUserPasswd, OnItemChange, typeof(ValidationStrategyNotNull));
			validationProvider.AddValidation(cbRole, OnItemChange, typeof(ValidationStrategyComboBox));

			validationProvider.Validate();
		}


        private void OnValidationChange(bool isValid)
        {
			btnOk.Enabled = isValid;
        }


		private void OnItemChange(object sender, EventArgs e)
		{
			validationProvider.Validate(sender as Control);
		}


        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
			if (DialogResult == DialogResult.OK)
			{
				try
				{
					SignUp();
					e.Cancel = false;
				}
				catch (BussinesException ex)
				{
					e.Cancel = true;
					MessageHelper.ShowError(ex.Message);
				}

			}
			else if (DialogResult == DialogResult.Cancel)
			{
				e.Cancel = false;
			}

        	if(!e.Cancel)
                validationProvider.OnValidationChange -= OnValidationChange;
        }


		private void UserIdentification_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter && validationProvider.IsValid)
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}


        private void SignUp()
        {
            string name = tbUserName.Text;
            string pasw = tbUserPasswd.Text;
            int role = cbRole.SelectedIndex;

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

    }

}
