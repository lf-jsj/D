using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class CompoundExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("groupID")]
    public int GroupID { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("rankLevel")]
    public int RankLevel { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; } = default!;

    [JsonPropertyName("isDefaultUnlocked")]
    public bool IsDefaultUnlocked { get; set; }

    [JsonPropertyName("costTime")]
    public int CostTime { get; set; }

    [JsonPropertyName("queueSize")]
    public int QueueSize { get; set; }

    [JsonPropertyName("inputVec")]
    public IList<IdCount<int>> InputVec { get; set; } = default!;

    [JsonPropertyName("outputVec")]
    public IList<IdCount<int>> OutputVec { get; set; } = default!;

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("OFGAOOLMFMM")]
    public Text OFGAOOLMFMM { get; set; }
}
