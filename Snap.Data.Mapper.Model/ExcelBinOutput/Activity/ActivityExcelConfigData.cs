namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class DestroyItem : DataObject
{
    [JsonPropertyName("ItemId")]
    public IList<int> ItemId { get; set; } = default!;
}

public class ActivityExcelConfigData : DataObject
{
    [JsonPropertyName("ActivityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("Type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("DestroyItem")]
    public IList<DestroyItem> DestroyItem { get; set; } = default!;

    [JsonPropertyName("NameTextMapHash")]
    public long NameTextMapHash { get; set; }

    [JsonPropertyName("ActivitySceneTag")]
    public string ActivitySceneTag { get; set; } = default!;

    [JsonPropertyName("IsLoadTerrain")]
    public bool IsLoadTerrain { get; set; }
}
