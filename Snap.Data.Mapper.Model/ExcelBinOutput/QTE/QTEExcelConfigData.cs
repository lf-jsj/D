using Snap.Data.Mapper.Model.Common.Wrapper;
using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.QTE;

public class QTEExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("BFABAMKLNKA")]
    public int BFABAMKLNKA { get; set; }

    [JsonPropertyName("ONHHICGKHKI")]
    public string ONHHICGKHKI { get; set; } = default!;

    [JsonPropertyName("MLHMMLPCJGL")]
    public IList<ParamWrapper<int>> MLHMMLPCJGL { get; set; } = default!;

    [JsonPropertyName("HCMJAPOFDHB")]
    public IList<TypeParam<int>> HCMJAPOFDHB { get; set; } = default!;

    [JsonPropertyName("failExec")]
    public IList<ParamWrapper<int>> FailExec { get; set; } = default!;
}
