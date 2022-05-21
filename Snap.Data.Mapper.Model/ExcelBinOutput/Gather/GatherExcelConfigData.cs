namespace Snap.Data.Mapper.Model.ExcelBinOutput.Gather;

public class GatherExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("areaId")]
    public int AreaId { get; set; }

    [JsonPropertyName("pointType")]
    public int PointType { get; set; }

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("extraItemIdVec")]
    public IList<int> ExtraItemIdVec { get; set; } = default!;

    [JsonPropertyName("cd")]
    public int Cd { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("refreshId")]
    public int RefreshId { get; set; }

    [JsonPropertyName("blockLimits")]
    public IList<BlockIdCount> BlockLimits { get; set; } = default!;

    [JsonPropertyName("initDisableInteract")]
    public bool InitDisableInteract { get; set; }

    [JsonPropertyName("JNJHNIDDPLN")]
    public string JNJHNIDDPLN { get; set; } = default!;

    [JsonPropertyName("pointLocation")]
    public string PointLocation { get; set; } = default!;

    [JsonPropertyName("isForbidGuest")]
    public bool? IsForbidGuest { get; set; }
}
