namespace Snap.Data.Mapper.Model.ExcelBinOutput.PSActivity;

public class PSActivitiesSubTaskConfigData : DataObject
{
    [JsonPropertyName("taskID")]
    public int TaskID { get; set; }

    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("objectID")]
    public string ObjectID { get; set; } = default!;

    [JsonPropertyName("KJJCPPOLEJN")]
    public string KJJCPPOLEJN { get; set; } = default!;

    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }
}