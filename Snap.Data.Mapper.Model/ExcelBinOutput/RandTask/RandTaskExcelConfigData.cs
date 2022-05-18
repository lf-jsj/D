namespace Snap.Data.Mapper.Model.ExcelBinOutput.RandTask;
public class RandTaskExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("titleTextMapHash")]
    public Text TitleTextMapHash { get; set; }

    [JsonPropertyName("contentType")]
    public string ContentType { get; set; } = default!;

    [JsonPropertyName("reward")]
    public int Reward { get; set; }

    [JsonPropertyName("targetTextMapHash")]
    public Text TargetTextMapHash { get; set; }

    [JsonPropertyName("enterDistance")]
    public int EnterDistance { get; set; }

    [JsonPropertyName("exitDistance")]
    public int ExitDistance { get; set; }

    [JsonPropertyName("needUI")]
    public bool? NeedUI { get; set; }
}