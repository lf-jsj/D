namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Michiae;

public class MichiaePreviewExcelConfigData : DataObject
{
    [JsonPropertyName("activityID")]
    public int ActivityID { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }

    [JsonPropertyName("PKBOKNLIGPM")]
    public Text PKBOKNLIGPM { get; set; }

    [JsonPropertyName("CEOCNAMIKDK")]
    public Text CEOCNAMIKDK { get; set; }

    [JsonPropertyName("rewardPreviewID")]
    public int RewardPreviewID { get; set; }

    [JsonPropertyName("pushTipsID")]
    public int PushTipsID { get; set; }

    [JsonPropertyName("EBDIGCAOGBG")]
    public int EBDIGCAOGBG { get; set; }

    [JsonPropertyName("CMALDGFOBPO")]
    public float CMALDGFOBPO { get; set; }

    [JsonPropertyName("AFHBNOEHJFC")]
    public float AFHBNOEHJFC { get; set; }

    [JsonPropertyName("ENAAPPJHAHC")]
    public int ENAAPPJHAHC { get; set; }

    [JsonPropertyName("OKPEPAJHICP")]
    public int OKPEPAJHICP { get; set; }

    [JsonPropertyName("MGBKJBBGLEJ")]
    public int MGBKJBBGLEJ { get; set; }

    [JsonPropertyName("FGOCFNIBAFP")]
    public int FGOCFNIBAFP { get; set; }

    [JsonPropertyName("PFIOAAGIFHG")]
    public IDictionary<string, int> PFIOAAGIFHG { get; set; } = default!;

    [JsonPropertyName("KLHLGGDOMPN")]
    public IList<int> KLHLGGDOMPN { get; set; } = default!;
}