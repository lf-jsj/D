namespace Snap.Data.Mapper.Model.ExcelBinOutput.PSActivity;

public class PSActivitiesTaskConfigData : DataObject
{
    [JsonPropertyName("activityID")]
    public int ActivityID { get; set; }

    [JsonPropertyName("taskNameTextMapHash")]
    public Text TaskNameTextMapHash { get; set; }

    [JsonPropertyName("isRequiredForCompletion")]
    public bool IsRequiredForCompletion { get; set; }

    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("objectID")]
    public string ObjectID { get; set; } = default!;

    [JsonPropertyName("KJJCPPOLEJN")]
    public string KJJCPPOLEJN { get; set; } = default!;

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }
}