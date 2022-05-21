using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.Common.Wrapper;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Forge;

public class ForgeExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("playerLevel")]
    public int PlayerLevel { get; set; }

    [JsonPropertyName("isDefaultShow")]
    public bool IsDefaultShow { get; set; }

    [JsonPropertyName("effectiveWorldLevels")]
    public IList<int> EffectiveWorldLevels { get; set; } = default!;

    [JsonPropertyName("forgeType")]
    public int ForgeType { get; set; }

    [JsonPropertyName("showItemId")]
    public int ShowItemId { get; set; }

    [JsonPropertyName("DGKEJNHIEDJ")]
    public int DGKEJNHIEDJ { get; set; }

    [JsonPropertyName("resultItemId")]
    public int ResultItemId { get; set; }

    [JsonPropertyName("resultItemCount")]
    public int ResultItemCount { get; set; }

    [JsonPropertyName("forgeTime")]
    public int ForgeTime { get; set; }

    [JsonPropertyName("queueNum")]
    public int QueueNum { get; set; }

    [JsonPropertyName("scoinCost")]
    public int ScoinCost { get; set; }

    [JsonPropertyName("randomItems")]
    public IList<CountWrapper> RandomItems { get; set; } = default!;

    [JsonPropertyName("materialItems")]
    public IList<IdCount<int>> MaterialItems { get; set; } = default!;

    [JsonPropertyName("priority")]
    public int Priority { get; set; }

    [JsonPropertyName("forgePoint")]
    public int ForgePoint { get; set; }

    [JsonPropertyName("forgePointNoticeTextMapHash")]
    public Text ForgePointNoticeTextMapHash { get; set; }

    [JsonPropertyName("mainRandomDropId")]
    public int? MainRandomDropId { get; set; }
}