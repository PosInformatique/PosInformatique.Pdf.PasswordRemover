//-----------------------------------------------------------------------
// <copyright file="AboutForm.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.Pdf.PasswordRemover.WinForms
{
    using System.Diagnostics;

    internal partial class AboutForm : Form
    {
        public AboutForm()
        {
            this.InitializeComponent();

            this.version.Text = string.Format(this.version.Text, this.GetType().Assembly.GetName().Version!.ToString(3));
        }

        public static new void Show(IWin32Window owner)
        {
            using (var dialog = new AboutForm())
            {
                dialog.ShowDialog(owner);
            }
        }

        private void OnGitHubLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var gitHubRepositoryUrl = this.GetType().Assembly.GetRepositoryUrl();

            Process.Start(new ProcessStartInfo(gitHubRepositoryUrl) { UseShellExecute = true });
        }
    }
}
