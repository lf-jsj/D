namespace Snap.Data.Mapper.Model.ExcelBinOutput.PersonalLine;
public class PersonalLineActivityExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("perfabPath")]
    public string PerfabPath { get; set; } = default!;

    [JsonPropertyName("KDIMLJNPNLO")]
    public string KDIMLJNPNLO { get; set; } = default!;
}