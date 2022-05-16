namespace Snap.Data.Mapper.Model.ExcelBinOutput.Bored;

public class BoredCreateMonsterExcelConfigData : DataObject
{
    [JsonPropertyName("playerLevel")]
    public int PlayerLevel { get; set; }

    [JsonPropertyName("monsterConfigVec")]
    public IList<MonsterConfigVec> MonsterConfigVec { get; set; } = default!;
}
