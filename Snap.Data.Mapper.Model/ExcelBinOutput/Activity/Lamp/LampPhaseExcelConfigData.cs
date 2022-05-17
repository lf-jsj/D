namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Lamp;

public class LampPhaseExcelConfigData : DataObject
{
    [JsonPropertyName("phaseId")]
    public int PhaseId { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("endProgress")]
    public int EndProgress { get; set; }

    [JsonPropertyName("materialVec")]
    public IList<int> MaterialVec { get; set; } = default!;

    [JsonPropertyName("GivingId")]
    public int GivingId { get; set; }

    [JsonPropertyName("contribution")]
    public int Contribution { get; set; }

    [JsonPropertyName("addProgress")]
    public int AddProgress { get; set; }

    [JsonPropertyName("notifyGroupId")]
    public int NotifyGroupId { get; set; }

    [JsonPropertyName("gadgetId")]
    public int GadgetId { get; set; }

    [JsonPropertyName("isDisplay")]
    public bool? IsDisplay { get; set; }
}