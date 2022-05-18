namespace Snap.Data.Mapper.Model.ExcelBinOutput.Widget;

public class WidgetGeneralExcelConfigData : DataObject
{
    [JsonPropertyName("materialID")]
    public int MaterialID { get; set; }

    [JsonPropertyName("canUseInOtherWorld")]
    public bool CanUseInOtherWorld { get; set; }

    [JsonPropertyName("PDOGJAHPHMC")]
    public IList<int> PDOGJAHPHMC { get; set; } = default!;

    [JsonPropertyName("forbiddenDungeonList")]
    public IList<int> ForbiddenDungeonList { get; set; } = default!;

    [JsonPropertyName("LHGMFCLICEG")]
    public IList<int> LHGMFCLICEG { get; set; } = default!;

    [JsonPropertyName("canUseInDungeon")]
    public bool? CanUseInDungeon { get; set; }

    [JsonPropertyName("canUseInHomeworld")]
    public bool? CanUseInHomeworld { get; set; }

    [JsonPropertyName("canUseInRoom")]
    public bool? CanUseInRoom { get; set; }

    [JsonPropertyName("canUseInLimitRegion")]
    public bool? CanUseInLimitRegion { get; set; }

    [JsonPropertyName("canUseWhenFight")]
    public bool? CanUseWhenFight { get; set; }

    [JsonPropertyName("canUseInUnNormalMoveState")]
    public bool? CanUseInUnNormalMoveState { get; set; }

    [JsonPropertyName("canUseInAvatarFocus")]
    public bool? CanUseInAvatarFocus { get; set; }

    [JsonPropertyName("canUseWhenCurrentAvatarDead")]
    public bool? CanUseWhenCurrentAvatarDead { get; set; }

    [JsonPropertyName("DCKLEMKIEHA")]
    public string DCKLEMKIEHA { get; set; } = default!;
}