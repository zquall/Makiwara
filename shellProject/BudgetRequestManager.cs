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
using ReplicantRepository.DataTransferObjects;
using ReplicantRepository.Request;
using Hades.Session;

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
                loadCustomerFinder();                
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
        
        private void cmbContact_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Plus:
                    loadContactManager();
                    break;
                default:
                    break;
            }
        }

        private void cmbBubgetRequest_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    loadBudgetRequestFinder();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Load Actions

        // Request an empty BudgetRequest
        private void loadNewRequestBudgetManager()
        {
            var request = new BudgetRequestRequest() { EmployeeId = SessionManager.EmployeeId };
            loadBudgetRequest(new BudgetRequestFactory().getNewBudgetRequest(request).BudgetRequest);
        }

        private void loadBudgetRequestFinder()
        {
            // Search BudgetRequest Process
            var searchBudgetRequestDialog = new BudgetRequestFinder();
            if (searchBudgetRequestDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // load the found BudgetResquest
                loadBudgetRequest(searchBudgetRequestDialog.Tag as BudgetRequestData);
            }
        }

        private void loadCustomerFinder()
        {
            var searchCustomerDialog = new CustomerFinder();
            if (searchCustomerDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // load the found client
                loadCustomer(searchCustomerDialog.Tag as CustomerData);
            }
        }

        // Loads the BudgetRequest on the form
        private void loadBudgetRequest(BudgetRequestData budgetRequest)
        {
            lblEmployeeName.Text = budgetRequest.Employee.Person.FullName;
            edtDate.EditValue = budgetRequest.DateModified;
            loadCustomer(budgetRequest.Customer);
        }

        // Load the Customer
        private void loadCustomer(CustomerData customer)
        {
            if (customer != null)
            {
                btnCustomerName.Tag = customer;
                btnCustomerName.Text = customer.Name;
                lblAddress.Text = customer.Address;
                loadContactList(customer.ContactList);
            }
        }

        // Load the Customer
        private void loadContact(ContactData contact)
        {
            if (contact != null)
            {
                cmbContact.SelectedItem = contact;
                lblContactJob.Text = contact.Job;
            }
        }

        // Load the Contact List
        private void loadContactList(List<ContactData> contactList)
        {
            if (contactList.Count > 0)
            {
                cmbContact.Properties.Items.Clear();
                cmbContact.Properties.Items.AddRange(contactList);
                loadContact(contactList[0]);
            }
        }
        
        // Load the Contact default phone
        private void loadPhoneList(List<PhoneData> phoneList)
        {
            if (phoneList != null)
            {
                cmbPhone.Properties.Items.Clear();
                cmbPhone.Properties.Items.AddRange(phoneList);
                cmbPhone.SelectedIndex = 0;
            }
        }

        // Load the Contact default phone
        private void loadPhone(PhoneData phone)
        {
            if (phone != null)
            {
                cmbPhone.Properties.Items.Add(phone);
                cmbPhone.SelectedItem = phone;
            }
        }

        // Load Contact Manager
        private void loadContactManager()
        {
            var contactManager = new ContactManager();
            contactManager.ShowDialog();
            if (contactManager.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                cmbContact.Properties.Items.Add(contactManager.Tag);
                cmbContact.SelectedItem = contactManager.Tag;
            }
        }      

        #endregion

       
       
    }
}