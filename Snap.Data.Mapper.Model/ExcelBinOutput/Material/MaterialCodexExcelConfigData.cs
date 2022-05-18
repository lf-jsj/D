namespace Snap.Data.Mapper.Model.ExcelBinOutput.Material;
public class MaterialCodexExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("materialId")]
    public int MaterialId { get; set; }

    [JsonPropertyName("SortOrder")]
    public int SortOrder { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("isDisuse")]
    public bool? IsDisuse { get; set; }

    [JsonPropertyName("showOnlyUnlocked")]
    public bool? ShowOnlyUnlocked { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;
}
