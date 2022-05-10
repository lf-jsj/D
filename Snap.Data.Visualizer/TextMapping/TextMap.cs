// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Data.Mapper.Abstraction;
using Snap.Data.Visualizer.Core.Validation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Snap.Data.Visualizer.TextMapping;

/// <summary>
/// 默认的文本映射实现
///             Min: 640
///             Max: 4294966372
/// UInt32.MaxValue: 4294967295
/// </summary>
internal class TextMap : ITextMap
{
    private readonly Lazy<IDictionary<string, string>> textMapping;
    private readonly string language;
    /// <summary>
    /// 构造一个新的文本映射的默认实现
    /// </summary>
    /// <param name="filePath">映射文件路径</param>
    public TextMap(string filePath)
    {
        // [7..] trim out prefixed TextMap
        language = Path.GetFileNameWithoutExtension(filePath)[7..];
        textMapping = new Lazy<IDictionary<string, string>>(() =>
        {
            string content = File.ReadAllText(filePath);
            IDictionary<string, string>? map = JsonSerializer.Deserialize<IDictionary<string, string>>(content);
            return Must.NotNull(map!);
        });
    }

    /// <inheritdoc/>
    public string Language
    {
        get => language;
    }

    /// <inheritdoc/>
    public int KeyCount
    {
        get => textMapping.Value.Count;
    }

    /// <inheritdoc/>
    public string? this[string? key]
    {
        get
        {
            return key != null && textMapping.Value.TryGetValue(key, out string? result)
                ? result
                : null;
        }
    }
}
