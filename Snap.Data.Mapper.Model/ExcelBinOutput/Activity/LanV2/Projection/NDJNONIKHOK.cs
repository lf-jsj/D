namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Projection;

public class NDJNONIKHOK : DataObject
{
    [JsonPropertyName("prefabPath")]
    public string PrefabPath { get; set; } = default!;

    [JsonPropertyName("FBAIAIDLBKC")]
    public string FBAIAIDLBKC { get; set; } = default!;

    [JsonPropertyName("NAALEEPAOGF")]
    public IList<float> NAALEEPAOGF { get; set; } = default!;

    [JsonPropertyName("FHBPHPBLGJH")]
    public IList<float> FHBPHPBLGJH { get; set; } = default!;

    [JsonPropertyName("OOJJHPGJCPI")]
    public IList<float> OOJJHPGJCPI { get; set; } = default!;

    [JsonPropertyName("JLFNAEEPMDH")]
    public IList<float> JLFNAEEPMDH { get; set; } = default!;

    [JsonPropertyName("FJONMCAOELL")]
    public IList<float> FJONMCAOELL { get; set; } = default!;

    [JsonPropertyName("DGBKDBHIKPJ")]
    public int? DGBKDBHIKPJ { get; set; }

    [JsonPropertyName("CJOCFLGCJIJ")]
    public string CJOCFLGCJIJ { get; set; } = default!;

    [JsonPropertyName("GADLKBPCCJO")]
    public float? GADLKBPCCJO { get; set; }
}
