// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

using Snap.Data.Mapper.Abstraction;

namespace Snap.Data.Mapper;

/// <summary>
/// 映射器上下文
/// </summary>
public static class MapperContext
{
    /// <summary>
    /// 当前的文本映射
    /// </summary>
    public static ITextMap? TextMap { get; set; }
}
