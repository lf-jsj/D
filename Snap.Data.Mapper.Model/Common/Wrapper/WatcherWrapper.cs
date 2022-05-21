namespace Snap.Data.Mapper.Model.Common.Wrapper;

public class WatcherWrapper : DataObject
{
    [JsonPropertyName("watcher")]
    public int Watcher { get; set; }
}
