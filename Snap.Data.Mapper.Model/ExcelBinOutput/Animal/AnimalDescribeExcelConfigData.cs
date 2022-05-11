namespace Snap.Data.Mapper.Model.ExcelBinOutput.Animal;

public class AnimalDescribeExcelConfigData : DataObject
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;
}