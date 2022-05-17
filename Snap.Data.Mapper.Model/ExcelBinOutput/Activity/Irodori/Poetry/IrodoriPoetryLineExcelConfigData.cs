namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Poetry;

public class IrodoriPoetryLineExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("HKDEECDHDLK")]
    public int? HKDEECDHDLK { get; set; }
}