namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityCondExcelConfigData : DataObject
{
    [JsonPropertyName("condId")]
    public int CondId { get; set; }

    [JsonPropertyName("condComb")]
    public string CondComb { get; set; } = default!;

    [JsonPropertyName("cond")]
    public IList<ParamType> Cond { get; set; } = default!;
}