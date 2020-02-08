using Prism.Events;

namespace WpfDataGridExample.Events
{
    public struct SortedEventArgs
    {
        // なんかパラメータ
    }

    public class SortedEvent : PubSubEvent<SortedEventArgs>
    {
    }
}
