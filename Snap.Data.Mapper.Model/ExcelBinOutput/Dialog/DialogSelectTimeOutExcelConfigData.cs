namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dialog;

public class DialogSelectTimeOutExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("nextDialogID")]
    public int NextDialogID { get; set; }
}