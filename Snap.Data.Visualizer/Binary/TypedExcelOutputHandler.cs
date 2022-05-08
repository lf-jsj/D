using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Model.ObjectModel;
using Snap.Data.Visualizer.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Snap.Data.Visualizer.Binary;
internal abstract class TypedExcelOutputHandler<TElement> : IExcelBinOutputHandler
    where TElement : class
{
    private readonly string output;
    private readonly Dictionary<string, List<string>> keyDict = new();
    private readonly IList<KeyValuePair<string, List<string>>> keyEnumerations;

    public TypedExcelOutputHandler(string rootPath)
    {
        Stream stream = File.OpenRead(Path.Combine(rootPath, $"{typeof(TElement).Name}.json"));
        IList<TElement>? data = JsonContext.ToObject<IList<TElement>>(stream);

        TryFindEnumInEnumerable(data!,typeof(TElement).Name);

        foreach ((string key, IList<string> enums) in keyDict)
        {
            keyDict[key] = enums.Distinct().ToList();
        }

        keyEnumerations = keyDict.ToList();
        output = JsonContext.Stringify(data!);
    }

    private void TryFindEnumInEnumerable(IEnumerable data,string modelName)
    {
        foreach (object dataItem in data)
        {
            if(dataItem is null)
            {
                continue;
            }

            PropertyInfo[]? porperties = dataItem.GetType().GetProperties();
            foreach (PropertyInfo property in porperties)
            {
                string key = $"{modelName}.{property.Name}";
                TryFindEnumInObject(dataItem, property, key);
            }
        }
    }

    private void TryFindEnumInObject(object dataItem, PropertyInfo property, string key)
    {
        object? valueRef = property.GetValue(dataItem);

        if (property.PropertyType == typeof(string))
        {
            if (!keyDict.ContainsKey(key))
            {
                keyDict.Add(key, new List<string>());
            }

            keyDict[key].Add((string)valueRef!);
        }
        else if (property.PropertyType == typeof(IList<string>))
        {
            if (!keyDict.ContainsKey(key))
            {
                keyDict.Add(key, new List<string>());
            }

            keyDict[key].AddRange((IList<string>)valueRef!);
        }
        else if (property.PropertyType.IsAssignableTo(typeof(IEnumerable)))
        {
            // explore inner data structure
            string baseKey = $"{key}.{valueRef!.GetType().GetGenericArguments()[0].Name}";
            TryFindEnumInEnumerable((IEnumerable)valueRef!, baseKey);
        }
        else if (property.PropertyType.IsAssignableTo(typeof(DataModel)))
        {
            // explore inner data object
            string baseKey = $"{key}.{valueRef!.GetType().Name}";
            foreach (PropertyInfo property2 in valueRef.GetType().GetProperties())
            {
                string key2 = $"{key}.{property2.Name}";
                TryFindEnumInObject(valueRef, property2, key2);
            }
        }
    }

    public string Name { get => typeof(TElement).Name; }
    public IList<KeyValuePair<string, List<string>>> KeyEnumerations { get => keyEnumerations; }
    public string Output { get => output; }
}
