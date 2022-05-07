using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Model;
using Snap.Data.Visualizer.Core;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Snap.Data.Visualizer.Binary.ExcelBinOutput;
internal class AbilityOverrideExcelConfigDataHandler : IExcelBinOutputHandler
{
    private readonly string output;  
    private readonly Dictionary<string, IList<string>> keyDict = new();
    private readonly IList<KeyValuePair<string, IList<string>>> keyEnumerations;

    public AbilityOverrideExcelConfigDataHandler(string rootPath)
    {
        Stream stream = File.OpenRead(Path.Combine(rootPath, "AbilityOverrideExcelConfigData.json"));
        IList<AbilityOverrideExcelConfigData>? data = JsonContext.ToObject<IList<AbilityOverrideExcelConfigData>>(stream);

        foreach(AbilityOverrideExcelConfigData dataItem in data!)
        {
            foreach (PropertyInfo property in dataItem.GetType().GetProperties())
            {
                if (property.PropertyType == typeof(string))
                {
                    if (!keyDict.ContainsKey(property.Name))
                    {
                        keyDict.Add(property.Name, new List<string>());
                    }

                    keyDict[property.Name].Add((string)property.GetValue(dataItem)!);
                }
            }
        }


        foreach ((string key, IList<string> enums) in keyDict)
        {
            keyDict[key] = enums.Distinct().ToList();
        }

        keyEnumerations = keyDict.ToList();
        output = JsonContext.Stringify(data);
    }

    public string Name => "AbilityOverrideExcelConfigData";
    public IList<KeyValuePair<string, IList<string>>> KeyEnumerations { get => keyEnumerations; }
    public string Output { get => output; }
}
