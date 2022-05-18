namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaeOverallExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("offeringId")]
    public int OfferingId { get; set; }

    [JsonPropertyName("NGOPJIKENKC")]
    public int NGOPJIKENKC { get; set; }

    [JsonPropertyName("GLBAEBNHOHC")]
    public int GLBAEBNHOHC { get; set; }

    [JsonPropertyName("GGBGOGONMCE")]
    public IList<int> GGBGOGONMCE { get; set; } = default!;

    [JsonPropertyName("IADHIECFPKK")]
    public int IADHIECFPKK { get; set; }

    [JsonPropertyName("BHLEBBFHKIF")]
    public double BHLEBBFHKIF { get; set; }

    [JsonPropertyName("PNPHKKJFIPM")]
    public double PNPHKKJFIPM { get; set; }

    [JsonPropertyName("DFJGPBCPPAG")]
    public int DFJGPBCPPAG { get; set; }

    [JsonPropertyName("FGPINKOBLMH")]
    public double FGPINKOBLMH { get; set; }

    [JsonPropertyName("IHMMHEOEIDB")]
    public int IHMMHEOEIDB { get; set; }

    [JsonPropertyName("LADFDGMFCCF")]
    public int LADFDGMFCCF { get; set; }

    [JsonPropertyName("NNBLPEGJMDB")]
    public int NNBLPEGJMDB { get; set; }
}