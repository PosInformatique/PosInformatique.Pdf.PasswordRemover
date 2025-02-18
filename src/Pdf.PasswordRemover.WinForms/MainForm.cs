//-----------------------------------------------------------------------
// <copyright file="MainForm.cs" company="P.O.S Informatique">
//     Copyright (c) P.O.S Informatique. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace PosInformatique.Pdf.PasswordRemover.WinForms
{
    internal partial class MainForm : Form
    {
        private readonly Color fileDropAreaDefaultColor;

        private readonly Control[] removePasswordGroup;

        private readonly string noFileSelectedText;

        public MainForm()
        {
            this.InitializeComponent();

            this.fileDropAreaDefaultColor = this.fileDropArea.BackColor;

            this.noFileSelectedText = this.filePath.Text;

            this.removePasswordGroup = [this.password, this.passwordLabel, this.remove];
            this.removePasswordGroup.SetVisible(false);
        }

        private void OnRemovePasswordClick(object sender, EventArgs e)
        {
            if (!PdfHelper.RemovePassword(this.filePath.Text, this.password.Text, this.filePath.Text))
            {
                this.ShowError("Invalid password for the PDF file!");
                return;
            }

            this.ShowInformation("The password has been removed successful.");
            this.removePasswordGroup.SetVisible(false);
            this.filePath.Text = this.noFileSelectedText;
        }

        private void OnFileDropAreaDragDrop(object sender, DragEventArgs e)
        {
            if (e.Data is not null)
            {
                var fileNames = (string[]?)e.Data.GetData(DataFormats.FileDrop);

                if (fileNames is not null)
                {
                    this.DisplayPdfFile(fileNames.Single());
                }
            }

            this.fileDropArea.BackColor = this.fileDropAreaDefaultColor;
        }

        private void OnFileDropAreaDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data is not null && e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var fileNames = (string[]?)e.Data.GetData(DataFormats.FileDrop);

                if (fileNames is not null)
                {
                    var fileName = fileNames.Single();

                    if (PdfHelper.IsValidPdf(fileName))
                    {
                        e.Effect = DragDropEffects.Move;

                        this.fileDropArea.BackColor = Color.YellowGreen;
                        return;
                    }
                }
            }

            e.Effect = DragDropEffects.None;
        }

        private void OnFileDropAreaDragLeave(object sender, EventArgs e)
        {
            this.fileDropArea.BackColor = this.fileDropAreaDefaultColor;
        }

        private void OnSelectFileLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "PDF files|*.pdf";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    this.DisplayPdfFile(openDialog.FileName);
                }
            }
        }

        private void DisplayPdfFile(string fileName)
        {
            if (!PdfHelper.IsValidPdf(fileName))
            {
                this.ShowError("The selected PDF file is not a valid PDF file.");
                return;
            }

            if (!PdfHelper.IsPasswordProtected(fileName))
            {
                this.ShowError("The selected PDF file is not protected by a password.");
                return;
            }

            this.filePath.Text = fileName;
            this.password.Text = string.Empty;
            this.removePasswordGroup.SetVisible(true);
        }

        private void OnPasswordTextChanged(object sender, EventArgs e)
        {
            if (this.password.Text.Length > 0)
            {
                this.remove.Enabled = true;
            }
            else
            {
                this.remove.Enabled = false;
            }
        }

        private void OnAboutClick(object sender, EventArgs e)
        {
            AboutForm.Show(this);
        }
    }
}
