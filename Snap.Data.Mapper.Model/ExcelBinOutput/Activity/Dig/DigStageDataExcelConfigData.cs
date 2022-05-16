namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Dig;

public class DigStageDataExcelConfigData : DataObject
{
    [JsonPropertyName("stageID")]
    public int StageID { get; set; }

    [JsonPropertyName("FELCBICHBIF")]
    public int FELCBICHBIF { get; set; }

    [JsonPropertyName("questID")]
    public int QuestID { get; set; }

    [JsonPropertyName("FIIBAFONNDB")]
    public int FIIBAFONNDB { get; set; }

    [JsonPropertyName("OOEKFJJGENL")]
    public Text OOEKFJJGENL { get; set; }

    [JsonPropertyName("JBMDLNOPANB")]
    public Text JBMDLNOPANB { get; set; }

    [JsonPropertyName("pushTipsId")]
    public int PushTipsId { get; set; }

    [JsonPropertyName("unlockTime")]
    public int UnlockTime { get; set; }
}