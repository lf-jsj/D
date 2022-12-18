namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.TreasureMap;

public class TreasureMapExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("activityId")]
    public int ActivityId { get; set; }

    [JsonPropertyName("previewRewardId")]
    public int PreviewRewardId { get; set; }

    [JsonPropertyName("npcId")]
    public int NpcId { get; set; }

    [JsonPropertyName("npcPos")]
    public IList<float> NpcPos { get; set; } = default!;

    [JsonPropertyName("treasureDays")]
    public int TreasureDays { get; set; }

    [JsonPropertyName("questId")]
    public int QuestId { get; set; }

    [JsonPropertyName("monsterProbability")]
    public float MonsterProbability { get; set; }

    [JsonPropertyName("rewardWorktopGadgetId")]
    public int RewardWorktopGadgetId { get; set; }

    [JsonPropertyName("tokenMaterialId")]
    public int TokenMaterialId { get; set; }

    [JsonPropertyName("unitTokenDropId")]
    public int UnitTokenDropId { get; set; }

    [JsonPropertyName("mpRewardId")]
    public int MpRewardId { get; set; }

    [JsonPropertyName("hostRewardLimit")]
    public int HostRewardLimit { get; set; }

    [JsonPropertyName("guestRewardLimit")]
    public int GuestRewardLimit { get; set; }

    [JsonPropertyName("mpChallengeIndex")]
    public int MpChallengeIndex { get; set; }

    [JsonPropertyName("bonusChallengeIndex")]
    public int BonusChallengeIndex { get; set; }

    [JsonPropertyName("challengeGadgetSuite")]
    public int ChallengeGadgetSuite { get; set; }

    [JsonPropertyName("spotReviseLevelId")]
    public int SpotReviseLevelId { get; set; }

    [JsonPropertyName("detectorMaterialId")]
    public int DetectorMaterialId { get; set; }

    [JsonPropertyName("guideChildQuestId")]
    public int GuideChildQuestId { get; set; }

    [JsonPropertyName("MAKPHEANOJM")]
    public int? MAKPHEANOJM { get; set; }
}