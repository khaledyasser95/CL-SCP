using System;
using System.Drawing.Printing;

namespace Print_SCP
{
    [Serializable]
    public class DicomPrintConfig
    {
        public string AETitle = "XEROX_SCP";
        public PrinterSettings PrinterSettings;
        public string PaperSource;
        public bool PreviewOnly = false;
        public int resolution=150;
        public int m_left=25;
        public int m_right = 25;
        public int m_top = 25;
        public int m_bottom = 25;

        public DicomPrintConfig()
        {
            PrintDocument document = new PrintDocument();
            this.PrinterSettings = document.PrinterSettings;
            this.PaperSource = this.PrinterSettings.PaperSources[0].SourceName;
        }

        public string PrinterName =>
            this.PrinterSettings.PrinterName;
    }
}
