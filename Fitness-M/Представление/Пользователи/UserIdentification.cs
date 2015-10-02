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

    	private UserManager m_UserManager;
		/// <summary>
		/// UserManager
		/// </summary>
    	private UserManager PropUserManager
    	{
    		get
    		{
    			if(m_UserManager == null)
					m_UserManager = new UserManager();
    			return m_UserManager;
    		}
    	}

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
			TextBoxAutoComplete.Initializer(tbUserName, PropUserManager.GetUsersName());

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
					string name = tbUserName.Text;
					string pasw = tbUserPasswd.Text;
					int role = cbRole.SelectedIndex;

					PropUserManager.SignUp(name, pasw, role);
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
			if(e.KeyCode == Keys.Escape)
			{
				DialogResult = DialogResult.Cancel;
				Close();
			}
		}
    }

}
