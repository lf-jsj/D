namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Projection;

public class LanV2ProjectionSwitchButtonConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("CPPPDJLHJBO")]
    public string CPPPDJLHJBO { get; set; } = default!;

    [JsonPropertyName("iconPath")]
    public string IconPath { get; set; } = default!;
}