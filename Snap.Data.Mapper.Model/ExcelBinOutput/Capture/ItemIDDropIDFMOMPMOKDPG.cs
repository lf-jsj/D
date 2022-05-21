namespace Snap.Data.Mapper.Model.ExcelBinOutput.Capture;

public class ItemIDDropIDFMOMPMOKDPG : DataObject
{
    [JsonPropertyName("FMOMPMOKDPG")]
    public int FMOMPMOKDPG { get; set; }

    [JsonPropertyName("dropID")]
    public int DropID { get; set; }

    [JsonPropertyName("itemID")]
    public int? ItemID { get; set; }
}
