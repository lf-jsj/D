using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
using Snap.Data.Mapper.Pipeline.Abstraction;
using Snap.Data.Mapper.Pipeline.Model;
using Snap.Data.Mapper.Pipeline.Reliquary.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Reliquary;

public class ReliquarySetGenerator
{
    private readonly string outputFolder;
    private readonly string simpleFolder;
    private readonly JsonSerializerOptions options;

    private readonly IEnumerable<ReliquarySetExcelConfigData> requarySets;
    private readonly IDictionary<int, IEnumerable<EquipAffixExcelConfigData>> equipAffixMap;

    public ReliquarySetGenerator(
        string outputFolder,
        string simpleFolder,
        JsonSerializerOptions options,
        IEnumerable<ReliquarySetExcelConfigData> requarySets,
        IDictionary<int, IEnumerable<EquipAffixExcelConfigData>> equipAffixMap)
    {
        this.outputFolder = outputFolder;
        this.simpleFolder = simpleFolder;
        this.options = options;
        this.requarySets = requarySets;
        this.equipAffixMap = equipAffixMap;
    }

    public void Generate()
    {
        IEnumerable<ReliquarySet> resultCache = requarySets

            // filter out useless sets
            .Where(x => x.EquipAffixId != 0)

            .Select(r =>
            {
                List<EquipAffixExcelConfigData> equipAffixDatas = equipAffixMap[r.EquipAffixId].ToList();

                return new ReliquarySet
                {
                    SetId = r.SetId,
                    EquipAffixId = r.EquipAffixId,
                    NeedNumber = r.SetNeedNum,
                    Icon = r.SetIcon,
                    Name = equipAffixDatas[0].NameTextMapHash.Value,
                    Descriptions = equipAffixDatas.Select(data => data.DescTextMapHash.Value),
                };
            });

        IPipeline.GenerateFile<ReliquarySet>(resultCache, outputFolder, options);

        IEnumerable<IdName> simpleIdNames = requarySets
            .Where(x => x.EquipAffixId != 0)
            .Select(r =>
            {
                List<EquipAffixExcelConfigData> equipAffixDatas = equipAffixMap[r.EquipAffixId].ToList();
                return new IdName(r.EquipAffixId, equipAffixDatas[0].NameTextMapHash.Value);
            });
        IPipeline.GenerateFile("ReliquarySet", simpleIdNames, simpleFolder, options);
    }
}
