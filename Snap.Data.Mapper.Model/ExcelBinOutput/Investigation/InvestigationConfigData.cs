namespace Snap.Data.Mapper.Model.ExcelBinOutput.Investigation;
public class InvestigationConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("nextInvestigationIdList")]
    public IList<int> NextInvestigationIdList { get; set; } = default!;

    [JsonPropertyName("unlockOpenStateType")]
    public string UnlockOpenStateType { get; set; } = default!;

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("investigationType")]
    public string InvestigationType { get; set; } = default!;
}