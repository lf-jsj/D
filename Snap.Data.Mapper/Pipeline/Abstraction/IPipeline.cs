using Snap.Data.Mapper.Core.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper.Pipeline.Abstraction;
internal interface IPipeline
{
    public void Run(string genshinDataFolder, string outputFolder, JsonSerializerOptions options);

    public static string GetOutputPathByName(string outputFolder, string excelName)
    {
        return Path.Combine(outputFolder, $"{excelName}.json");
    }

    public static IEnumerable<T> GetData<T>(string genshinDataFolder, JsonSerializerOptions options)
        where T : class
    {
        string path = Path.Combine(genshinDataFolder, "ExcelBinOutput", $"{typeof(T).Name}.json");
        FileStream stream = File.OpenRead(path);
        IEnumerable<T>? data = JsonSerializer.Deserialize<IEnumerable<T>>(stream, options);
        return Must.NotNull(data!);
    }

    public static IDictionary<int, T> GetMap<T>(string genshinDataFolder, JsonSerializerOptions options, Func<T, int> keySelector)
        where T : class
    {
        return GetData<T>(genshinDataFolder, options).ToDictionary(keySelector, x => x);
    }

    public static void GenerateFile<T>(object data, string outputFolder, JsonSerializerOptions options)
    {
        using (FileStream stream = File.Create(GetOutputPathByName(outputFolder, typeof(T).Name)))
        {
            JsonSerializer.Serialize(stream, data, options);
        }
    }

    public static void GenerateFile(string name, object data, string outputFolder, JsonSerializerOptions options)
    {
        using (FileStream stream = File.Create(GetOutputPathByName(outputFolder, name)))
        {
            JsonSerializer.Serialize(stream, data, options);
        }
    }
}
