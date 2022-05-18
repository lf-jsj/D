namespace Snap.Data.Mapper.Model.ExcelBinOutput.Offering;

public class OfferingOpenStateConfigData : DataObject
{
    [JsonPropertyName("offeringId")]
    public int OfferingId { get; set; }

    [JsonPropertyName("openState")]
    public string OpenState { get; set; } = default!;

    [JsonPropertyName("itemLimit")]
    public string ItemLimit { get; set; } = default!;

    [JsonPropertyName("FLJCLGNJDLE")]
    public string FLJCLGNJDLE { get; set; } = default!;

    [JsonPropertyName("GMHLCHIALIL")]
    public bool? GMHLCHIALIL { get; set; }

    [JsonPropertyName("MPMFBOGPAOP")]
    public bool? MPMFBOGPAOP { get; set; }

    [JsonPropertyName("activityId")]
    public int? ActivityId { get; set; }
}