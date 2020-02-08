using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Data;
using System.Windows.Controls;
using WpfDataGridExample.Events;

namespace WpfDataGridExample.ViewModels
{
    public class ExampleViewModel : BindableBase
    {
        private IEventAggregator _eventAggregator = null;

        private DataTable _data = null;

        public DataView Data { get; private set; } = null;

        public DelegateCommand<DataGridSortingEventArgs> SortingCommand { get; private set; }

        public ExampleViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            _data = new DataTable();

            _data.Columns.Add("Name");
            _data.Columns.Add("Price", typeof(int));

            _data.Rows.Add("商品A", 500);
            _data.Rows.Add("商品B", 1200);
            _data.Rows.Add("商品C", DBNull.Value);
            _data.Rows.Add("商品D", 2000);

            Data = new DataView(_data);

            // 絞り込み
            //Data.RowFilter = "Price > 1000";

            // カスタムソートするときこんなかんじで
            SortingCommand = new DelegateCommand<DataGridSortingEventArgs>(OnSorting);

        }

        private void OnSorting(DataGridSortingEventArgs e)
        {
            // こんな雰囲気でやる：

            /*
            string headerText = e.Column.Header.ToString();

            // クリックされた列ヘッダの文字列を見て、カスタムソートするかどうか判断する
            if (headerText == "金額")
            {
                // ソート処理を実装する場合 true に設定する
                e.Handled = true;

                // ソート
                Data.Sort = " ... ";  //https://docs.microsoft.com/en-us/dotnet/api/system.data.dataview.sort?view=netframework-4.8

                // DataTableをソートされたViewの内容で再構築
                _data = Data.ToTable();

                Data = new DataView(_data);

                // ビューにソート完了の通知
                _eventAggregator.GetEvent<SortedEvent>().Publish(new SortedEventArgs());
            }
            //*/
        }
    }
}
