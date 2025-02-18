//-----------------------------------------------------------------------
// <copyright file="FormsExtensions.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.Pdf.PasswordRemover.WinForms
{
    public static class FormsExtensions
    {
        public static void ShowError(this Form form, string message)
        {
            MessageBox.Show(form, message, form.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ShowInformation(this Form form, string message)
        {
            MessageBox.Show(form, message, form.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void SetVisible(this IEnumerable<Control> controls, bool visible)
        {
            foreach (var control in controls)
            {
                control.Visible = visible;
            }
        }
    }
}
