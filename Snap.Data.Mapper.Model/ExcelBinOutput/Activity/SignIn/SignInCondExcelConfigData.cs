namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SignIn;

public class SignInCondExcelConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("condList")]
    public IList<ParamListType> CondList { get; set; } = default!;

    [JsonPropertyName("totalDayCount")]
    public int TotalDayCount { get; set; }
}