using Microsoft;
using Snap.Data.Mapper.Model.Common;
using Snap.Data.Mapper.Model.ExcelBinOutput;
using Snap.Data.Mapper.Model.ExcelBinOutput.Reliquary;
using Snap.Data.Mapper.Pipeline.Abstraction;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Reliquary;

internal class ReliquaryPipeline : IPipeline
{
    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options)
    {
        IEnumerable<ReliquaryExcelConfigData> reliquaries = IPipeline
            .GetData<ReliquaryExcelConfigData>(genshinDataFolder, options);

        new ReliquaryGenerator(
            outputFolder,
            options,
            reliquaries)
            .Generate();

        IEnumerable<ReliquarySetExcelConfigData> requarySets = IPipeline
            .GetData<ReliquarySetExcelConfigData>(genshinDataFolder, options);

        IDictionary<int, IEnumerable<EquipAffixExcelConfigData>> equipAffixMap = IPipeline
            .GetData<EquipAffixExcelConfigData>(genshinDataFolder, options)
            .GroupBy(x => x.Id)
            .ToDictionary(group => group.Key, group => group.AsEnumerable());

        new ReliquarySetGenerator(
            outputFolder,
            options,
            requarySets,
            equipAffixMap)
            .Generate();

        IEnumerable<ReliquaryAffixExcelConfigData> reliquaryAffixes = IPipeline
            .GetData<ReliquaryAffixExcelConfigData>(genshinDataFolder, options);

        new ReliquaryAffixGenerator(
            outputFolder,
            options,
            reliquaryAffixes)
            .Generate();

        IEnumerable<ReliquaryMainPropExcelConfigData> reliquaryMainAffixes = IPipeline
            .GetData<ReliquaryMainPropExcelConfigData>(genshinDataFolder, options);

        new ReliquaryMainAffixGenerator(
            outputFolder,
            options,
            reliquaryMainAffixes)
            .Generate();
    }
}

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
        IEnumerable<Reliquary> resultCache = reliquaries

            // filter out no set relics
            .Where(x => x.SetId.HasValue)
            .Where(x => x.SetId != 15000)

            .GroupBy(x => $"{x.SetId!.Value}-{x.EquipType}")
            
            .Select(r =>
            {
                ReliquaryExcelConfigData first = r.First();

                Verify.Operation(r.DistinctBy(relic => relic.SetId).Count() == 1, "套装出现不同");

                return new Reliquary
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

        IPipeline.GenerateFile<Reliquary>(resultCache, outputFolder, options);
    }
}

public class ReliquarySetGenerator
{
    private readonly string outputFolder;
    private readonly JsonSerializerOptions options;

    private readonly IEnumerable<ReliquarySetExcelConfigData> requarySets;
    private readonly IDictionary<int, IEnumerable<EquipAffixExcelConfigData>> equipAffixMap;

    public ReliquarySetGenerator(
        string outputFolder,
        JsonSerializerOptions options,
        IEnumerable<ReliquarySetExcelConfigData> requarySets,
        IDictionary<int, IEnumerable<EquipAffixExcelConfigData>> equipAffixMap)
    {
        this.outputFolder = outputFolder;
        this.options = options;
        this.requarySets = requarySets;
        this.equipAffixMap = equipAffixMap;
    }

    public void Generate()
    {
        IEnumerable<ReliquarySet> resultCache = requarySets

            // filter out useless sets
            .Where(x => x.EquipAffixId.HasValue)

            .Select(r =>
            {
                IEnumerable<EquipAffixExcelConfigData> equipAffixDatas = equipAffixMap[r.EquipAffixId!.Value];

                return new ReliquarySet
                {
                    SetId = r.SetId,
                    NeedNumber = r.SetNeedNum,
                    Descriptions = equipAffixDatas.Select(data => data.DescTextMapHash.Value),
                };
            });

        IPipeline.GenerateFile<ReliquarySet>(resultCache, outputFolder, options);
    }
}

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

public class ReliquaryMainAffixGenerator
{
    private readonly string outputFolder;
    private readonly JsonSerializerOptions options;
    private readonly IEnumerable<ReliquaryMainPropExcelConfigData> reliquaryMainAffixes;

    public ReliquaryMainAffixGenerator(string outputFolder, JsonSerializerOptions options, IEnumerable<ReliquaryMainPropExcelConfigData> reliquaryMainAffixes)
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

public class Reliquary
{
    public EquipType EquipType { get; set; } = default!;
    public IEnumerable<int> RankLevels { get; set; } = default!;
    public IEnumerable<int> Ids { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Icon { get; set; } = default!;
    public ItemType ItemType { get; set; } = default!;
    public int SetId { get; set; }
}

public class ReliquarySet
{
    public int SetId { get; set; } = default!;
    public IEnumerable<int> NeedNumber { get; set; } = default!;
    public IEnumerable<string> Descriptions { get; set; } = default!;
}

public class ReliquaryAffix
{
    public int Id { get; set; }
    public FightProperty Type { get; set; }
    public double Value { get; set; }
}

public class ReliquaryMainAffix
{
    public int Id { get; set; }
    public FightProperty Type { get; set; }
}