using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Dungeon;

public class DungeonPassExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("conds")]
    public IList<TypeParam<int>> Conds { get; set; } = default!;

    [JsonPropertyName("logicType")]
    public string LogicType { get; set; } = default!;
}
