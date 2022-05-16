namespace Snap.Data.Mapper.Model.ExcelBinOutput.BattlePass;

public class BattlePassRewardExcelConfigData : DataObject
{
    [JsonPropertyName("indexId")]
    public int IndexId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("freeRewardIdList")]
    public IList<int> FreeRewardIdList { get; set; } = default!;

    [JsonPropertyName("paidRewardIdList")]
    public IList<int> PaidRewardIdList { get; set; } = default!;

    [JsonPropertyName("showUp")]
    public bool? ShowUp { get; set; }
}