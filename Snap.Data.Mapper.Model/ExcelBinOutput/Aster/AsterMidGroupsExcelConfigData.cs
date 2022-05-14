namespace Snap.Data.Mapper.Model.ExcelBinOutput.Aster;

public class AsterMidGroupsExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("battleGroupVec")]
    public IList<int> BattleGroupVec { get; set; } = default!;
}
