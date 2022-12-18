namespace Snap.Data.Mapper.Model.ExcelBinOutput.LevelTag;
public class LevelTagExcelConfigData : DataObject
{
    [JsonPropertyName("ID")]
    public int ID { get; set; }

    [JsonPropertyName("NFBBPIEEBAJ")]
    public string NFBBPIEEBAJ { get; set; } = default!;

    [JsonPropertyName("LJAACEPDCBK")]
    public IList<int> LJAACEPDCBK { get; set; } = default!;

    [JsonPropertyName("KFLODNLKHFF")]
    public IList<int> KFLODNLKHFF { get; set; } = default!;

    [JsonPropertyName("EACLGGPNALJ")]
    public int EACLGGPNALJ { get; set; }

    [JsonPropertyName("PDHCLCEOPDB")]
    public float PDHCLCEOPDB { get; set; }
}