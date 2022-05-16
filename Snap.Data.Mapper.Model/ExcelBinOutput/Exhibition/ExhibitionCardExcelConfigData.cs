namespace Snap.Data.Mapper.Model.ExcelBinOutput.Exhibition;
public class ExhibitionCardExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("styleTextMapHash")]
    public Text StyleTextMapHash { get; set; }

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("IFFDMOKFIOD")]
    public string IFFDMOKFIOD { get; set; } = default!;
}
