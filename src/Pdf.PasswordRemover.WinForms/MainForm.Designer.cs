namespace PosInformatique.Pdf.PasswordRemover.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LinkLabel selectFile;
            Label label3;
            Label label2;
            Button about;
            Button exit;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.passwordLabel = new Label();
            this.fileDropArea = new Panel();
            this.remove = new Button();
            this.password = new TextBox();
            this.filePath = new Label();
            selectFile = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            about = new Button();
            exit = new Button();
            this.fileDropArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectFile
            // 
            selectFile.Anchor = AnchorStyles.Top;
            selectFile.Location = new Point(103, 66);
            selectFile.Name = "selectFile";
            selectFile.Size = new Size(378, 23);
            selectFile.TabIndex = 1;
            selectFile.TabStop = true;
            selectFile.Text = "Or click here to select a file.";
            selectFile.TextAlign = ContentAlignment.MiddleCenter;
            selectFile.LinkClicked += this.OnSelectFileLinkClicked;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Location = new Point(12, 146);
            label3.Name = "label3";
            label3.Size = new Size(579, 23);
            label3.TabIndex = 6;
            label3.Text = "Path of the PDF file to remove the password:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(103, 10);
            label2.Name = "label2";
            label2.Size = new Size(378, 38);
            label2.TabIndex = 0;
            label2.Text = "Drop the PDF file here";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // about
            // 
            about.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            about.Location = new Point(521, 293);
            about.Name = "about";
            about.Size = new Size(75, 23);
            about.TabIndex = 8;
            about.Text = "&About...";
            about.UseVisualStyleBackColor = true;
            about.Click += this.OnAboutClick;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = AnchorStyles.Top;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new Point(194, 252);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new Size(60, 15);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password:";
            // 
            // fileDropArea
            // 
            this.fileDropArea.AllowDrop = true;
            this.fileDropArea.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.fileDropArea.BorderStyle = BorderStyle.FixedSingle;
            this.fileDropArea.Controls.Add(selectFile);
            this.fileDropArea.Controls.Add(label2);
            this.fileDropArea.Location = new Point(12, 12);
            this.fileDropArea.Name = "fileDropArea";
            this.fileDropArea.Size = new Size(584, 100);
            this.fileDropArea.TabIndex = 5;
            this.fileDropArea.DragDrop += this.OnFileDropAreaDragDrop;
            this.fileDropArea.DragEnter += this.OnFileDropAreaDragEnter;
            this.fileDropArea.DragLeave += this.OnFileDropAreaDragLeave;
            // 
            // remove
            // 
            this.remove.Anchor = AnchorStyles.Top;
            this.remove.Enabled = false;
            this.remove.Location = new Point(194, 293);
            this.remove.Name = "remove";
            this.remove.Size = new Size(213, 53);
            this.remove.TabIndex = 2;
            this.remove.Text = "Remove password";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += this.OnRemovePasswordClick;
            // 
            // password
            // 
            this.password.Anchor = AnchorStyles.Top;
            this.password.Location = new Point(260, 249);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new Size(147, 23);
            this.password.TabIndex = 3;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += this.OnPasswordTextChanged;
            // 
            // filePath
            // 
            this.filePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.filePath.AutoEllipsis = true;
            this.filePath.Location = new Point(12, 169);
            this.filePath.Name = "filePath";
            this.filePath.Size = new Size(579, 23);
            this.filePath.TabIndex = 7;
            this.filePath.Text = "< No file selected >";
            this.filePath.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            exit.Location = new Point(521, 323);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 9;
            exit.Text = "&Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += this.OnExitClick;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(608, 358);
            this.Controls.Add(exit);
            this.Controls.Add(about);
            this.Controls.Add(label3);
            this.Controls.Add(this.fileDropArea);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.password);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.filePath);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = (Icon)resources.GetObject("$this.Icon");
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "PDF Password Remover by P.O.S Informatique";
            this.fileDropArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Button remove;
        private TextBox password;
        private Label passwordLabel;
        private Panel fileDropArea;
        private Label filePath;
        private Button exit;
    }
}
