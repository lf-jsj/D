namespace Snap.Data.Mapper.Model.ExcelBinOutput.PSActivity;
public class PSActivitiesActivityConfigData : DataObject
{
    [JsonPropertyName("activityNameTextMapHash")]
    public Text ActivityNameTextMapHash { get; set; }

    [JsonPropertyName("activityDescTextMapHash")]
    public Text ActivityDescTextMapHash { get; set; }

    [JsonPropertyName("availableByDefault")]
    public bool AvailableByDefault { get; set; }

    [JsonPropertyName("isRequiredForCompletion")]
    public bool IsRequiredForCompletion { get; set; }

    [JsonPropertyName("largeIcon")]
    public string LargeIcon { get; set; } = default!;

    [JsonPropertyName("smallIcon")]
    public string SmallIcon { get; set; } = default!;

    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("objectID")]
    public string ObjectID { get; set; } = default!;

    [JsonPropertyName("KJJCPPOLEJN")]
    public string KJJCPPOLEJN { get; set; } = default!;
}