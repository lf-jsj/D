namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.RegionSearch;

public class RegionSearchRegionExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("regionCenter")]
    public IList<double> RegionCenter { get; set; } = default!;

    [JsonPropertyName("regionRadius")]
    public double RegionRadius { get; set; }

    [JsonPropertyName("oneoffGroupList")]
    public IList<int> OneoffGroupList { get; set; } = default!;

    [JsonPropertyName("oneoffGroupNum")]
    public int OneoffGroupNum { get; set; }

    [JsonPropertyName("recycleGroupList")]
    public IList<int> RecycleGroupList { get; set; } = default!;

    [JsonPropertyName("recycleGroupNum")]
    public int RecycleGroupNum { get; set; }

    [JsonPropertyName("recycleType")]
    public string RecycleType { get; set; } = default!;

    [JsonPropertyName("recycleParam")]
    public int RecycleParam { get; set; }
}