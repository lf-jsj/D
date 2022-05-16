namespace Snap.Data.Mapper.Model.ExcelBinOutput.CustomLevel;

public class CustomLevelComponentTypeConfigData : DataObject
{
    [JsonPropertyName("typeID")]
    public int TypeID { get; set; }

    [JsonPropertyName("typeNameTextMapHash")]
    public Text TypeNameTextMapHash { get; set; }
}
