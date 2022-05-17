namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Master;
public class IrodoriMasterExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("levelID")]
    public int LevelID { get; set; }

    [JsonPropertyName("FBCBFLICJMO")]
    public string FBCBFLICJMO { get; set; } = default!;

    [JsonPropertyName("LKFNFPEJPJA")]
    public int LKFNFPEJPJA { get; set; }

    [JsonPropertyName("watcherList")]
    public IList<int> WatcherList { get; set; } = default!;

    [JsonPropertyName("GPKLLIFFBJC")]
    public int GPKLLIFFBJC { get; set; }

    [JsonPropertyName("EBEGCCOEILP")]
    public int EBEGCCOEILP { get; set; }

    [JsonPropertyName("condID")]
    public int CondID { get; set; }

    [JsonPropertyName("COMLHLEFJNF")]
    public int COMLHLEFJNF { get; set; }

    [JsonPropertyName("OIKNLDIHHMJ")]
    public int OIKNLDIHHMJ { get; set; }

    [JsonPropertyName("EPCMIMAKCDM")]
    public Text EPCMIMAKCDM { get; set; }

    [JsonPropertyName("BOCNPOOFIDD")]
    public Text BOCNPOOFIDD { get; set; }

    [JsonPropertyName("NDDJHCDFKHC")]
    public int? NDDJHCDFKHC { get; set; }
}
