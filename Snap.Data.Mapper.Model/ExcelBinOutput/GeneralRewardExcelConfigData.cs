namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class GeneralRewardExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("useCondenseResin")]
    public bool UseCondenseResin { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("staminaEnoughTextMapHash")]
    public Text StaminaEnoughTextMapHash { get; set; }

    [JsonPropertyName("staminaLessTextMapHash")]
    public Text StaminaLessTextMapHash { get; set; }

    [JsonPropertyName("condenseResinStaminaEnoughTextMapHash")]
    public Text CondenseResinStaminaEnoughTextMapHash { get; set; }

    [JsonPropertyName("condenseResinStaminaLessTextMapHash")]
    public Text CondenseResinStaminaLessTextMapHash { get; set; }

    [JsonPropertyName("usingActivityCoinTextMapHash")]
    public Text UsingActivityCoinTextMapHash { get; set; }

    [JsonPropertyName("usingActivityCoinButtonTextMapHash")]
    public Text UsingActivityCoinButtonTextMapHash { get; set; }

    [JsonPropertyName("confirmTextMapHash")]
    public Text ConfirmTextMapHash { get; set; }

    [JsonPropertyName("resinMonthlyTextMapHash")]
    public Text ResinMonthlyTextMapHash { get; set; }

    [JsonPropertyName("insufficientTextMapHash")]
    public Text InsufficientTextMapHash { get; set; }

    [JsonPropertyName("insufficientUseitemTextMapHash")]
    public Text InsufficientUseitemTextMapHash { get; set; }

    [JsonPropertyName("condenseResinTextMapHash")]
    public Text CondenseResinTextMapHash { get; set; }

    [JsonPropertyName("rewardSourceSystem")]
    public string RewardSourceSystem { get; set; } = default!;

    [JsonPropertyName("rewardSourceSystemPara")]
    public int? RewardSourceSystemPara { get; set; }
}
