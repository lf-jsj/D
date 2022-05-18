namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Salvage;

public class SalvageStageDataExcelConfigData : DataObject
{
    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("EDOMIEDBFAI")]
    public int EDOMIEDBFAI { get; set; }

    [JsonPropertyName("PEKPFAHOMFM")]
    public int PEKPFAHOMFM { get; set; }

    [JsonPropertyName("KFNCGNDKIMJ")]
    public IList<int> KFNCGNDKIMJ { get; set; } = default!;

    [JsonPropertyName("JMHENDNCBGF")]
    public IList<int> JMHENDNCBGF { get; set; } = default!;

    [JsonPropertyName("AMBCPLADAGP")]
    public IList<DataObject> AMBCPLADAGP { get; set; } = default!;

    [JsonPropertyName("LMHILGEFALH")]
    public IList<int> LMHILGEFALH { get; set; } = default!;
}