namespace Snap.Data.Mapper.Model.ExcelBinOutput.Tutorial;
public class TutorialDetailExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("imageNameList")]
    public IList<string> ImageNameList { get; set; } = default!;

    [JsonPropertyName("descriptTextMapHash")]
    public Text DescriptTextMapHash { get; set; }
}