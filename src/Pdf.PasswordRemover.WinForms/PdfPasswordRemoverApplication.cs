//-----------------------------------------------------------------------
// <copyright file="PdfPasswordRemoverApplication.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.Pdf.PasswordRemover.WinForms
{
    internal static class PdfPasswordRemoverApplication
    {
        [STAThread]
        internal static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}