using pi24gui.Models;
using System.Diagnostics;

namespace pi24gui
{
    public partial class frmUpdateNotice : Form
    {
        private readonly Updater.Updater updater = new Updater.Updater();
        private string _releaseUrl = string.Empty;

        public frmUpdateNotice()
        {
            InitializeComponent();

            GetReleaseInformation();

        }

        private void GetReleaseInformation()
        {
            ReleasesModel data = updater.ReturnReleaseInformation();

            lblCurrentVersionNotice.Text = $"You are on version {Application.ProductVersion}, the latest version is {data.tag_name}";
            txtReleaseInformation.Text = $"{data.body}";
            lblReleaseDateValue.Text = $"{data.published_at:U}";

            _releaseUrl = $"{data.html_url}";
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Process.Start(
                new ProcessStartInfo(_releaseUrl)
                {
                    UseShellExecute = true
                }
            );
        }
    }
}
