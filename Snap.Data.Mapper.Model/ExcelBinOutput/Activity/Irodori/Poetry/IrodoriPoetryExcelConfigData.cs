namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Poetry;

public class IrodoriPoetryExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("condID")]
    public int CondID { get; set; }

    [JsonPropertyName("ADDBGMNKJKP")]
    public int ADDBGMNKJKP { get; set; }

    [JsonPropertyName("LKFNFPEJPJA")]
    public int LKFNFPEJPJA { get; set; }

    [JsonPropertyName("entityType")]
    public string EntityType { get; set; } = default!;

    [JsonPropertyName("BCJEKDFOFNH")]
    public IList<BCJEKDFOFNH> BCJEKDFOFNH { get; set; } = default!;

    [JsonPropertyName("MOIKHOIHHBA")]
    public int MOIKHOIHHBA { get; set; }

    [JsonPropertyName("OEGHEIKILCP")]
    public int OEGHEIKILCP { get; set; }

    [JsonPropertyName("BAECGADCJAI")]
    public int BAECGADCJAI { get; set; }

    [JsonPropertyName("HCHLNGPHOII")]
    public IList<int> HCHLNGPHOII { get; set; } = default!;

    [JsonPropertyName("watcherID")]
    public int WatcherID { get; set; }

    [JsonPropertyName("LLGILBEKLOG")]
    public Text LLGILBEKLOG { get; set; }

    [JsonPropertyName("CKMFBPDFIHD")]
    public Text CKMFBPDFIHD { get; set; }

    [JsonPropertyName("DBAEEGCGDOD")]
    public Text DBAEEGCGDOD { get; set; }

    [JsonPropertyName("NACGHDPJPEI")]
    public Text NACGHDPJPEI { get; set; }

    [JsonPropertyName("BODDKBIEEJF")]
    public IList<int> BODDKBIEEJF { get; set; } = default!;
}
