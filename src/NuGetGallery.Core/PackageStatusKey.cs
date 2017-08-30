// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Linq.Expressions;

namespace NuGetGallery
{
    public static class PackageStatusKey
    {
        /// <summary>
        /// The package has been soft deleted. This means that the package is not available but the package ID and
        /// version are still reserved.
        /// </summary>
        public const int Deleted = 1;
    }
}
