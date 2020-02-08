using Prism.Events;
using System.Windows.Controls;
using WpfDataGridExample.Events;

namespace WpfDataGridExample.Views
{
    /// <summary>
    /// ExampleView.xaml の相互作用ロジック
    /// </summary>
    public partial class ExampleView : UserControl
    {
        public ExampleView(IEventAggregator eventAggregator)
        {
            InitializeComponent();

            // VMからのイベント受け取る
            eventAggregator.GetEvent<SortedEvent>().Subscribe(e =>
            {
                // ソートされた列の列ヘッダにソートマークつける
                //dataGrid.Columns[ ... ].SortDirection = ...
            },
            true);
        }
    }
}
