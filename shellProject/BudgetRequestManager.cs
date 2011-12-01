using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantRepository.Response;
using ReplicantFacility.Factory;
using shellCommon.Customer;
using shellCommon.Contact;

namespace shellProject
{
    public partial class BudgetRequestManager : DevExpress.XtraEditors.XtraForm
    {        
        public BudgetRequestManager()
        {
            InitializeComponent();
        }

        #region UI Events

        private void RequestBugetCell_Load(object sender, EventArgs e)
        {            
            loadNewRequestBudgetManager();
        }

        private void btnCustomerName_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis)
            {
                // Search Customer Process
                var tmpCustomerName = sender as DevExpress.XtraEditors.ButtonEdit;
                var searchCustomerDialog = new CustomerFinder();
                if (searchCustomerDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // load the found client
                    loadCustomer(searchCustomerDialog.Tag as CustomerData);
                }
            }
            else
            {
                // Add new customer
                var createCustomerDialog = new CustomerManager();
                if (createCustomerDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // load the found client
                    loadCustomer(createCustomerDialog.Tag as CustomerData);
                }
            }            
        } 
       
        #endregion

        #region Load Actions

        // Request an empty BudgetRequest
        private void loadNewRequestBudgetManager()
        {
            loadBudgetRequest(new BudgetRequestFactory().getNewBudgetRequest());
        }

        // Loads the BudgetRequest on the form
        private void loadBudgetRequest(BudgetRequestResponse budgetRequestResponse)
        {
            lblEmployeeName.Text = budgetRequestResponse.EmployeeName;
            edtDate.EditValue = budgetRequestResponse.DateModified;
            loadCustomer(budgetRequestResponse.Customer);
        }

        // Load the Customer
        private void loadCustomer(CustomerData customer)
        {
            if (customer != null)
            {
                btnCustomerName.Tag = customer;
                btnCustomerName.Text = customer.Name;
                lblAddress.Text = customer.Address; 
            }
        }

        // Load the Contact
        private void loadContact(ContactData contact)
        {
            if (contact != null)
            {
                cmbContact.Tag = contact;
                cmbContact.Text = contact.Person.Name + " " + contact.Person.LastName;
                loadPhoneList(contact.Person.PhoneList);
            }
        }

        // Load the Contact deafult phone
        private void loadPhoneList(List<PhoneData> phoneList)
        {
            if (phoneList != null)
            {
                cmbPhone.Properties.Items.Clear();
                cmbPhone.Properties.Items.AddRange(phoneList);
                // Load the first phone as default
                loadPhone(phoneList[0]);            
            }
        }

        // Load the Contact deafult phone
        private void loadPhone(PhoneData phone)
        {
            if (phone != null)
            {
                cmbPhone.Tag = phone;
                cmbPhone.Text = phone.PhoneNumber;
            }
        }

        #endregion

        private void cmbContact_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        // Add new Customer Contact
        private void loadContactManagerAdd()
        {
            var contactManager = new ContactManager();
            contactManager.ShowDialog();
            if (contactManager.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                cmbContact.Properties.Items.Add(contactManager.Tag);
                cmbContact.SelectedItem = contactManager.Tag;
            }
        }

    }
}