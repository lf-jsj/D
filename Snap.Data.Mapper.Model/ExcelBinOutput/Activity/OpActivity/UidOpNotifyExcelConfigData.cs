namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.OpActivity;

public class UidOpNotifyExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }
}