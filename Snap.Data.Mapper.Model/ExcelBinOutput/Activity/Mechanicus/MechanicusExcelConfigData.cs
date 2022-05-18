namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusExcelConfigData : DataObject
{
    [JsonPropertyName("mechanicusID")]
    public int MechanicusID { get; set; }

    [JsonPropertyName("sequenceList")]
    public IList<int> SequenceList { get; set; } = default!;

    [JsonPropertyName("ticketItemID")]
    public int TicketItemID { get; set; }

    [JsonPropertyName("ticketCostCount")]
    public int TicketCostCount { get; set; }

    [JsonPropertyName("matchPlayerLimit")]
    public int MatchPlayerLimit { get; set; }

    [JsonPropertyName("openGearList")]
    public IList<int> OpenGearList { get; set; } = default!;

    [JsonPropertyName("openMapList")]
    public IList<int> OpenMapList { get; set; } = default!;

    [JsonPropertyName("teachDifficultLevel")]
    public int TeachDifficultLevel { get; set; }

    [JsonPropertyName("punishTime")]
    public int PunishTime { get; set; }
}