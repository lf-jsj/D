namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomGadget;

public class CusmtomGadgetSlotExcelConfigData : DataObject
{
    [JsonPropertyName("PILLKAHIACL")]
    public string PILLKAHIACL { get; set; } = default!;

    [JsonPropertyName("FLBCOKICKNH")]
    public int FLBCOKICKNH { get; set; }

    [JsonPropertyName("MPCLCJKDEFA")]
    public IList<int> MPCLCJKDEFA { get; set; } = default!;

    [JsonPropertyName("CNNOKDLHMOD")]
    public bool CNNOKDLHMOD { get; set; }

    [JsonPropertyName("NKOBFOONLNK")]
    public IList<int> NKOBFOONLNK { get; set; } = default!;

    [JsonPropertyName("LMDGLBBLLDC")]
    public IList<int> LMDGLBBLLDC { get; set; } = default!;

    [JsonPropertyName("IBBGJOMLEIO")]
    public int IBBGJOMLEIO { get; set; }
}
