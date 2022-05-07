using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Model.Achievement;

public class TriggerConfig
{

    [JsonPropertyName("triggerType")]
    public string TriggerType { get; set; } = default!;

    [JsonPropertyName("paramList")]
    public IList<string> ParamList { get; set; } = default!;
}
