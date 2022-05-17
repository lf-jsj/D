namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Irodori.Chess;

public class IrodoriChessDisorderExcelConfigData : DataObject
{
    [JsonPropertyName("HPMDDBLDJCO")]
    public int HPMDDBLDJCO { get; set; }

    [JsonPropertyName("descTextMapHash")]
    public Text DescTextMapHash { get; set; }
}