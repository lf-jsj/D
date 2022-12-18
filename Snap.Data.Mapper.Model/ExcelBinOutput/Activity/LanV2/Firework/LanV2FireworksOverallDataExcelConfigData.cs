namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Firework;

public class LanV2FireworksOverallDataExcelConfigData : DataObject
{
    [JsonPropertyName("scheduleId")]
    public int ScheduleId { get; set; }

    [JsonPropertyName("GONHGNFKBDP")]
    public int GONHGNFKBDP { get; set; }

    [JsonPropertyName("IFACAFEIHLB")]
    public IList<MJJDNALGLOJLPICMNCMNCG> IFACAFEIHLB { get; set; } = default!;

    [JsonPropertyName("NEEEOBDOCPP")]
    public float NEEEOBDOCPP { get; set; }

    [JsonPropertyName("HGFNEAPOIOL")]
    public float HGFNEAPOIOL { get; set; }

    [JsonPropertyName("pushTipsId")]
    public int PushTipsId { get; set; }
}