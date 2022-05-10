using Snap.Data.Mapper.Converter.ObjectModel;

namespace Snap.Data.Mapper.Model.ExcelBinOutput.Activity.Hachi;
public class ActivityHachiFinalStageExcelConfigData : DataObject
{
    [JsonPropertyName("Id")]
    public int Id { get; set; }

    [JsonPropertyName("stageId")]
    public int StageId { get; set; }

    [JsonPropertyName("questId")]
    public IList<int> QuestId { get; set; } = default!;

    [JsonPropertyName("OOEKFJJGENL")]
    public Text OOEKFJJGENL { get; set; }

    [JsonPropertyName("JBMDLNOPANB")]
    public Text JBMDLNOPANB { get; set; }

    [JsonPropertyName("IOHHHLHHGOB")]
    public Text IOHHHLHHGOB { get; set; }

    [JsonPropertyName("OPIGDLKPNGL")]
    public Text OPIGDLKPNGL { get; set; }

    [JsonPropertyName("dungeonId")]
    public int DungeonId { get; set; }

    [JsonPropertyName("watcherIdList")]
    public IList<int> WatcherIdList { get; set; } = default!;

    [JsonPropertyName("openDay")]
    public int OpenDay { get; set; }

    [JsonPropertyName("PGKHEIDOFPP")]
    public IList<int> PGKHEIDOFPP { get; set; } = default!;

    [JsonPropertyName("HIPJDDGPAAL")]
    public int HIPJDDGPAAL { get; set; }
}
