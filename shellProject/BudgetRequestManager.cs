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
using DevExpress.XtraGrid.Views.Base;

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
            loadMeasureCombo();
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
      
        private void cmbBubgetRequest_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    LoadBudgetRequestFinder();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveContact();
        }

        private void CmbProductButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Kind)
            {
                case DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis:
                    LoadItemFinder();
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
            loadBudgetRequest(new BudgetRequestFactory().GetNewBudgetRequest(request).BudgetRequest);
        }
    
        // Load Contact Manager
        private void loadContactManager()
        {
            var contactManager = new ContactManager();
            var customerContact = cmbContact.Tag as CustomerContactDto;
            // Validate if we have an customer selected
            if (customerContact != null && customerContact.Id > 0)
            {
                var customer = cmbCustomerName.Tag as CustomerDto;
                customerContact.Customer = customer;
                contactManager.Tag = customerContact;
                contactManager.ShowDialog();
                if (contactManager.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    cmbContact.Properties.Items.Remove(customerContact);
                    cmbContact.Properties.Items.Add(contactManager.Tag);
                    cmbContact.SelectedItem = contactManager.Tag;
                }
            }
            else
            {
                var newCustomerContact = new CustomerContactDto();
                var customer = cmbCustomerName.Tag as CustomerDto;
                newCustomerContact.Customer = customer;
                contactManager.Tag = newCustomerContact;
                contactManager.ShowDialog();
                if (contactManager.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    cmbContact.Properties.Items.Add(contactManager.Tag);
                    cmbContact.SelectedItem = contactManager.Tag;
                }
            }
        }

        private void LoadItemFinder()
        {
            var itemFinder = new ItemFinder();
            itemFinder.ShowDialog();
            if (itemFinder.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var item = itemFinder.Tag as ItemDto;
                if (item != null)
                {
                    gridViewBudgetRequestDetails.EditingValue = item.Name;
                    // gridViewBudgetRequestDetails.SetRowCellValue(gridViewBudgetRequestDetails.FocusedRowHandle, gridViewBudgetRequestDetails.FocusedColumn, item.Name);

                    var currentDetail = gridViewBudgetRequestDetails.GetFocusedRow() as BudgetRequestDetailDto;
                    if (currentDetail != null) currentDetail.Item = item;
                }
            }
        }

        private void LoadBudgetRequestFinder()
        {
            // Search BudgetRequest Process
            var budgetRequestFinder = new BudgetRequestFinder();
            if (budgetRequestFinder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // load the found BudgetResquest
                loadBudgetRequest(budgetRequestFinder.Tag as BudgetRequestDto);
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
                    cmbProjectName.Text = project.Name;
                }
            }
        }        

        // Loads the BudgetRequest on the form
        private void loadBudgetRequest(BudgetRequestDto budgetRequest)
        {
            Tag = budgetRequest;
            lblEmployeeName.Text = budgetRequest.Employee.Person.ToString();
            cmbDate.EditValue = budgetRequest.DateModified;
            cmbBubgetRequest.Text = budgetRequest.Id.ToString();
            cmbProjectName.Text = budgetRequest.ProjectName;
            loadCustomer(budgetRequest.Customer);
            loadBudgetRequestCondition(budgetRequest.BudgetRequestCondition);
            LoadBudgetRequestDetails(budgetRequest.BudgetRequestDetails);
        }

        // Load the Conditions
        private void loadBudgetRequestCondition(BudgetRequestConditionDto budgetRequestCondition)
        {
            if (budgetRequestCondition == null)
            {
                #region CheckBoxes

                chkMonday.Checked = false;
                chkTuesday.Checked = false;
                chkWednesday.Checked = false;
                chkThursday.Checked = false;
                chkFriday.Checked = false;
                chkSaturday.Checked = false;
                chkSunday.Checked = false;

                chkDayTurn.Checked = false;
                chkNightTurn.Checked = false;

                chkDrinkableWater.Checked = false;
                chkElectricity.Checked = false;
                chkWareHouse.Checked = false;

                chkWorkOutside.Checked = false;
                chkWorkInside.Checked = false;
                chkReachable.Checked = false;
                chkVentilation.Checked = false;
                chkToilet.Checked = false;

                chkMoisture.Checked = false;
                chkWet.Checked = false;
                chkNoise.Checked = false;
                chkDust.Checked = false;

                chkFood.Checked = false;
                chkLodging.Checked = false;

                #endregion

                #region Spinners and TextBox

                spnPeriod.Value = budgetRequestCondition.Period;
                spnWarranty.Value = budgetRequestCondition.Warranty;
                spnSafetyCourse.Value = budgetRequestCondition.SafetyCourse;
                spnMaximunHeight.Value = budgetRequestCondition.MaximunHeight;
                cmbStartDate.DateTime = budgetRequestCondition.StartDate;
                txtObservations.Text = budgetRequestCondition.Observations;

                #endregion
            }
            else
            {
                #region CheckBoxes

                chkMonday.Checked = budgetRequestCondition.Monday;
                chkTuesday.Checked = budgetRequestCondition.Tuesday;
                chkWednesday.Checked = budgetRequestCondition.Wednesday;
                chkThursday.Checked = budgetRequestCondition.Thursday;
                chkFriday.Checked = budgetRequestCondition.Friday;
                chkSaturday.Checked = budgetRequestCondition.Saturday;
                chkSunday.Checked = budgetRequestCondition.Sunday;

                chkDayTurn.Checked = budgetRequestCondition.DayTurn;
                chkNightTurn.Checked = budgetRequestCondition.NightTurn;

                chkDrinkableWater.Checked = budgetRequestCondition.DrinkableWater;
                chkElectricity.Checked = budgetRequestCondition.Electricity;
                chkWareHouse.Checked = budgetRequestCondition.Warehouse;

                chkWorkOutside.Checked = budgetRequestCondition.WorkOutside;
                chkWorkInside.Checked = budgetRequestCondition.WorkInside;
                chkReachable.Checked = budgetRequestCondition.Reachable;
                chkVentilation.Checked = budgetRequestCondition.Ventilation;
                chkToilet.Checked = budgetRequestCondition.Toilet;

                chkMoisture.Checked = budgetRequestCondition.Moisture;
                chkWet.Checked = budgetRequestCondition.Wet;
                chkNoise.Checked = budgetRequestCondition.Noise;
                chkDust.Checked = budgetRequestCondition.Dust;

                chkFood.Checked = budgetRequestCondition.Food;
                chkLodging.Checked = budgetRequestCondition.Lodging;

                #endregion

                #region Spinners and TextBox

                spnPeriod.Value = budgetRequestCondition.Period;
                spnWarranty.Value = budgetRequestCondition.Warranty;
                spnSafetyCourse.Value = budgetRequestCondition.SafetyCourse;
                spnMaximunHeight.Value = budgetRequestCondition.MaximunHeight;
                cmbStartDate.DateTime = budgetRequestCondition.StartDate;
                txtObservations.Text = budgetRequestCondition.Observations;

                #endregion
            }
        }

        // Load the Customer
        private void loadCustomer(CustomerDto customer)
        {
            cmbCustomerName.Text = "";
            lblAddress.Text = "";
            loadContactList(null);
            if (customer != null)
            {
                cmbCustomerName.Tag = customer;
                cmbCustomerName.Text = customer.Name;
                lblAddress.Text = customer.Address;
                loadContactList(customer.CustomerContacts);
            }
        }

        // Load the Contact
        private void loadContact(CustomerContactDto contact)
        {
            cmbContact.Tag = contact;
            lblContactJob.Text = string.Empty;
            loadPhoneList(null);
            if (contact != null)
            {
                lblContactJob.Text = contact.Job;
                loadPhoneList(contact.Person.PersonPhones);                
            }
        }

        // Load the Measures in Grid Combo
        private void loadMeasureCombo()
        {
            cmbMeasure.Items.AddRange(new CommonFactory().GetMeasureList().MeasureList);
        }

        // Load the Details on Grid
        private void LoadBudgetRequestDetails(ICollection<BudgetRequestDetailDto> budgetRequestDetails)
        {
            var budgetRequestDetailList = new List<BudgetRequestDetailDto>(budgetRequestDetails);
            GrdBudgetRequestDetails.DataSource = new BindingList<BudgetRequestDetailDto>(budgetRequestDetailList);
        }

        // Load the Contact List
        private void loadContactList(ICollection<CustomerContactDto> contactList)
        {
            cmbContact.SelectedIndex = -1;
            cmbContact.Properties.Items.Clear();
            if (contactList != null)
            {
                BudgetRequestDto BudgetRequest = Tag as BudgetRequestDto;
                foreach (var tmpCustomerContact in contactList)
                {
                    cmbContact.Properties.Items.Add(tmpCustomerContact);
                    if (tmpCustomerContact.Id == BudgetRequest.CustomerContactId) {
                        cmbContact.SelectedItem = tmpCustomerContact;
                    }
                }
            }            
        }
        
        // Load the Contact default phone
        private void loadPhoneList(ICollection<PersonPhoneDto> phoneList)
        {
            cmbPhone.SelectedIndex = -1;
            cmbPhone.Properties.Items.Clear();
            if (phoneList != null)
            {
                BudgetRequestDto BudgetRequest = Tag as BudgetRequestDto;
                foreach (var tmpPhone in phoneList)
                {
                    cmbPhone.Properties.Items.Add(tmpPhone);
                    if (tmpPhone.Id == BudgetRequest.PersonPhoneId)
                    {
                        cmbPhone.SelectedItem = tmpPhone;
                    }
                }               
            }
        }             


        #endregion

        #region Save Process

        private BudgetRequestDto captureBudgetRequest()
        {
            var BudgetRequestTag = Tag as BudgetRequestDto;
            if (BudgetRequestTag.BudgetRequestCondition == null)
            {
                BudgetRequestTag.BudgetRequestCondition = new BudgetRequestConditionDto();

            }
            var customer = cmbCustomerName.Tag as CustomerDto;
            var customerContact = cmbContact.SelectedItem as CustomerContactDto;
            var personPhone = cmbPhone.SelectedItem as PersonPhoneDto;
            BudgetRequestTag.CustomerId = customer.Id;
            BudgetRequestTag.EmployeeId = SessionManager.EmployeeId;
            BudgetRequestTag.CustomerContactId = customerContact.Id;
            BudgetRequestTag.PersonPhoneId = personPhone.Id;
            BudgetRequestTag.ProjectName = cmbProjectName.Text;
            BudgetRequestTag.DateModified = cmbDate.DateTime;

            // Budget Request Details
            BudgetRequestTag.BudgetRequestDetails = (BindingList < BudgetRequestDetailDto >)GrdBudgetRequestDetails.DataSource;

            // Conditions

            BudgetRequestTag.BudgetRequestCondition.Monday = chkMonday.Checked;
            BudgetRequestTag.BudgetRequestCondition.Tuesday = chkTuesday.Checked;
            BudgetRequestTag.BudgetRequestCondition.Wednesday = chkWednesday.Checked;
            BudgetRequestTag.BudgetRequestCondition.Thursday = chkThursday.Checked;
            BudgetRequestTag.BudgetRequestCondition.Friday = chkFriday.Checked;
            BudgetRequestTag.BudgetRequestCondition.Saturday = chkSaturday.Checked;
            BudgetRequestTag.BudgetRequestCondition.Sunday = chkSunday.Checked;
            BudgetRequestTag.BudgetRequestCondition.DayTurn = chkDayTurn.Checked;
            BudgetRequestTag.BudgetRequestCondition.NightTurn = chkNightTurn.Checked;
            BudgetRequestTag.BudgetRequestCondition.DrinkableWater = chkDrinkableWater.Checked;
            BudgetRequestTag.BudgetRequestCondition.Electricity = chkElectricity.Checked;
            BudgetRequestTag.BudgetRequestCondition.Warehouse = chkWareHouse.Checked;
            BudgetRequestTag.BudgetRequestCondition.WorkInside = chkWorkInside.Checked;
            BudgetRequestTag.BudgetRequestCondition.WorkOutside = chkWorkOutside.Checked;
            BudgetRequestTag.BudgetRequestCondition.Reachable = chkReachable.Checked;
            BudgetRequestTag.BudgetRequestCondition.Ventilation = chkVentilation.Checked;
            BudgetRequestTag.BudgetRequestCondition.Toilet = chkToilet.Checked;
            BudgetRequestTag.BudgetRequestCondition.Moisture = chkMoisture.Checked;
            BudgetRequestTag.BudgetRequestCondition.Wet = chkWet.Checked;
            BudgetRequestTag.BudgetRequestCondition.Noise = chkNoise.Checked;
            BudgetRequestTag.BudgetRequestCondition.Dust = chkDust.Checked;
            BudgetRequestTag.BudgetRequestCondition.Food = chkFood.Checked;
            BudgetRequestTag.BudgetRequestCondition.Lodging = chkLodging.Checked;

            // Periods and Times
            BudgetRequestTag.BudgetRequestCondition.Period = spnPeriod.Value;
            BudgetRequestTag.BudgetRequestCondition.Warranty = spnWarranty.Value;
            BudgetRequestTag.BudgetRequestCondition.SafetyCourse = spnSafetyCourse.Value;
            BudgetRequestTag.BudgetRequestCondition.MaximunHeight = spnMaximunHeight.Value;
            BudgetRequestTag.BudgetRequestCondition.StartDate = cmbStartDate.DateTime;
            BudgetRequestTag.BudgetRequestCondition.Observations = txtObservations.Text;

            return BudgetRequestTag;
        }

        private void saveContact()
        {
            var request = new BudgetRequestRequest();
            request.BudgetRequest = captureBudgetRequest();
            new BudgetRequestFactory().SaveBudgetRequest(request);
            loadNewRequestBudgetManager();
        }
        #endregion

        private void GridViewBudgetRequestDetailsInitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as ColumnView;
            if (view != null) view.SetRowCellValue(e.RowHandle, view.Columns["Quantity"], 1);
        }
    }
}