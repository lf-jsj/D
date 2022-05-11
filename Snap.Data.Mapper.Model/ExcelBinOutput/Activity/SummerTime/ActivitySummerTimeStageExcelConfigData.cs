namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.SummerTime;

public class ActivitySummerTimeStageExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("mainQuest")]
    public int MainQuest { get; set; }

    [JsonPropertyName("ELKIANPCFGJ")]
    public int ELKIANPCFGJ { get; set; }

    [JsonPropertyName("JCNLIJFOMGB")]
    public int JCNLIJFOMGB { get; set; }

    [JsonPropertyName("OOEKFJJGENL")]
    public Text OOEKFJJGENL { get; set; }

    [JsonPropertyName("JBMDLNOPANB")]
    public Text JBMDLNOPANB { get; set; }

    [JsonPropertyName("ALLIFLHPFPF")]
    public Text ALLIFLHPFPF { get; set; }

    [JsonPropertyName("JLKMDCDMPMH")]
    public Text JLKMDCDMPMH { get; set; }

    [JsonPropertyName("preQuest")]
    public int? PreQuest { get; set; }
}