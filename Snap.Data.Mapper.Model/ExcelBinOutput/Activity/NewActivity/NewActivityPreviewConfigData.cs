namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.NewActivity;

public class NewActivityPreviewConfigData : DataObject
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

    [JsonPropertyName("JBPGHGIDBPH")]
    public int JBPGHGIDBPH { get; set; }

    [JsonPropertyName("FKAGKHJNBBG")]
    public IList<int> FKAGKHJNBBG { get; set; } = default!;

    [JsonPropertyName("IIKDBEPCLBD")]
    public IList<int> IIKDBEPCLBD { get; set; } = default!;

    [JsonPropertyName("DOPBCALBEKH")]
    public int DOPBCALBEKH { get; set; }

    [JsonPropertyName("pushTipsID")]
    public int PushTipsID { get; set; }

    [JsonPropertyName("CMGFABFOILB")]
    public IList<int> CMGFABFOILB { get; set; } = default!;

    [JsonPropertyName("KGAFIIEIDIN")]
    public IList<int> KGAFIIEIDIN { get; set; } = default!;
}