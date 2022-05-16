namespace Snap.Data.Mapper.Model.ExcelBinOutput.Homeworld;

public class HomeWorldEventExcelConfigData : DataObject
{
    [JsonPropertyName("FDNMLHMAOHC")]
    public int FDNMLHMAOHC { get; set; }

    [JsonPropertyName("PHOLAKENMKP")]
    public string PHOLAKENMKP { get; set; } = default!;

    [JsonPropertyName("avatarID")]
    public int AvatarID { get; set; }

    [JsonPropertyName("EHNGKNKEBPA")]
    public int EHNGKNKEBPA { get; set; }

    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("HPALHFLLKLA")]
    public int HPALHFLLKLA { get; set; }

    [JsonPropertyName("order")]
    public int Order { get; set; }

    [JsonPropertyName("FDDMNLGKNPA")]
    public int? FDDMNLGKNPA { get; set; }
}