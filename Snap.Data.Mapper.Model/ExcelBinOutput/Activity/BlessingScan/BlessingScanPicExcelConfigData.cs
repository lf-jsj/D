namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.BlessingScan;

public class BlessingScanPicExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("grantRewardCost")]
    public int GrantRewardCost { get; set; }

    [JsonPropertyName("iconName")]
    public string IconName { get; set; } = default!;

    [JsonPropertyName("nameTextMapHash")]
    public Text NameTextMapHash { get; set; }
}
