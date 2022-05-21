namespace Snap.Data.Mapper.Model.ExcelBinOutput.Quest;
public class QuestAcceptionMarkExcelConfigData : DataObject
{
    [JsonPropertyName("configId")]
    public int ConfigId { get; set; }

    [JsonPropertyName("GFCACOAAENN")]
    public int GFCACOAAENN { get; set; }

    [JsonPropertyName("npcId")]
    public int NpcId { get; set; }

    [JsonPropertyName("KGOFCCNDBGB")]
    public bool KGOFCCNDBGB { get; set; }

    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("JHPOFDOKCLH")]
    public IList<double> JHPOFDOKCLH { get; set; } = default!;

    [JsonPropertyName("DOBKNHBFMGP")]
    public bool DOBKNHBFMGP { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public long DescTextMapHash { get; set; }

    [JsonPropertyName("KMGBIFKMEBK")]
    public long KMGBIFKMEBK { get; set; }
}
