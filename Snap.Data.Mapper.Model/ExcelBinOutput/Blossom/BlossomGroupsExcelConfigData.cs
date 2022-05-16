namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class BlossomGroupsExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("sectionId")]
    public int SectionId { get; set; }

    [JsonPropertyName("refreshTypeVec")]
    public IList<int> RefreshTypeVec { get; set; } = default!;

    [JsonPropertyName("newGroupVec")]
    public IList<int> NewGroupVec { get; set; } = default!;

    [JsonPropertyName("decorateGroupVec")]
    public IList<int> DecorateGroupVec { get; set; } = default!;

    [JsonPropertyName("nextCampIdVec")]
    public IList<int> NextCampIdVec { get; set; } = default!;

    [JsonPropertyName("isSafe")]
    public bool IsSafe { get; set; }

    [JsonPropertyName("isInitialRefresh")]
    public bool IsInitialRefresh { get; set; }

    [JsonPropertyName("finishProgress")]
    public int FinishProgress { get; set; }

    [JsonPropertyName("limitLevel")]
    public int LimitLevel { get; set; }

    [JsonPropertyName("fightRadius")]
    public int FightRadius { get; set; }

    [JsonPropertyName("remindRadius")]
    public int RemindRadius { get; set; }

    [JsonPropertyName("blossomTipsTextMapHash")]
    public Text BlossomTipsTextMapHash { get; set; }

    [JsonPropertyName("delayUnloadSec")]
    public int? DelayUnloadSec { get; set; }
}