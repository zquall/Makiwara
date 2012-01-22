﻿using System;
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
            if (customerContact.Id > 0) { 
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
                                txtPhoneA.Tag = personPhone;
                                cmbPhoneTypeA.SelectedItem = personPhone.PhoneType;
                                break;
                            case 1:
                                txtPhoneB.Text = personPhone.Phone;
                                txtPhoneB.Tag = personPhone;
                                cmbPhoneTypeB.SelectedItem = personPhone.PhoneType;
                                break;
                            case 2:
                                txtPhoneC.Text = personPhone.Phone;
                                txtPhoneC.Tag = personPhone;
                                cmbPhoneTypeC.SelectedItem = personPhone.PhoneType;
                                break;
                            default:
                                break;
                        }
                        index++;
                    }             
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
            ContactTag.Person.PersonPhones = new List<PersonPhoneDto>();

            // Phone A
            capturePersonPhone(txtPhoneA, cmbPhoneTypeA, ContactTag.Person.PersonPhones);           
            // Phone B
            capturePersonPhone(txtPhoneB, cmbPhoneTypeB, ContactTag.Person.PersonPhones);
            // Phone C
            capturePersonPhone(txtPhoneC, cmbPhoneTypeC, ContactTag.Person.PersonPhones);
         
            return ContactTag;
        }

        private void capturePersonPhone(TextEdit txtPersonPhone, ComboBoxEdit cmbPhoneType, ICollection<PersonPhoneDto> personPhones)
        {
            var personPhone = txtPersonPhone.Tag as PersonPhoneDto;
            if (txtPersonPhone.Text != null)
            {
                if (personPhone == null)
                {
                    personPhone = new PersonPhoneDto();
                }
                personPhone.Phone = txtPersonPhone.Text;
                var phoneType = cmbPhoneType.SelectedItem as PhoneTypeDto;
                personPhone.PhoneTypeId = phoneType.Id;
                personPhones.Add(personPhone);
            }
        }

        private void saveContact()
        {
            var request = new CustomerRequest();
            request.CustomerContact = captureContact();
            new CustomerFactory().saveContact(request);
            //new CustomerFactory().(request)
        }

        #endregion

        #region UI Events

        private void btnOk_Click(object sender, EventArgs e)
        {          
            // Saves the contact on DB
            saveContact();
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        // Close the Manager
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        
        #endregion              

        

    }
}