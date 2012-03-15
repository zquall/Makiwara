using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using DevExpress.XtraGrid.Views.Base;

namespace shellCommon.Item
{
    public partial class RentalItemFinder : XtraForm
    {
        public RentalItemFinder()
        {
            InitializeComponent();
        }

        #region UI Events

        private void FinderShown(object sender, EventArgs e)
        {
            Search("");
        }

        private void TxtSearchQueryEditValueChanged(object sender, EventArgs e)
        {
            var tmpTextEdit = sender as TextEdit;
            if (tmpTextEdit != null) Search(tmpTextEdit.Text);
        }

        // Move the focus to the grid when press Down on the search
        private void TxtSearchQueryKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && GrdControlView.FocusedRowHandle >= 0)
            {
                GrdControlView.Focus();
            }
        }

        // Move the focus to the search when the user press Up and is in the first row of the grid
        private void GrdCustomerViewKeyDown(object sender, KeyEventArgs e)
        {
            if (GrdControlView.FocusedRowHandle == 0)
            {
                if (e.KeyCode == Keys.Up)
                {
                    txtSearchQuery.Focus();
                }
            }

        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            var rowObject = GrdControlView.GetFocusedRow() as RentalItemDto;
            if (rowObject != null)
            {
                // Check if the user select a valid object
                if (rowObject.Id > 0 || rowObject.Code != null)
                {
                    Tag = new RentalItemFactory().GetRentalItem(new RentalItemRequest { RentalItemId = rowObject.Id, RentalItem = rowObject }).RentalItem;
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // Calculate the Stock Value
        private void GrdControlViewCustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e == null) throw new ArgumentNullException("e");
            if (e.Column.FieldName == "Stock" && e.IsGetData)
            {
                var view = sender as ColumnView;
                if (view != null)
                {
                    var itemDto = view.GetRow(e.RowHandle) as ItemDto;
                    decimal quantity = 0;
                    if (itemDto != null)
                    {
                        quantity = itemDto.Stocks.Aggregate(quantity, (current, stock) => current + stock.Quantity);
                    }
                    e.Value = quantity;
                }
            }
        }

        #endregion 
               
        #region Search Service Calls

        private void Search(string query)
        {
            var request = new RentalItemRequest { SearchRentalItemQuery = query};
            ShowSearchResults(new RentalItemFactory().SearchRentalItem(request).RentalItemList);
        }

        private void ShowSearchResults(List<RentalItemDto> searchResults)
        {           
            GrdControl.DataSource = searchResults;
        }

        #endregion
    }
}