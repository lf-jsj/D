using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityCondExcelConfigData : DataObject
{
    [JsonPropertyName("condId")]
    public int CondId { get; set; }

    [JsonPropertyName("condComb")]
    public string CondComb { get; set; } = default!;

    [JsonPropertyName("cond")]
    public IList<TypeParam<int>> Cond { get; set; } = default!;
}