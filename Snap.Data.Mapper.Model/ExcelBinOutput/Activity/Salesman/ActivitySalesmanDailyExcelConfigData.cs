namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salesman;

public class CostItem : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("count")]
    public int Count { get; set; }
}

public class ActivitySalesmanDailyExcelConfigData : DataObject
{
    [JsonPropertyName("dailyConfigId")]
    public int DailyConfigId { get; set; }

    [JsonPropertyName("costItemList")]
    public IList<CostItem> CostItemList { get; set; } = default!;

    [JsonPropertyName("clusPosTextMapHash")]
    public Text ClusPosTextMapHash { get; set; }

    [JsonPropertyName("npcTalkTextMapHash")]
    public Text NpcTalkTextMapHash { get; set; }

    [JsonPropertyName("IntroTextMapHash")]
    public Text IntroTextMapHash { get; set; }

    [JsonPropertyName("tracePosition")]
    public string TracePosition { get; set; } = default!;
}
