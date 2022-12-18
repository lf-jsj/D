namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.LanV2.Projection;

public class LanV2ProjectionLevelExcelConfigData : DataObject
{
    [JsonPropertyName("levelId")]
    public int LevelId { get; set; }

    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("watcherId")]
    public int WatcherId { get; set; }

    [JsonPropertyName("levelNameTextMapHash")]
    public Text LevelNameTextMapHash { get; set; }

    [JsonPropertyName("LIAFBKJOGEK")]
    public string LIAFBKJOGEK { get; set; } = default!;

    [JsonPropertyName("HEGCEHCAHBN")]
    public string HEGCEHCAHBN { get; set; } = default!;

    [JsonPropertyName("LDPNKDIOJNG")]
    public float LDPNKDIOJNG { get; set; }

    [JsonPropertyName("GFBMGGLELPI")]
    public float GFBMGGLELPI { get; set; }

    [JsonPropertyName("AJHLEOFEMPB")]
    public float AJHLEOFEMPB { get; set; }

    [JsonPropertyName("LCAFPFMJINI")]
    public int LCAFPFMJINI { get; set; }

    [JsonPropertyName("FPLKJFKMPBE")]
    public IList<float> FPLKJFKMPBE { get; set; } = default!;

    [JsonPropertyName("LKNBJNEPOCA")]
    public IList<float> LKNBJNEPOCA { get; set; } = default!;

    [JsonPropertyName("DBNDOHDIPLP")]
    public IList<DataObject> DBNDOHDIPLP { get; set; } = default!;

    [JsonPropertyName("MAHGDJEOCOA")]
    public IList<float> MAHGDJEOCOA { get; set; } = default!;

    [JsonPropertyName("IAFPHHKNPPG")]
    public IList<float> IAFPHHKNPPG { get; set; } = default!;

    [JsonPropertyName("LBEGJEAJPGD")]
    public IList<IList<int>> LBEGJEAJPGD { get; set; } = default!;

    [JsonPropertyName("NDJNONIKHOK")]
    public IList<NDJNONIKHOK> NDJNONIKHOK { get; set; } = default!;

    [JsonPropertyName("GGNPFLFKGBD")]
    public int? GGNPFLFKGBD { get; set; }

    [JsonPropertyName("NGBCCIEJLAH")]
    public string NGBCCIEJLAH { get; set; } = default!;

    [JsonPropertyName("NFMAMKGFCCI")]
    public float? NFMAMKGFCCI { get; set; }
}