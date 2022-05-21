namespace Snap.Data.Mapper.Model.Common;

public class MaterialIdMaterialNum : DataObject
{
    [JsonPropertyName("materialId")]
    public int MaterialId { get; set; }

    [JsonPropertyName("materialNum")]
    public int MaterialNum { get; set; }
}
