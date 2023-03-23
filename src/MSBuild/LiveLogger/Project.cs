﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;

namespace Microsoft.Build.Logging.LiveLogger;

internal sealed class Project
{
    public Stopwatch Stopwatch { get; } = Stopwatch.StartNew();
    public string? OutputPath { get; set; }
}
