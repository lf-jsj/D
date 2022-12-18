using Snap.Data.Mapper.Model.Common;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.MpPlay;

public class MpPlayGroupExcelConfigData : DataObject
{
    [JsonPropertyName("EntryId")]
    public int EntryId { get; set; }

    [JsonPropertyName("playId")]
    public int PlayId { get; set; }

    [JsonPropertyName("serverLuaCallGroupList")]
    public IList<int> ServerLuaCallGroupList { get; set; } = default!;

    [JsonPropertyName("resinCost")]
    public int ResinCost { get; set; }

    [JsonPropertyName("upAvatarList")]
    public IList<int> UpAvatarList { get; set; } = default!;

    [JsonPropertyName("rewardVec")]
    public IList<DropIDRewardPreview> RewardVec { get; set; } = default!;

    [JsonPropertyName("activateGroupList")]
    public IList<int> ActivateGroupList { get; set; } = default!;

    [JsonPropertyName("groupList")]
    public IList<int> GroupList { get; set; } = default!;

    [JsonPropertyName("bornGroupId")]
    public int BornGroupId { get; set; }

    [JsonPropertyName("bornConfigId")]
    public int BornConfigId { get; set; }

    [JsonPropertyName("rebornGroupId")]
    public int RebornGroupId { get; set; }

    [JsonPropertyName("rebornConfigId")]
    public int RebornConfigId { get; set; }

    [JsonPropertyName("rewardGroupId")]
    public int RewardGroupId { get; set; }

    [JsonPropertyName("rewardConfigId")]
    public int RewardConfigId { get; set; }

    [JsonPropertyName("prepareTime")]
    public int PrepareTime { get; set; }

    [JsonPropertyName("centerPosList")]
    public IList<float> CenterPosList { get; set; } = default!;

    [JsonPropertyName("centerRadius")]
    public int CenterRadius { get; set; }

    [JsonPropertyName("targetPosList")]
    public IList<float> TargetPosList { get; set; } = default!;

    [JsonPropertyName("reviseId")]
    public int ReviseId { get; set; }

    [JsonPropertyName("rateList")]
    public IList<int> RateList { get; set; } = default!;

    [JsonPropertyName("limitRegion")]
    public string LimitRegion { get; set; } = default!;

    [JsonPropertyName("abilityGroupList")]
    public IList<int> AbilityGroupList { get; set; } = default!;

    [JsonPropertyName("safeGroupId")]
    public int? SafeGroupId { get; set; }

    [JsonPropertyName("safeConfigId")]
    public int? SafeConfigId { get; set; }

    [JsonPropertyName("generalRewardConfigId")]
    public int? GeneralRewardConfigId { get; set; }

    [JsonPropertyName("clientShowType")]
    public string ClientShowType { get; set; } = default!;

    [JsonPropertyName("AMHFGGCPDDA")]
    public bool? AMHFGGCPDDA { get; set; }

    [JsonPropertyName("materialCostId")]
    public int? MaterialCostId { get; set; }

    [JsonPropertyName("materialCostNum")]
    public int? MaterialCostNum { get; set; }

    [JsonPropertyName("CPBFNNBECAH")]
    public bool? CPBFNNBECAH { get; set; }

    [JsonPropertyName("singlePrepareTime")]
    public int? SinglePrepareTime { get; set; }
}