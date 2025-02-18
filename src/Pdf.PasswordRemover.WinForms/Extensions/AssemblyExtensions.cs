//-----------------------------------------------------------------------
// <copyright file="AssemblyExtensions.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.Pdf.PasswordRemover.WinForms
{
    using System.Reflection;

    internal static class AssemblyExtensions
    {
        public static string GetRepositoryUrl(this Assembly assembly)
        {
            var attribute = assembly.GetCustomAttributes<AssemblyMetadataAttribute>()
                .Single(metadata => metadata.Key == "RepositoryUrl");

            return attribute.Value!;
        }
    }
}
