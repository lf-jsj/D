using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.Common.Param;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.City;

public class CityLevelupConfigData : DataObject
{
    [JsonPropertyName("sceneId")]
    public int SceneId { get; set; }

    [JsonPropertyName("cityId")]
    public int CityId { get; set; }

    [JsonPropertyName("level")]
    public int Level { get; set; }

    [JsonPropertyName("consumeItem")]
    public ItemIdItemNum ConsumeItem { get; set; } = default!;

    [JsonPropertyName("rewardID")]
    public int RewardID { get; set; }

    [JsonPropertyName("actionVec")]
    public IList<TypeParam1VecParam2Vec> ActionVec { get; set; } = default!;
}
