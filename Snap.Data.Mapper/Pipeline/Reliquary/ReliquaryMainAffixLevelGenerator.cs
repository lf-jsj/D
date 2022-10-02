using Snap.Data.Mapper.Model.ExcelBinOutput.Avatar;
using Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Reliquary.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Reliquary;

internal class ReliquaryMainAffixLevelGenerator
{
    private readonly string outputFolder;
    private readonly JsonSerializerOptions options;
    private readonly IEnumerable<ReliquaryLevelExcelConfigData> reliquaryLevelExcelConfigData;
    public ReliquaryMainAffixLevelGenerator(
        string outputFolder,
        JsonSerializerOptions options,
        IEnumerable<ReliquaryLevelExcelConfigData> reliquaryLevelExcelConfigData)
    {
        this.outputFolder = outputFolder;
        this.options = options;

        this.reliquaryLevelExcelConfigData = reliquaryLevelExcelConfigData;
    }

    public void Generate()
    {
        IEnumerable<ReliquaryMainAffixLevel> resultCache = reliquaryLevelExcelConfigData
            .Select(r =>
            {
                return new ReliquaryMainAffixLevel
                {
                    Quality = (ItemQuality)(r.Rank ?? 0),
                    Level = r.Level,
                    Properties = r.AddProps.ToDictionary(x => x.PropType, x => x.Value!.Value),
                };
            })
            .Skip(1);

        IPipeline.GenerateFile<ReliquaryMainAffixLevel>(resultCache, outputFolder, options);
    }
}