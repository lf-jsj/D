namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabLoopDungeonConditionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("conditionType")]
    public string ConditionType { get; set; } = default!;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("conditionParam1")]
    public int ConditionParam1 { get; set; }

    [JsonPropertyName("exclusiveId")]
    public int ExclusiveId { get; set; }

    [JsonPropertyName("score")]
    public int Score { get; set; }

    [JsonPropertyName("conditionParam2")]
    public int? ConditionParam2 { get; set; }
}
