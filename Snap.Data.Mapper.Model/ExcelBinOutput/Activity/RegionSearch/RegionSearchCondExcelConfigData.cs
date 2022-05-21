using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.RegionSearch;

public class RegionSearchCondExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("searchNameTextMapHash")]
    public Text SearchNameTextMapHash { get; set; }

    [JsonPropertyName("searchDescTextMapHash")]
    public Text SearchDescTextMapHash { get; set; }

    [JsonPropertyName("searchMapDescTextMapHash")]
    public Text SearchMapDescTextMapHash { get; set; }

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("logicType")]
    public string LogicType { get; set; } = default!;

    [JsonPropertyName("cond")]
    public IList<TypeParam<int>> Cond { get; set; } = default!;

    [JsonPropertyName("regionList")]
    public IList<int> RegionList { get; set; } = default!;

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("totalProgress")]
    public int TotalProgress { get; set; }

    [JsonPropertyName("reminderId")]
    public int ReminderId { get; set; }
}
