namespace PosInformatique.Pdf.PasswordRemover.WinForms
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label label1;
            LinkLabel gitHub;
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.ok = new Button();
            this.version = new Label();
            this.pictureBox1 = new PictureBox();
            label1 = new Label();
            gitHub = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(156, 24);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 0;
            label1.Text = "PDF Password Remover";
            // 
            // gitHub
            // 
            gitHub.AutoSize = true;
            gitHub.Location = new Point(160, 119);
            gitHub.Name = "gitHub";
            gitHub.Size = new Size(85, 15);
            gitHub.TabIndex = 4;
            gitHub.TabStop = true;
            gitHub.Text = "GitHub project";
            gitHub.LinkClicked += this.OnGitHubLinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 56);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 1;
            label2.Text = "by P.O.S Informatique";
            // 
            // ok
            // 
            this.ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.ok.DialogResult = DialogResult.OK;
            this.ok.Location = new Point(341, 130);
            this.ok.Name = "ok";
            this.ok.Size = new Size(75, 23);
            this.ok.TabIndex = 2;
            this.ok.Text = "&OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new Point(160, 88);
            this.version.Name = "version";
            this.version.Size = new Size(65, 15);
            this.version.TabIndex = 3;
            this.version.Text = "Version: {0}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            this.pictureBox1.Location = new Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(128, 128);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(428, 165);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(gitHub);
            this.Controls.Add(this.version);
            this.Controls.Add(this.ok);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "About PDF Password Remover";
            ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Button ok;
        private Label version;
        private PictureBox pictureBox1;
    }
}