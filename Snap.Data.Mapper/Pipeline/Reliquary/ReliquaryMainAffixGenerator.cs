using Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Reliquary.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Reliquary;

public class ReliquaryMainAffixGenerator
{
    private readonly string outputFolder;
    private readonly JsonSerializerOptions options;
    private readonly IEnumerable<ReliquaryMainPropExcelConfigData> reliquaryMainAffixes;

    public ReliquaryMainAffixGenerator(
        string outputFolder,
        JsonSerializerOptions options,
        IEnumerable<ReliquaryMainPropExcelConfigData> reliquaryMainAffixes)
    {
        this.outputFolder = outputFolder;
        this.options = options;

        this.reliquaryMainAffixes = reliquaryMainAffixes;
    }

    public void Generate()
    {
        IEnumerable<ReliquaryMainAffix> resultCache = reliquaryMainAffixes
            .Select(r =>
            {
                return new ReliquaryMainAffix
                {
                    Id = r.Id,
                    Type = r.PropType,
                };
            });

        IPipeline.GenerateFile<ReliquaryMainAffix>(resultCache, outputFolder, options);
    }
}
