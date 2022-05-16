namespace Snap.Data.Mapper.Model.ExcelBinOutput.BattlePass;

public class BattlePassScheduleExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("titleNameTextMapHash")]
    public Text TitleNameTextMapHash { get; set; }

    [JsonPropertyName("beginDateStr")]
    public string BeginDateStr { get; set; } = default!;

    [JsonPropertyName("endDateStr")]
    public string EndDateStr { get; set; } = default!;

    [JsonPropertyName("cycleList")]
    public IList<int> CycleList { get; set; } = default!;

    [JsonPropertyName("extraPaidRewardId")]
    public int ExtraPaidRewardId { get; set; }

    [JsonPropertyName("extraPaidAddPoint")]
    public int ExtraPaidAddPoint { get; set; }

    [JsonPropertyName("buyLevelCostCoinNum")]
    public int BuyLevelCostCoinNum { get; set; }

    [JsonPropertyName("cyclePointUpperLimit")]
    public int CyclePointUpperLimit { get; set; }

    [JsonPropertyName("levelRewardIndexId")]
    public int LevelRewardIndexId { get; set; }

    [JsonPropertyName("normalRewardList")]
    public IList<int> NormalRewardList { get; set; } = default!;

    [JsonPropertyName("showImage")]
    public string ShowImage { get; set; } = default!;

    [JsonPropertyName("showRewardList")]
    public IList<int> ShowRewardList { get; set; } = default!;

    [JsonPropertyName("stroyRewardList")]
    public IList<int> StroyRewardList { get; set; } = default!;

    [JsonPropertyName("storyId")]
    public int StoryId { get; set; }

    [JsonPropertyName("mailDayCount")]
    public int? MailDayCount { get; set; }

    [JsonPropertyName("mailConfigId")]
    public int? MailConfigId { get; set; }
}