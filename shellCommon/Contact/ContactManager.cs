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
                loadContact(Tag as ContactData);
            }

            loadDefaultPhoneTypesValues();
        }

        // Loads the PhoneTypes on the combos
        private void loadPhoneTypes()
        {
            var phoneTypesList = new CommonFactory().getPhoneTypeList().PhoneTypeList;
            cmbPhoneTypeA.Properties.Items.AddRange(phoneTypesList);
            cmbPhoneTypeB.Properties.Items.AddRange(phoneTypesList);
            cmbPhoneTypeC.Properties.Items.AddRange(phoneTypesList);
        }

        private void loadDefaultPhoneTypesValues()
        {
            cmbPhoneTypeA.SelectedItem = cmbPhoneTypeA.SelectedItem ?? cmbPhoneTypeA.Properties.Items[0];
            cmbPhoneTypeB.SelectedItem = cmbPhoneTypeB.SelectedItem ?? cmbPhoneTypeA.Properties.Items[1];
            cmbPhoneTypeC.SelectedItem = cmbPhoneTypeC.SelectedItem ?? cmbPhoneTypeA.Properties.Items[2];
        }

        // Loads the Contact on the form
        private void loadContact(ContactData contactData)
        {
            txtName.Text = contactData.Person.Name;
            txtLastName.Text = contactData.Person.LastName;
            txtJob.Text = contactData.Job;
            txtEmail.Text = contactData.Email;

            if (contactData.Person.PhoneList != null)
            {
                if (contactData.Person.PhoneList.Count > 0)
                {
                    txtPhoneA.Text = contactData.Person.PhoneList[0].PhoneNumber;
                    cmbPhoneTypeA.SelectedItem = contactData.Person.PhoneList[0].PhoneType;
                    if (contactData.Person.PhoneList.Count > 1)
                    {
                        txtPhoneB.Text = contactData.Person.PhoneList[1].PhoneNumber;
                        cmbPhoneTypeB.SelectedItem = contactData.Person.PhoneList[1].PhoneType;
                        if (contactData.Person.PhoneList.Count > 2)
                        {
                            txtPhoneC.Text = contactData.Person.PhoneList[2].PhoneNumber;
                            cmbPhoneTypeC.SelectedItem = contactData.Person.PhoneList[2].PhoneType;
                        }
                    }
                } 
            }
        }
        
        #endregion

        #region Save Process
        private ContactData captureContact()
        {
            if (Tag == null)
            {
                Tag = new ContactData() { Person = new PersonData() };
            }
            var ContactTag = Tag as ContactData;
            ContactTag.Person.Name = txtName.Text;
            ContactTag.Person.LastName = txtLastName.Text;
            ContactTag.Job = txtJob.Text;
            ContactTag.Email = txtEmail.Text;
            ContactTag.Person.PhoneList = ContactTag.Person.PhoneList ?? new List<PhoneData>();
            // Phone A
            if (txtPhoneA.Text != null || txtPhoneA.Text != string.Empty)
            {
                PhoneData tmpPhone = new PhoneData();
                if (ContactTag.Person.PhoneList.Count > 0)
                {
                    tmpPhone = ContactTag.Person.PhoneList[0];
                }
                else
                {
                    ContactTag.Person.PhoneList.Add(tmpPhone);
                }
                tmpPhone.PhoneNumber = txtPhoneA.Text;
                tmpPhone.PhoneType = cmbPhoneTypeA.SelectedItem as PhoneTypeData;                
            }
            // Phone B
            if (txtPhoneB.Text != null || txtPhoneB.Text != string.Empty)
            {
                PhoneData tmpPhone = new PhoneData();
                if (ContactTag.Person.PhoneList.Count > 1)
                {
                    tmpPhone = ContactTag.Person.PhoneList[1];
                }
                else
                {
                    ContactTag.Person.PhoneList.Add(tmpPhone);
                }
                tmpPhone.PhoneNumber = txtPhoneB.Text;
                tmpPhone.PhoneType = cmbPhoneTypeB.SelectedItem as PhoneTypeData;
            }
            // Phone C
            if (txtPhoneC.Text != null || txtPhoneC.Text != string.Empty)
            {
                PhoneData tmpPhone = new PhoneData();
                if (ContactTag.Person.PhoneList.Count > 2)
                {
                    tmpPhone = ContactTag.Person.PhoneList[2];
                }
                else
                {
                    ContactTag.Person.PhoneList.Add(tmpPhone);
                }
                tmpPhone.PhoneNumber = txtPhoneC.Text;
                tmpPhone.PhoneType = cmbPhoneTypeC.SelectedItem as PhoneTypeData;
            }
            return ContactTag;
        }

        private void saveContact()
        {
            var request = new CustomerRequest();
            request.Contact = Tag as ContactData;
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
    }
}