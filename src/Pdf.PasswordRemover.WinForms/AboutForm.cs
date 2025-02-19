//-----------------------------------------------------------------------
// <copyright file="AboutForm.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.Pdf.PasswordRemover.WinForms
{
    using System.Diagnostics;
    using Semver;

    internal partial class AboutForm : Form
    {
        public AboutForm()
        {
            this.InitializeComponent();

            var informationalVersion = this.GetType().Assembly.GetInformationalVersion();
            var semVerVersion = SemVersion.Parse(informationalVersion);

            this.version.Text = string.Format(this.version.Text, semVerVersion.WithoutMetadata().ToString());
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
