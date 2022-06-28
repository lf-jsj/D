using Microsoft;
using Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Reliquary;

public class ReliquaryGenerator
{
    private readonly string outputFolder;
    private readonly JsonSerializerOptions options;
    private readonly IEnumerable<ReliquaryExcelConfigData> reliquaries;

    public ReliquaryGenerator(
        string outputFolder,
        JsonSerializerOptions options,
        IEnumerable<ReliquaryExcelConfigData> reliquaries)
    {
        this.outputFolder = outputFolder;
        this.options = options;

        this.reliquaries = reliquaries;
    }

    public void Generate()
    {
        IEnumerable<Model.Reliquary> resultCache = reliquaries

            // filter out no set relics
            .Where(x => x.SetId.HasValue)
            .Where(x => x.SetId != 15000)

            .GroupBy(x => $"{x.SetId!.Value}-{x.EquipType}")
            
            .Select(r =>
            {
                ReliquaryExcelConfigData first = r.First();

                Verify.Operation(r.DistinctBy(relic => relic.SetId).Count() == 1, "套装出现不同");

                return new Model.Reliquary
                {
                    EquipType = first.EquipType,
                    RankLevels = r.Select(relic => relic.RankLevel).Distinct().OrderBy(x => x),
                    Ids = r.Select(relic => relic.Id),
                    Name = first.NameTextMapHash.Value,
                    Description = first.DescTextMapHash.Value,
                    Icon = first.Icon,
                    ItemType = first.ItemType,
                    SetId = first.SetId!.Value,
                };
            });

        IPipeline.GenerateFile<Model.Reliquary>(resultCache, outputFolder, options);
    }
}
