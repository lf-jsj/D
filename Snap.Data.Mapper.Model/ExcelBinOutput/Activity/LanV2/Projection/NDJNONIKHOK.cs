namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Projection;

public class NDJNONIKHOK : DataObject
{
    [JsonPropertyName("prefabPath")]
    public string PrefabPath { get; set; } = default!;

    [JsonPropertyName("FBAIAIDLBKC")]
    public string FBAIAIDLBKC { get; set; } = default!;

    [JsonPropertyName("NAALEEPAOGF")]
    public IList<double> NAALEEPAOGF { get; set; } = default!;

    [JsonPropertyName("FHBPHPBLGJH")]
    public IList<double> FHBPHPBLGJH { get; set; } = default!;

    [JsonPropertyName("OOJJHPGJCPI")]
    public IList<double> OOJJHPGJCPI { get; set; } = default!;

    [JsonPropertyName("JLFNAEEPMDH")]
    public IList<double> JLFNAEEPMDH { get; set; } = default!;

    [JsonPropertyName("FJONMCAOELL")]
    public IList<double> FJONMCAOELL { get; set; } = default!;

    [JsonPropertyName("DGBKDBHIKPJ")]
    public int? DGBKDBHIKPJ { get; set; }

    [JsonPropertyName("CJOCFLGCJIJ")]
    public string CJOCFLGCJIJ { get; set; } = default!;

    [JsonPropertyName("GADLKBPCCJO")]
    public double? GADLKBPCCJO { get; set; }
}
