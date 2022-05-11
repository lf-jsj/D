namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity;

public class Cond : DataObject
{

    [JsonPropertyName("param")]
    public IList<int> Param { get; set; } = default!;

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}

public class ActivityShopSheetExcelConfigData : DataObject
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("isAheadPreview")]
    public bool IsAheadPreview { get; set; }

    [JsonPropertyName("SheetNameTextMapHash")]
    public Text SheetNameTextMapHash { get; set; }

    [JsonPropertyName("cond")]
    public IList<Cond> Cond { get; set; } = default!;

    [JsonPropertyName("sortLevel")]
    public IList<object> SortLevel { get; set; } = default!;
}
