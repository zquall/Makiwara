using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using shellCommon.Contact;
using ReplicantRepository.Response;
using ReplicantRepository.DataTransferObjects;
using ReplicantRepository.Request;
using ReplicantFacility.Factory;

namespace shellCommon.Customer
{
    public partial class CustomerManager : DevExpress.XtraEditors.XtraForm
    {
        public CustomerManager()
        {
            InitializeComponent();
        }

        #region UI Events

        // Start the Save Process
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveCustomer();
        }

        // Close the Manager
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        // Edit selected contact
        private void btnEditContact_Click(object sender, EventArgs e)
        {
           
        }

        // Contact combo actions
        private void cmbContacts_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus:
                    loadContactManagerAdd();
                    break;
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:                  
                    if (cmbContacts.SelectedItem != null)
                    {
                        loadContactManagerEdit(cmbContacts.SelectedItem);
                    }
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
                // Loads new contact in combo
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

        #region Save Process
        private CustomerDto captureCustomer()
        {
            // If tag is null this means that the customer is new
            if (Tag == null)
            {
                Tag = new CustomerDto();
            }

            // Get the instance reference from the tag
            var customerTag = Tag as CustomerDto;
            customerTag.Name = txtCustomerName.Text;
            customerTag.Address = txtCustomerAddress.Text;
            customerTag.AddressOptional = txtCustomerAddressOptional.Text;
            customerTag.Phone = txtCustomerPhone.Text;
            customerTag.Fax = txtCustomerFax.Text;

            // Get the CustomerContacts
            customerTag.CustomerContacts = new List<CustomerContactDto>();
            foreach (CustomerContactDto contact in cmbContacts.Properties.Items)
            {
                customerTag.CustomerContacts.Add(contact);
            }
            return customerTag;
        }

        private void saveCustomer()
        {
            var request = new CustomerRequest();
            request.Customer = captureCustomer();
            var customerTag = Tag as CustomerDto;
            customerTag.Id = new CustomerFactory().saveCustomer(request).Customer.Id;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion


    }
}