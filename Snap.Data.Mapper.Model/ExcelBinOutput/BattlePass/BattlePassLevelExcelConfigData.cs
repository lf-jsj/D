namespace Snap.Data.Mapper.Model.ExcelBinOutput.BattlePass;
public class BattlePassLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelUpNeedPoint")]
    public int LevelUpNeedPoint { get; set; }

    [JsonPropertyName("level")]
    public int? Level { get; set; }
}
