using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using Hades.session;


namespace MainFrame.Shell
{
    public partial class LoginHandler : Form
    {
        private int _Retries = 1;

        #region Constructor

        /// <summary>
        /// Contructor
        /// </summary>
        public LoginHandler()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Events

        // Closing Action
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Accion que ocurre al presionar la X, esta te saca del todo el sistema
        // dado que no es una opcion valida salirse
        private void handleLoginMini_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
     
        // Accept Action
        private void btnOk_Click(object sender, EventArgs e)
        {
            // Check if the User and Password TextBox aren't empty
            if (txtUserName.Text.Length > 0 && txtUserPassword.Text.Length > 0)
            {
                var loginResult = SessionManager.Login(txtUserName.Text, txtUserPassword.Text);               

                if (loginResult)
                {
                    this.DialogResult = DialogResult.OK;                   
                }
                else
                {
                    if (_Retries >= 3)
                    {
                        this.DialogResult = DialogResult.Abort;
                    }
                    else
                    {
                        lblMessage.Text = "El usuario o contraseña incorrectos, favor verificar los datos. \n";
                        lblMessage.Text += _Retries + " de 3 intentos.";
                        lblMessage.ForeColor = Color.DarkRed;
                        _Retries++;
                    }                                       
                }
            }else 
            {
                lblMessage.Text = "El usuario o contraseña no pueden ir en blanco";
                lblMessage.ForeColor = Color.DarkRed;
            }
        }        

        #endregion     

    }
}
