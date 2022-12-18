namespace Snap.Data.Mapper.Model.ExcelBinOutput.Expedition;

public class ExpeditionBonusExcelConfigData : DataObject
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("avatarLevel")]
    public int AvatarLevel { get; set; }

    [JsonPropertyName("probability")]
    public float Probability { get; set; }
}