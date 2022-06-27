using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarPromoteExcelConfigData : DataObject
{
    [JsonPropertyName("avatarPromoteId")]
    public int AvatarPromoteId { get; set; }

    [JsonPropertyName("promoteAudio")]
    public string PromoteAudio { get; set; } = string.Empty;

    [JsonPropertyName("costItems")]
    public IList<IdCount<int>> CostItems { get; set; } = default!;

    [JsonPropertyName("unlockMaxLevel")]
    public int UnlockMaxLevel { get; set; }

    [JsonPropertyName("addProps")]
    public IList<FightPropTypeValue> AddProps { get; set; } = default!;

    [JsonPropertyName("promoteLevel")]
    public int? PromoteLevel { get; set; }

    [JsonPropertyName("scoinCost")]
    public int? ScoinCost { get; set; }

    [JsonPropertyName("requiredPlayerLevel")]
    public int? RequiredPlayerLevel { get; set; }
}
