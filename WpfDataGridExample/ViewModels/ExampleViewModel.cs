using Prism.Mvvm;
using System;
using System.Data;

namespace WpfDataGridExample.ViewModels
{
    public class ExampleViewModel : BindableBase
    {
        private DataTable _data = null;

        public DataView Data { get; private set; } = null;

        public ExampleViewModel()
        {
            _data = new DataTable();

            _data.Columns.Add("Name");
            _data.Columns.Add("Price", typeof(int));

            _data.Rows.Add("商品A", 500);
            _data.Rows.Add("商品B", 1200);
            _data.Rows.Add("商品C", DBNull.Value);
            _data.Rows.Add("商品D", 2000);

            Data = new DataView(_data);

            //Data.RowFilter = "Price > 1000";
        }
    }
}
