namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;
public class ExpeditionActivityMarkerExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("posX")]
    public float PosX { get; set; }

    [JsonPropertyName("posY")]
    public float PosY { get; set; }

    [JsonPropertyName("pictureHashPre")]
    public HashSuffix PictureHashPre { get; set; }

    [JsonPropertyName("pictureHashSuffix")]
    public HashPre PictureHashSuffix { get; set; }
}