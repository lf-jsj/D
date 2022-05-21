namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;

public class ExpeditionDataExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("openConditionVec")]
    public IList<TypeParaPJNLDIOJPGB> OpenConditionVec { get; set; } = default!;

    [JsonPropertyName("timeRewardVec")]
    public IList<TimeReward> TimeRewardVec { get; set; } = default!;

    [JsonPropertyName("descriptionTextMapHash")]
    public Text DescriptionTextMapHash { get; set; }

    [JsonPropertyName("picture")]
    public string Picture { get; set; } = default!;

    [JsonPropertyName("posX")]
    public double PosX { get; set; }

    [JsonPropertyName("posY")]
    public double PosY { get; set; }
}
