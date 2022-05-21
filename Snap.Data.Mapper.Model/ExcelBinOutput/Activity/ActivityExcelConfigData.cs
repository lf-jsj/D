using Snap.Data.Mapper.Model.Common.Wrapper;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class ActivityExcelConfigData : DataObject
{
    [JsonPropertyName("ActivityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("Type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("DestroyItem")]
    public IList<ItemIdWrapper> DestroyItem { get; set; } = default!;

    [JsonPropertyName("NameTextMapHash")]
    public long NameTextMapHash { get; set; }

    [JsonPropertyName("ActivitySceneTag")]
    public string ActivitySceneTag { get; set; } = string.Empty;

    [JsonPropertyName("IsLoadTerrain")]
    public bool IsLoadTerrain { get; set; }
}
