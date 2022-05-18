namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class MailExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("expireDays")]
    public int ExpireDays { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("contentTextMapHash")]
    public Text ContentTextMapHash { get; set; }

    [JsonPropertyName("senderTextMapHash")]
    public Text SenderTextMapHash { get; set; }

    [JsonPropertyName("isStar")]
    public bool? IsStar { get; set; }

    [JsonPropertyName("rewardId")]
    public int? RewardId { get; set; }
}