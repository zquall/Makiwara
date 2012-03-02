using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReplicantFacility.Factory;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;
using DevExpress.XtraGrid.Views.Base;

namespace shellProject
{
    public partial class ItemFinder : XtraForm
    {
        public ItemFinder()
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
            var rowObject = GrdControlView.GetFocusedRow() as ItemDto;
            if (rowObject != null)
            {
                // Check if the user select a valid object
                if (rowObject.Id > 0 || rowObject.Code != null)
                {
                    Tag = new ItemFactory().GetItem(new ItemRequest { ItemId = rowObject.Id, Item = rowObject }).Item;
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
            var request = new ItemRequest {SearchItemQuery = query};
            ShowSearchResults(new ItemFactory().SearchItem(request).ItemList);
        }

        private void ShowSearchResults(List<ItemDto> searchResults)
        {           
            GrdControl.DataSource = searchResults;
        }

        #endregion
    }
}