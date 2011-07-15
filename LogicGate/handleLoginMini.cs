using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LogicGate.OCR;
using WillyWonka;
using Andzen;

namespace LogicGate
{
    public partial class handleLoginMini : Form
    {
        private UmpaLumpa UL = new UmpaLumpa();
        private User _logedUser = new User();

        #region Constructor

        /// <summary>
        /// Contructor
        /// </summary>
        public handleLoginMini()
        {
            InitializeComponent();
        }

        #endregion

        #region Acciones privadas

        #region Acciones de Cerrado

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Accion que ocurre al presionar la X, esta te saca del todo el sistema
        // dado que no es unaopcion valida salirse
        private void handleLoginMini_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        #endregion       
        int reTry = 0;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Length > 0 && txtUserPassword.Text.Length > 0)
            {
                User tmpUser = new User();
                tmpUser.Name = txtUserName.Text;
                EncDec Koder = new EncDec(EncDec.algorithmType.DES);
                tmpUser.Password = Koder.Encrypt(txtUserPassword.Text);
                _logedUser = searchUser(tmpUser) as User;

                if (_logedUser == null)
                {                  
                    if (reTry >= 3)
                    {
                        this.DialogResult = DialogResult.Abort;
                    }
                    else
                    {
                        reTry++;
                    }
                    lblMessage.Text = "El usuario o contraseña incorrectos, favor verificar los datos. \n";
                    lblMessage.Text += reTry + " de 3 intentos.";
                    lblMessage.ForeColor = Color.DarkRed;
                }
                else
                {
                    Enterprise umbrella = new Enterprise();
                    umbrella.IdEnterprise = _logedUser.LastCompany;
                    umbrella = (Enterprise)UL.Select(umbrella)[0];
                    UL.changeDataBase(umbrella.Name);
                    this.DialogResult = DialogResult.OK;
                }
            }else 
            {
                lblMessage.Text = "El usuario o contraseña no pueden ir en blanco";
                lblMessage.ForeColor = Color.DarkRed;
            }
        }              

        #endregion

        #region Funciones de Login

        // Busca con los datos suministrados por el usuario a ver si hay algo en la base de datos y si no encuentra
        // nada. deberia de permitir la entrada al sistema con todo bloqueado
        private object searchUser(User tmpUser)
        {
            List<object> UserList = UL.Select(tmpUser);
            if (UserList.Count > 0)
            {
                return UserList[0];
            }
            else
            {
                return null;
            }
        }

        #endregion

        public User LogedUser {
            get { return _logedUser; } 
        }

        public UmpaLumpa globalUL
        {
            get { return UL; }
        }
       
    }
}
