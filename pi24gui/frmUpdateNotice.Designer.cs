namespace pi24gui
{
    partial class frmUpdateNotice
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
            lblNewRelease = new Label();
            lblCurrentVersionNotice = new Label();
            lblReleaseDate = new Label();
            lblReleaseDateValue = new Label();
            txtReleaseInformation = new TextBox();
            btnDownload = new Button();
            SuspendLayout();
            // 
            // lblNewRelease
            // 
            lblNewRelease.AutoSize = true;
            lblNewRelease.Font = new Font("Calibri", 22.2F, FontStyle.Bold);
            lblNewRelease.Location = new Point(20, 20);
            lblNewRelease.Name = "lblNewRelease";
            lblNewRelease.Size = new Size(366, 45);
            lblNewRelease.TabIndex = 0;
            lblNewRelease.Text = "New Release Available";
            // 
            // lblCurrentVersionNotice
            // 
            lblCurrentVersionNotice.AutoSize = true;
            lblCurrentVersionNotice.Font = new Font("Calibri", 10.8F);
            lblCurrentVersionNotice.Location = new Point(25, 65);
            lblCurrentVersionNotice.Name = "lblCurrentVersionNotice";
            lblCurrentVersionNotice.Size = new Size(344, 22);
            lblCurrentVersionNotice.TabIndex = 1;
            lblCurrentVersionNotice.Text = "You are on version {0}, the latest version is {0}";
            // 
            // lblReleaseDate
            // 
            lblReleaseDate.AutoSize = true;
            lblReleaseDate.Font = new Font("Calibri", 10.8F, FontStyle.Bold);
            lblReleaseDate.Location = new Point(25, 87);
            lblReleaseDate.Name = "lblReleaseDate";
            lblReleaseDate.Size = new Size(106, 22);
            lblReleaseDate.TabIndex = 2;
            lblReleaseDate.Text = "Release Date";
            // 
            // lblReleaseDateValue
            // 
            lblReleaseDateValue.AutoSize = true;
            lblReleaseDateValue.Location = new Point(142, 87);
            lblReleaseDateValue.Name = "lblReleaseDateValue";
            lblReleaseDateValue.Size = new Size(111, 20);
            lblReleaseDateValue.TabIndex = 3;
            lblReleaseDateValue.Text = "{YYYY-MM-DD}";
            // 
            // txtReleaseInformation
            // 
            txtReleaseInformation.Enabled = false;
            txtReleaseInformation.Location = new Point(29, 126);
            txtReleaseInformation.Multiline = true;
            txtReleaseInformation.Name = "txtReleaseInformation";
            txtReleaseInformation.ScrollBars = ScrollBars.Vertical;
            txtReleaseInformation.Size = new Size(521, 205);
            txtReleaseInformation.TabIndex = 4;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(438, 337);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(112, 29);
            btnDownload.TabIndex = 5;
            btnDownload.Text = "Open Release";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // frmUpdateNotice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(579, 372);
            Controls.Add(btnDownload);
            Controls.Add(txtReleaseInformation);
            Controls.Add(lblReleaseDateValue);
            Controls.Add(lblReleaseDate);
            Controls.Add(lblCurrentVersionNotice);
            Controls.Add(lblNewRelease);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmUpdateNotice";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Notice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewRelease;
        private Label lblCurrentVersionNotice;
        private Label lblReleaseDate;
        private Label lblReleaseDateValue;
        private TextBox txtReleaseInformation;
        private Button btnDownload;
    }
}