namespace Snap.Data.Mapper.Model.ExcelBinOutput.Fish;

public class FishExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("monsterId")]
    public int MonsterId { get; set; }

    [JsonPropertyName("itemId")]
    public int ItemId { get; set; }

    [JsonPropertyName("hp")]
    public int Hp { get; set; }

    [JsonPropertyName("IPLBOGGFBGP")]
    public IList<int> IPLBOGGFBGP { get; set; } = default!;

    [JsonPropertyName("NOBIELEHBOE")]
    public int NOBIELEHBOE { get; set; }

    [JsonPropertyName("GBALIGDIKKA")]
    public IList<double> GBALIGDIKKA { get; set; } = default!;

    [JsonPropertyName("MLHKPEPCIMJ")]
    public IList<int> MLHKPEPCIMJ { get; set; } = default!;

    [JsonPropertyName("ADAIFFEOELG")]
    public IList<double> ADAIFFEOELG { get; set; } = default!;

    [JsonPropertyName("ECHHNKEKBCF")]
    public IList<double> ECHHNKEKBCF { get; set; } = default!;

    [JsonPropertyName("PJMMOHJBIFG")]
    public double PJMMOHJBIFG { get; set; }

    [JsonPropertyName("ABIDCEADKKC")]
    public double ABIDCEADKKC { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("OBNHODILGKN")]
    public IList<DataObject> OBNHODILGKN { get; set; } = default!;

    [JsonPropertyName("OKOBOHNLILP")]
    public int OKOBOHNLILP { get; set; }

    [JsonPropertyName("FMGHPPAEDHN")]
    public int FMGHPPAEDHN { get; set; }

    [JsonPropertyName("CLPFPCCKNEG")]
    public int CLPFPCCKNEG { get; set; }

    [JsonPropertyName("FLGOABNCBAB")]
    public int? FLGOABNCBAB { get; set; }
}
