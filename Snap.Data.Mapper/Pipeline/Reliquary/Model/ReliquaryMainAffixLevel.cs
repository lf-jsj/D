using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Snap.Data.Mapper.Pipeline.Reliquary.Model;

public class ReliquaryMainAffixLevel
{
    public ItemQuality Quality { get; set; }
    public int Level { get; set; }

    [JsonConverter(typeof(StringEnumDictionaryConverter<FightProperty, double>))]
    public IDictionary<FightProperty, double> Properties { get; set; } = default!;
}