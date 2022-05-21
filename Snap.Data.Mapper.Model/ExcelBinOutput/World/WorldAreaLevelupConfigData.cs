using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.World;

public class WorldAreaLevelupConfigData : DataObject
{
    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("areaId")]
    public int AreaId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("consumeItem")]
    public ItemIdItemNum ConsumeItem { get; set; } = default!;

    [JsonPropertyName("actionVec")]
    public IList<TypeParam1VecParam2Vec> ActionVec { get; set; } = default!;
}