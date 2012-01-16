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
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace shellCommon.Contact
{
    public partial class ContactManager : DevExpress.XtraEditors.XtraForm
    {
        public ContactManager()
        {
            InitializeComponent();
        }

        #region Load Process
        
        // Main Load Event
        private void ContactManager_Load(object sender, EventArgs e)
        {            
            // load the list of phone types
            loadPhoneTypes();
            // Detect if is Edit or New Contact
            if(Tag != null){
                // Must return the contact by Tag, can be saved on DB
                loadContact(Tag as CustomerContactDto);
            }

        }

        // Loads the PhoneTypes on the combos
        private void loadPhoneTypes()
        {
            var phoneTypeList = new CommonFactory().getPhoneTypeList().PhoneTypeList;
            loadPhoneTypeCombo(cmbPhoneTypeA, phoneTypeList, 0);
            loadPhoneTypeCombo(cmbPhoneTypeB, phoneTypeList, 1);
            loadPhoneTypeCombo(cmbPhoneTypeC, phoneTypeList, 2);
        }

        private void loadPhoneTypeCombo(ComboBoxEdit comboBoxEdit, List<PhoneTypeDto> phoneTypeList, int defaultPhoneTypeIndex)
        {
            comboBoxEdit.Properties.Items.Clear();
            comboBoxEdit.Properties.Items.AddRange(phoneTypeList);
            comboBoxEdit.SelectedItem = phoneTypeList[defaultPhoneTypeIndex];
        }

        // Loads the Contact on the form
        private void loadContact(CustomerContactDto customerContact)
        {
            txtName.Text = customerContact.Person.Name;
            txtLastName.Text = customerContact.Person.LastName;
            txtJob.Text = customerContact.Job;
            txtEmail.Text = customerContact.Email;

            if (customerContact.Person.PersonPhones != null)
            {
                int index = 0;
                foreach (var personPhone in customerContact.Person.PersonPhones)
                {
                    switch (index)
                    {
                        case 0:
                            txtPhoneA.Text = personPhone.Phone;
                            cmbPhoneTypeA.SelectedItem = personPhone.PhoneType;
                            break;
                        case 1:
                            txtPhoneB.Text = personPhone.Phone;
                            cmbPhoneTypeB.SelectedItem = personPhone.PhoneType;
                            break;
                        case 2:
                            txtPhoneC.Text = personPhone.Phone;
                            cmbPhoneTypeC.SelectedItem = personPhone.PhoneType;
                            break;
                        default:
                            break;
                    }
                    index++;
                }             
            }
        }
        
        #endregion

        #region Save Process

        private CustomerContactDto captureContact()
        {
            if (Tag == null)
            {
                Tag = new CustomerContactDto();
            }
            var ContactTag = Tag as CustomerContactDto;
            ContactTag.Person = new PersonDto();
            ContactTag.Person.Name = txtName.Text;
            ContactTag.Person.LastName = txtLastName.Text;
            ContactTag.Job = txtJob.Text;
            ContactTag.Email = txtEmail.Text;
            ContactTag.Person.PersonPhones = ContactTag.Person.PersonPhones ?? new List<PersonPhoneDto>();

            int index = 0;
            foreach (var tmpPersonPhone in ContactTag.Person.PersonPhones)
            {
                switch (index)
                {
                    case 0:
                        // Phone A
                        if (txtPhoneA.Text != null || txtPhoneA.Text != string.Empty)
                        {
                            tmpPersonPhone.Phone = txtPhoneA.Text;
                            tmpPersonPhone.PhoneType = cmbPhoneTypeA.SelectedItem as PhoneTypeDto;
                        }
                        break;
                    case 1:
                        // Phone B
                        if (txtPhoneB.Text != null || txtPhoneB.Text != string.Empty)
                        {
                            tmpPersonPhone.Phone = txtPhoneB.Text;
                            tmpPersonPhone.PhoneType = cmbPhoneTypeB.SelectedItem as PhoneTypeDto;
                        }
                        break;
                    case 2:
                        // Phone A
                        if (txtPhoneC.Text != null || txtPhoneC.Text != string.Empty)
                        {
                            tmpPersonPhone.Phone = txtPhoneC.Text;
                            tmpPersonPhone.PhoneType = cmbPhoneTypeC.SelectedItem as PhoneTypeDto;
                        }
                        break;
                    default:
                        break;
                }
                index++;
            }   
            return ContactTag;
        }

        private void saveContact()
        {
            var request = new CustomerRequest();
            request.Contact = captureContact();
            new CustomerFactory().saveContact(request);
        }

        #endregion

        #region UI Events

        private void btnOk_Click(object sender, EventArgs e)
        {
            // When the user click OK, Check if this contact has the Id that means that the 
            // contact must be saved on DB before close the dialog
            // Save the changes of the contact

            // Check Edit contact
            if (captureContact().Id != 0)
            {
                // Saves the contact on DB
                saveContact();
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        // Close the Manager
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
        #endregion              

        private void cmbPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBoxEdit = sender as ComboBoxEdit;
            var phoneType = comboBoxEdit.EditValue as PhoneTypeDto;
            if (phoneType != null){
                comboBoxEdit.Text = phoneType.Name;
            }            
        }

    }
}