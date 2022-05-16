namespace Snap.Data.Mapper.Model.ExcelBinOutput.Furniture;

public class FurnitureSuiteExcelConfigData : DataObject
{
    [JsonPropertyName("suiteID")]
    public int SuiteID { get; set; }

    [JsonPropertyName("jsonName")]
    public string JsonName { get; set; } = default!;

    [JsonPropertyName("suiteNameTextMapHash")]
    public Text SuiteNameTextMapHash { get; set; }

    [JsonPropertyName("OELOHIEHAHK")]
    public Text OELOHIEHAHK { get; set; }

    [JsonPropertyName("favoriteNpcExcelIdVec")]
    public IList<int> FavoriteNpcExcelIdVec { get; set; } = default!;

    [JsonPropertyName("IHNKGNFAAAL")]
    public string IHNKGNFAAAL { get; set; } = default!;

    [JsonPropertyName("furnType")]
    public IList<int> FurnType { get; set; } = default!;

    [JsonPropertyName("itemIcon")]
    public string ItemIcon { get; set; } = default!;

    [JsonPropertyName("mapIcon")]
    public string MapIcon { get; set; } = default!;

    [JsonPropertyName("HMLBOCCHLLI")]
    public double? HMLBOCCHLLI { get; set; }
}