//-----------------------------------------------------------------------
// <copyright file="PdfHelper.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.Pdf
{
    using PdfSharp.Pdf;
    using PdfSharp.Pdf.IO;
    using PdfSharp.Pdf.Security;

    internal static class PdfHelper
    {
        public static bool IsPasswordProtected(string fileName)
        {
            try
            {
                using var document = PdfReader.Open(fileName);

                return false;
            }
            catch (Exception ex) when (ex.Message == "A password is required to open the PDF document.")
            {
                return true;
            }
        }

        public static bool IsValidPdf(string fileName)
        {
            var result = PdfReader.TestPdfFile(fileName);

            if (result > 0)
            {
                return true;
            }

            return false;
        }

        public static bool RemovePassword(string fileName, string password, string? outputFile = null)
        {
            if (outputFile is null)
            {
                outputFile = fileName;
            }

            PdfDocument document;

            try
            {
                document = PdfReader.Open(fileName, password);
            }
            catch (PdfReaderException e) when (e.Message == "The specified password is invalid.")
            {
                return false;
            }

            using (document)
            {
                document.SecurityHandler.SetEncryption(PdfDefaultEncryption.None);

                document.Save(outputFile);
            }

            return true;
        }
    }
}
