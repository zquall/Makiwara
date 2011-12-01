﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using shellCommon.Contact;
using ReplicantRepository.Response;

namespace shellCommon.Customer
{
    public partial class CustomerManager : DevExpress.XtraEditors.XtraForm
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        #region UI Events

        // Close the Manager
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        // Edit selected contact
        private void btnEditContact_Click(object sender, EventArgs e)
        {
            if (cmbContacts.SelectedItem != null){
                loadContactManagerEdit(cmbContacts.SelectedItem);
            }
        }

        // Contact combo actions
        private void cmbContacts_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus:
                    loadContactManagerAdd();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Load Process

        // Add new Customer Contact
        private void loadContactManagerAdd()
        {
            var contactManager = new ContactManager();
            contactManager.ShowDialog();
            if (contactManager.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                cmbContacts.Properties.Items.Add(contactManager.Tag);
                cmbContacts.SelectedItem = contactManager.Tag;
            }
        }

        // Edit Customer Contact
        private void loadContactManagerEdit(object contact)
        {
            var contactManager = new ContactManager();
            contactManager.Tag = contact;
            contactManager.ShowDialog();
            if (contactManager.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                cmbContacts.Properties.Items.Add(contactManager.Tag);
                cmbContacts.SelectedItem = contactManager.Tag;
            }
        }

        #endregion     
       
    }
}