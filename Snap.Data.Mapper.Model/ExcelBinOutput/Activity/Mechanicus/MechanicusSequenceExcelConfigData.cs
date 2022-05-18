namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Mechanicus;

public class MechanicusSequenceExcelConfigData : DataObject
{
    [JsonPropertyName("sequenceID")]
    public int SequenceID { get; set; }

    [JsonPropertyName("mechanicusID")]
    public int MechanicusID { get; set; }

    [JsonPropertyName("openLevel")]
    public int OpenLevel { get; set; }

    [JsonPropertyName("openGearList")]
    public IList<int> OpenGearList { get; set; } = default!;

    [JsonPropertyName("gearLevelLimite")]
    public int GearLevelLimite { get; set; }

    [JsonPropertyName("gearMoneyLimite")]
    public int GearMoneyLimite { get; set; }

    [JsonPropertyName("openMapList")]
    public IList<int> OpenMapList { get; set; } = default!;

    [JsonPropertyName("activityID")]
    public int ActivityID { get; set; }

    [JsonPropertyName("condID")]
    public int CondID { get; set; }

    [JsonPropertyName("rewardPreviewID")]
    public int RewardPreviewID { get; set; }
}
