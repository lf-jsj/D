namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Roguelike;

public class RogueDungeonCellExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("OLDABJHNHBM")]
    public int OLDABJHNHBM { get; set; }

    [JsonPropertyName("JIIPMPOBKMO")]
    public IList<double> JIIPMPOBKMO { get; set; } = default!;

    [JsonPropertyName("BGAOFCDEIEL")]
    public IList<int> BGAOFCDEIEL { get; set; } = default!;

    [JsonPropertyName("MKKIOHPOHAI")]
    public IList<int> MKKIOHPOHAI { get; set; } = default!;

    [JsonPropertyName("groupId")]
    public int GroupId { get; set; }

    [JsonPropertyName("LPICDCKJPFJ")]
    public int LPICDCKJPFJ { get; set; }

    [JsonPropertyName("IPDLBPNMJCL")]
    public double IPDLBPNMJCL { get; set; }

    [JsonPropertyName("EKFFFOGEEJD")]
    public double EKFFFOGEEJD { get; set; }

    [JsonPropertyName("OOPPJMDHFON")]
    public double OOPPJMDHFON { get; set; }

    [JsonPropertyName("FBAOPAKKDGL")]
    public string FBAOPAKKDGL { get; set; } = default!;

    [JsonPropertyName("KKPACBEHBII")]
    public bool? KKPACBEHBII { get; set; }
}