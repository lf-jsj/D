namespace Snap.Data.Mapper.Model.ExcelBinOutput;

public class BirthdayMailExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("mailId")]
    public int MailId { get; set; }

    [JsonPropertyName("rewardId")]
    public int RewardId { get; set; }

    [JsonPropertyName("effectiveDate")]
    public string EffectiveDate { get; set; } = default!;

    [JsonPropertyName("GCNBOOLMGAI")]
    public int GCNBOOLMGAI { get; set; }
}
