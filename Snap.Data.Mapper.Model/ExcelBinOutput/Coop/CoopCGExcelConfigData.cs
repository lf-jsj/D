using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Coop;

public class CoopCGExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("chapterId")]
    public int ChapterId { get; set; }

    [JsonPropertyName("unlockPointId")]
    public int UnlockPointId { get; set; }

    [JsonPropertyName("cgType")]
    public string CgType { get; set; } = default!;

    [JsonPropertyName("unlockCond")]
    public IList<CondTypeArgs> UnlockCond { get; set; } = default!;

    [JsonPropertyName("showImageHashSuffix")]
    public HashSuffix ShowImageHashSuffix { get; set; }

    [JsonPropertyName("showImageHashPre")]
    public HashPre ShowImageHashPre { get; set; }

    [JsonPropertyName("showImageSmallHashSuffix")]
    public HashSuffix ShowImageSmallHashSuffix { get; set; }

    [JsonPropertyName("showImageSmallHashPre")]
    public HashPre ShowImageSmallHashPre { get; set; }

    [JsonPropertyName("cgNameTextMapHash")]
    public Text CgNameTextMapHash { get; set; }

    [JsonPropertyName("cgDesTextMapHash")]
    public Text CgDesTextMapHash { get; set; }

    [JsonPropertyName("sortId")]
    public int SortId { get; set; }
}
