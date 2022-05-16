namespace Snap.Data.Mapper.Model.ExcelBinOutput.Forge;

public class ForgeUpdateExcelConfigData : DataObject
{
    [JsonPropertyName("playerLevel")]
    public int PlayerLevel { get; set; }

    [JsonPropertyName("forgeQueueNum")]
    public int ForgeQueueNum { get; set; }
}