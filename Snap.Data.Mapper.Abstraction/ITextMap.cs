﻿// Copyright (c) DGP Studio. All rights reserved.
// Licensed under the MIT license.

namespace Snap.Data.Mapper.Abstraction;

/// <summary>
/// 文本映射
/// </summary>
public interface ITextMap
{
    /// <summary>
    /// 获取映射的目标文本
    /// </summary>
    /// <param name="key">键</param>
    /// <returns>对应的文本，若无匹配项则返回 <see langword="null"/> </returns>
    string? this[string? key] { get; }
}