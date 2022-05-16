namespace Snap.Data.Mapper.Model.ExcelBinOutput.Blossom;

public class BlossomRefreshExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = default!;

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("refreshType")]
    public string RefreshType { get; set; } = default!;

    [JsonPropertyName("refreshCount")]
    public int RefreshCount { get; set; }

    [JsonPropertyName("refreshTime")]
    [JsonConverter(typeof(TimeOnlyConverter))]
    public TimeOnly RefreshTime { get; set; }

    [JsonPropertyName("refreshCondVec")]
    public IList<RefreshCondVec> RefreshCondVec { get; set; } = default!;

    [JsonPropertyName("reviseLevel")]
    public int ReviseLevel { get; set; }

    [JsonPropertyName("blossomChestId")]
    public int BlossomChestId { get; set; }

    [JsonPropertyName("campUpdateNeedCount")]
    public int CampUpdateNeedCount { get; set; }

    [JsonPropertyName("dropVec")]
    public IList<DropVec> DropVec { get; set; } = default!;

    [JsonPropertyName("clientShowType")]
    public string ClientShowType { get; set; } = default!;

    [JsonPropertyName("itemLimitType")]
    public string ItemLimitType { get; set; } = default!;

    [JsonPropertyName("rewardType")]
    public string RewardType { get; set; } = default!;

    [JsonPropertyName("HJANDDPICPH")]
    public bool? HJANDDPICPH { get; set; }
}