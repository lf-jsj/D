using Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Reliquary.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Reliquary;

public class ReliquaryAffixGenerator
{
    private readonly string outputFolder;
    private readonly JsonSerializerOptions options;
    private readonly IEnumerable<ReliquaryAffixExcelConfigData> reliquaryAffixes;

    public ReliquaryAffixGenerator(string outputFolder, JsonSerializerOptions options, IEnumerable<ReliquaryAffixExcelConfigData> reliquaryAffixes)
    {
        this.outputFolder = outputFolder;
        this.options = options;
        this.reliquaryAffixes = reliquaryAffixes;
    }

    public void Generate()
    {
        IEnumerable<ReliquaryAffix> resultCache = reliquaryAffixes
            .Select(r =>
            {
                return new ReliquaryAffix
                {
                    Id = r.Id,
                    Type = r.PropType,
                    Value = r.PropValue,
                };
            });

        IPipeline.GenerateFile<ReliquaryAffix>(resultCache, outputFolder, options);
    }
}
