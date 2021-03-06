﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Numerics;
using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp.Processing.Processors
{
    /// <summary>
    /// Converts the colors of the image to their sepia equivalent.
    /// The formula used matches the svg specification. <see href="http://www.w3.org/TR/filter-effects/#sepiaEquivalent"/>
    /// </summary>
    /// <typeparam name="TPixel">The pixel format.</typeparam>
    internal class SepiaProcessor<TPixel> : ColorMatrixProcessor<TPixel>
        where TPixel : struct, IPixel<TPixel>
    {
        /// <inheritdoc/>
        public override Matrix4x4 Matrix => new Matrix4x4
        {
            M11 = .393F,
            M12 = .349F,
            M13 = .272F,
            M21 = .769F,
            M22 = .686F,
            M23 = .534F,
            M31 = .189F,
            M32 = .168F,
            M33 = .131F,
            M44 = 1
        };

        /// <inheritdoc/>
        public override bool Compand => false;
    }
}