// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Data.Mapper.Abstraction;
using Snap.Data.Mapper.Converter;
using Snap.Data.Mapper.TextMapping;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Snap.Data.Mapper;

/// <summary>
/// 入口点
/// </summary>
public static class Program
{
    private const string TextMapFolderName = "TextMap";

    /// <summary>
    /// 主函数
    /// </summary>
    /// <param name="args">参数</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("请输入 Dimbreath/GenshinData 的文件夹路径：");

        if (Console.ReadLine() is not string genshinDataFolder)
        {
            Console.WriteLine("文件夹不存在,按任意键退出。");
            Console.ReadKey();
            return;
        }

        string textMapFolder = Path.Combine(genshinDataFolder, TextMapFolderName);

        if (!Directory.Exists(textMapFolder))
        {
            Console.WriteLine("TextMap 文件夹不存在,按任意键退出。");
            Console.ReadKey();
            return;
        }

        List<(ITextMap TextMap, int Index)> indexedTextMap = Directory
            .GetFiles(textMapFolder)
            .Select(path => new TextMap(path))
            .Select((ITextMap map, int index) => (map, index))
            .ToList();

        foreach ((ITextMap textMap, int index) in indexedTextMap)
        {
            Console.WriteLine($"[{index,2}] {textMap.Launguage,4}");
        }

        Console.WriteLine("请选择 TextMap 的编号");
        if (!int.TryParse(Console.ReadLine(), out int inputIndex))
        {
            Console.WriteLine("超出允许选择的范围，按任意键退出。");
            Console.ReadKey();
            return;
        }

        MapperContext.TextMap = indexedTextMap[inputIndex].TextMap;
        Console.WriteLine($"选择了 {MapperContext.TextMap.Launguage}，请稍候...");
        Console.WriteLine($"TextMap[{MapperContext.TextMap.Launguage}] loaded with {MapperContext.TextMap.KeyCount} keys");

        JsonSerializerOptions jsonSerializerOptions = new();
        jsonSerializerOptions.Converters.Add(new TextMapHashConverter(MapperContext.TextMap));

        Console.WriteLine("按任意键退出。");
        Console.ReadKey();
        return;
    }
}