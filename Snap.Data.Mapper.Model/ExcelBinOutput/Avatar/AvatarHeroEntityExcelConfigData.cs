namespace Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;

public class AvatarHeroEntityExcelConfigData : DataObject
{
    [JsonPropertyName("avatarId")]
    public int AvatarId { get; set; }

    [JsonPropertyName("prefabPathHashSuffix")]
    public HashSuffix PrefabPathHashSuffix { get; set; }

    [JsonPropertyName("prefabPathHashPre")]
    public HashPre PrefabPathHashPre { get; set; }

    [JsonPropertyName("coopPicNameHashSuffix")]
    public HashSuffix CoopPicNameHashSuffix { get; set; }

    [JsonPropertyName("coopPicNameHashPre")]
    public HashPre CoopPicNameHashPre { get; set; }
}
