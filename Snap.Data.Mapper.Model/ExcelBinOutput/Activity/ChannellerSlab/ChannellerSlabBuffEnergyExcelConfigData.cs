namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.ChannellerSlab;

public class ChannellerSlabBuffEnergyExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("avatarLevel")]
    public int AvatarLevel { get; set; }

    [JsonPropertyName("singleEnergy")]
    public int SingleEnergy { get; set; }

    [JsonPropertyName("mpEnergy")]
    public int MpEnergy { get; set; }
}