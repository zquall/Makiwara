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
                    loadCustomer(createCustomerDialog.Tag as CustomerDto);
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

        private void cmbContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxEdit = sender as ComboBoxEdit;
            var contact = comboBoxEdit.SelectedItem as CustomerContactDto;
            loadContact(contact);
        }

        private void btnProjectName_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    loadProjectFinder();
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
                loadBudgetRequest(searchBudgetRequestDialog.Tag as BudgetRequestDto);
            }
        }

        private void loadCustomerFinder()
        {
            var searchCustomerDialog = new CustomerFinder();
            if (searchCustomerDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // load the found client
                loadCustomer(searchCustomerDialog.Tag as CustomerDto);
            }
        }

        private void loadProjectFinder()
        {
            var searchProjectDialog = new SearchProject();
            if (searchProjectDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var project = searchProjectDialog.Tag as ProjectDto;
                if (project != null)
                {
                    btnProjectName.Text = project.Name;
                }
            }
        }
        

        // Loads the BudgetRequest on the form
        private void loadBudgetRequest(BudgetRequestDto budgetRequest)
        {
            lblEmployeeName.Text = budgetRequest.Employee.Person.ToString();
            edtDate.EditValue = budgetRequest.DateModified;
            cmbBubgetRequest.Text = budgetRequest.Id.ToString();
            loadCustomer(budgetRequest.Customer);
        }

        // Load the Customer
        private void loadCustomer(CustomerDto customer)
        {
            if (customer != null)
            {
                btnCustomerName.Tag = customer;
                btnCustomerName.Text = customer.Name;
                lblAddress.Text = customer.Address;
                loadContactList(customer.CustomerContacts);
            }
        }

        // Load the Contact
        private void loadContact(CustomerContactDto contact)
        {
            if (contact != null)
            {
                cmbContact.SelectedItem = contact;
                lblContactJob.Text = contact.Job;
                loadPhoneList(contact.Person.PersonPhones);
            }
            else
            {
                cmbContact.SelectedIndex = -1;
                lblContactJob.Text = string.Empty;
                loadPhoneList(null);
            }
        }

        // Load the Contact List
        private void loadContactList(ICollection<CustomerContactDto> contactList)
        {
            cmbContact.SelectedIndex = -1;
            cmbContact.Properties.Items.Clear();
            foreach (var tmpCustomerContact in contactList)
            {
                cmbContact.Properties.Items.Add(tmpCustomerContact);
            }
            if (contactList.Count > 0)
            {
                cmbContact.SelectedIndex = 0;
            }
        }
        
        // Load the Contact default phone
        private void loadPhoneList(ICollection<PersonPhoneDto> phoneList)
        {
            cmbPhone.SelectedIndex = -1;
            cmbPhone.Properties.Items.Clear();
            if (phoneList != null)
            {
                foreach (var phone in phoneList)
                {
                    cmbPhone.Properties.Items.Add(phone);
                }
                if (phoneList.Count > 0)
                {
                    cmbPhone.SelectedIndex = 0;
                } 
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
            var customer = btnCustomerName.Tag as CustomerDto;
            // Validate if we have an customer selected
            if (customer != null && customer.Id > 0)
            { 
                var newCustomerContact = new CustomerContactDto();
                newCustomerContact.CustomerId = customer.Id;
                contactManager.Tag = newCustomerContact;
                contactManager.ShowDialog();
                if (contactManager.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    cmbContact.Properties.Items.Add(contactManager.Tag);
                    cmbContact.SelectedItem = contactManager.Tag;
                }
            }
        }      

        #endregion


       
       
    }
}