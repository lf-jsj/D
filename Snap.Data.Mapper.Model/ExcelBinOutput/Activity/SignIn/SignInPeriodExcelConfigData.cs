namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SignIn;

public class SignInPeriodExcelConfigData : DataObject
{

    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("perfabPath")]
    public string PerfabPath { get; set; } = default!;
}