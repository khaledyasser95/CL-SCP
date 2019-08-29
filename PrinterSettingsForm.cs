using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
namespace Print_SCP
{
    public partial class PrinterSettingsForm : Form
    {
        private DicomPrintConfig _config;
  

        public PrinterSettingsForm(DicomPrintConfig config)
        {
            InitializeComponent();
            this._config = config;
            this.AETITLE_txt.Text = this._config.AETitle;
            this.printerName_txt.Text = this._config.PrinterName;
            this.tray.Items.Clear();
            this.tray.Items.Add("Driver Select");
            this.resolutionBar.Value = config.resolution;

            foreach (PaperSource source in this._config.PrinterSettings.PaperSources)
            {
                if (!string.IsNullOrEmpty(source.SourceName))
                {
                    this.tray.Items.Add(source.SourceName);
                }
            }

            this.tray.SelectedItem = this._config.PaperSource;
            if (this.tray.SelectedIndex == -1)
            {
                this.tray.SelectedIndex = 0;
            }
            this.cbPreviewOnly.Checked = this._config.PreviewOnly;
        }

        private void PrinterSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void bttnSelectPrinter_Click(object sender, EventArgs e)
        {
            PrintDialog dialog = new PrintDialog
            {
                UseEXDialog = true
            };
            if (this._config.PrinterSettings != null)
            {
                dialog.PrinterSettings = this._config.PrinterSettings;
            }
            if (dialog.ShowDialog(this) == DialogResult.OK)
            {
                this._config.PrinterSettings = dialog.PrinterSettings;
                this.printerName_txt.Text = this._config.PrinterName;
                this.tray.Items.Clear();
                this.tray.Items.Add("Driver Select");
                foreach (PaperSource source in this._config.PrinterSettings.PaperSources)
                {
                    if (!string.IsNullOrEmpty(source.SourceName))
                    {
                        this.tray.Items.Add(source.SourceName);
                    }
                }
                this.tray.SelectedIndex = 0;
            }
        }

        private void cbPaperSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._config.PaperSource = (this.tray.SelectedIndex != 0) ? this.tray.Text : null;

        }

        private void cbPreviewOnly_CheckedChanged(object sender, EventArgs e)
        {
            this._config.PreviewOnly = this.cbPreviewOnly.Checked;
        }

        private void tbAETitle_TextChanged(object sender, EventArgs e)
        {
            this._config.AETitle = this.AETITLE_txt.Text;
        }

   

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(resolutionBar, resolutionBar.Value.ToString());
            _config.resolution = resolutionBar.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _config.m_top = Convert.ToInt32(numericUpDown1.Value);
            _config.m_bottom = Convert.ToInt32(numericUpDown3.Value);
            _config.m_left = Convert.ToInt32(numericUpDown2.Value);
            _config.m_right = Convert.ToInt32(numericUpDown4.Value);
        }
    }
}
