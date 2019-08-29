// Copyright (c) 2012-2019 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using Print_SCP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Dicom.Printing
{
    public class StatusUpdateEventArgs : EventArgs
    {
        public ushort EventTypeId { get; private set; }
        public string ExecutionStatusInfo { get; private set; }
        public string FilmSessionLabel { get; private set; }
        public string PrinterName { get; private set; }

        public StatusUpdateEventArgs(
            ushort eventTypeId,
            string executionStatusInfo,
            string filmSessionLabel,
            string printerName)
        {
            EventTypeId = eventTypeId;
            ExecutionStatusInfo = executionStatusInfo;
            FilmSessionLabel = filmSessionLabel;
            PrinterName = printerName;
        }
    }

    public enum PrintJobStatus : ushort
    {
        Pending = 1,

        Printing = 2,

        Done = 3,

        Failure = 4
    }

    public class PrintJob : DicomDataset
    {
        #region Properties and Attributes

        public bool SendNEventReport { get; set; }

        public Guid PrintJobGuid { get; private set; }

        public IList<string> FilmBoxFolderList { get; private set; }

        public Printer Printer { get; private set; }

        public PrintJobStatus Status { get; private set; }

        public string PrintJobFolder { get; private set; }

        public string FullPrintJobFolder { get; private set; }

        public Exception Error { get; private set; }

        public string FilmSessionLabel { get; private set; }

        private int _currentPage;

        private FilmBox _currentFilmBox;

        /// <summary>
        /// Print job SOP class UID
        /// </summary>
        public readonly DicomUID SOPClassUID = DicomUID.PrintJobSOPClass;

        /// <summary>
        /// Print job SOP instance UID
        /// </summary>
        public DicomUID SOPInstanceUID { get; private set; }

        /// <summary>
        /// Execution status of print job.
        /// </summary>
        /// <remarks>
        /// Enumerated Values:
        /// <list type="bullet">
        /// <item><description>PENDING</description></item>
        /// <item><description>PRINTING</description></item>
        /// <item><description>DONE</description></item>
        /// <item><description>FAILURE</description></item>
        /// </list>
        /// </remarks> 
        public string ExecutionStatus
        {
            get => GetSingleValueOrDefault(DicomTag.ExecutionStatus, string.Empty);
            set => AddOrUpdate(DicomTag.ExecutionStatus, value);
        }

        /// <summary>
        /// Additional information about Execution Status (2100,0020).
        /// </summary>
        public string ExecutionStatusInfo
        {
            get => GetSingleValueOrDefault(DicomTag.ExecutionStatusInfo, string.Empty);
            set => AddOrUpdate(DicomTag.ExecutionStatusInfo, value);
        }

        /// <summary>
        /// Specifies the priority of the print job.
        /// </summary>
        /// <remarks>
        /// Enumerated values:
        /// <list type="bullet">
        ///     <item><description>HIGH</description></item>
        ///     <item><description>MED</description></item>
        ///     <item><description>LOW</description></item>
        /// </list>
        /// </remarks>
        public string PrintPriority
        {
            get => GetSingleValueOrDefault(DicomTag.PrintPriority, "MED");
            set => AddOrUpdate(DicomTag.PrintPriority, value);
        }

        /// <summary>
        /// Date/Time of print job creation.
        /// </summary>
        public DateTime CreationDateTime
        {
            get => this.GetDateTime(DicomTag.CreationDate, DicomTag.CreationTime);
            set
            {
                AddOrUpdate(DicomTag.CreationDate, value);
                AddOrUpdate(DicomTag.CreationTime, value);
            }
        }

        /// <summary>
        /// User defined name identifying the printer.
        /// </summary>
        public string PrinterName
        {
            get => GetSingleValueOrDefault(DicomTag.PrinterName, string.Empty);
            set => AddOrUpdate(DicomTag.PrinterName, value);
        }

        /// <summary>
        /// DICOM Application Entity Title that issued the print operation.
        /// </summary>
        public string Originator
        {
            get => GetSingleValueOrDefault(DicomTag.Originator, string.Empty);
            set => AddOrUpdate(DicomTag.Originator, value);
        }

        public Log.Logger Log { get; private set; }


        public event EventHandler<StatusUpdateEventArgs> StatusUpdate;

        #endregion

        #region Constructors
        string printerAET = null;
        /// <summary>
        /// Construct new print job using specified SOP instance UID. If passed SOP instance UID is missing, new UID will
        /// be generated
        /// </summary>
        /// <param name="sopInstance">New print job SOP instance uID</param>
        public PrintJob(DicomUID sopInstance, Printer printer, string originator, Log.Logger log)
            : base()
        {
            Log = log;

            if (sopInstance == null || sopInstance.UID == string.Empty)
            {
                SOPInstanceUID = DicomUID.Generate();
            }
            else
            {
                SOPInstanceUID = sopInstance;
            }

            Add(DicomTag.SOPClassUID, SOPClassUID);
            Add(DicomTag.SOPInstanceUID, SOPInstanceUID);

            Printer = printer ?? throw new ArgumentNullException("printer");

            Status = PrintJobStatus.Pending;


            //Get Printer name
            PrinterName = Printer.PrinterName;
            printerAET = Printer.PrinterAet;
            //  PrinterName = Printer.Prin;

            Originator = originator;

            if (CreationDateTime == DateTime.MinValue)
            {
                CreationDateTime = DateTime.Now;
            }

            PrintJobFolder = SOPInstanceUID.UID;

            var receivingFolder = Path.Combine(Environment.CurrentDirectory, "PrintJobs");

            FullPrintJobFolder = Path.Combine(receivingFolder, PrintJobFolder);

            FilmBoxFolderList = new List<string>();
        }

        #endregion

        #region Printing Methods

        public void Print(IList<FilmBox> filmBoxList)
        {
            try
            {
                Status = PrintJobStatus.Pending;

                OnStatusUpdate("Preparing films for printing");

                var printJobDir = new DirectoryInfo(FullPrintJobFolder);
                if (!printJobDir.Exists)
                {
                    printJobDir.Create();
                }

                DicomFile file;
                int filmsCount = FilmBoxFolderList.Count;
                for (int i = 0; i < filmBoxList.Count; i++)
                {
                    var filmBox = filmBoxList[i];
                    var filmBoxDir = printJobDir.CreateSubdirectory(string.Format("F{0:000000}", i + 1 + filmsCount));

                    file = new DicomFile(filmBox.FilmSession);
                    // Console.WriteLine("KHALEEEEEEEEEEED "+file.Dataset.Get<string>(DicomTag.PatientID));
                    file.Save(Path.Combine(filmBoxDir.FullName, "FilmSession.dcm"));

                    FilmBoxFolderList.Add(filmBoxDir.Name);
                    filmBox.Save(filmBoxDir.FullName);

                }

                FilmSessionLabel = filmBoxList.First().FilmSession.FilmSessionLabel;

                var thread = new Thread(new ThreadStart(DoPrint))
                {
                    Name = $"PrintJob {SOPInstanceUID.UID}",
                    IsBackground = true
                };
                thread.Start();
            }
            catch (Exception ex)
            {
                Error = ex;
                Status = PrintJobStatus.Failure;
                OnStatusUpdate("Print failed");
                DeletePrintFolder();
            }
        }

        DicomPrintConfig config;
        private void DoPrint()
        {
            PrintDocument printDocument = null;
            try
            {
                Status = PrintJobStatus.Printing;
                OnStatusUpdate("Printing Started");
                string x = DicomTag.PatientName.ToString();


                config = Config_.Instance.FindPrinter(this.Printer.PrinterAet);
                PrinterSettings printerSettings = config.PrinterSettings;



                printDocument = new PrintDocument
                {
                    PrinterSettings = printerSettings,
                    DocumentName = Thread.CurrentThread.Name,
                    PrintController = new StandardPrintController()
                };

                printDocument.QueryPageSettings += OnQueryPageSettings;
                printDocument.PrintPage += OnPrintPage;

                if (!config.PreviewOnly)
                {
                    printDocument.Print();
                }
                else
                {
                    new PrintPreviewDialog
                    {
                        Document = printDocument,
                        WindowState = FormWindowState.Maximized
                    }.ShowDialog();
                }

                Status = PrintJobStatus.Done;
                int counter = FormReferenceHolder.Form1.Counter + 1;
                FormReferenceHolder.Form1.Counter = counter;
                OnStatusUpdate("Printing Done");
            }
            catch (Exception e)
            {
                Status = PrintJobStatus.Failure;
                OnStatusUpdate($"Printing failed, exception: {e}");
            }
            finally
            {
                if (printDocument != null)
                {
                    //dispose the print document and unregister events handlers to avoid memory leaks
                    printDocument.QueryPageSettings -= OnQueryPageSettings;
                    printDocument.PrintPage -= OnPrintPage;
                    printDocument.Dispose();
                }
            }
        }

        private void OnPrintPage(object sender, PrintPageEventArgs e)
        {
            _currentFilmBox.Print(e.Graphics, e.MarginBounds, config.resolution);
            Console.WriteLine(config.resolution);
            _currentFilmBox = null;
            _currentPage++;


            ////////////////////////////FOOOOTER
            string s = "";
            StreamReader reader = new StreamReader(Application.StartupPath + @"\footer.txt");
            s = reader.ReadLine();
            reader.Close();
            float emSize = 10f;
            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = StringAlignment.Center
            };
            RectangleF layoutRectangle = new RectangleF((float)e.PageBounds.Left, (float)(e.PageBounds.Height - 40), (float)e.PageBounds.Width, 50f);
            e.Graphics.DrawString(s, new Font(FontFamily.GenericSansSerif, emSize, FontStyle.Regular), Brushes.Black, layoutRectangle, format);
            /////////////////////////////


            e.HasMorePages = _currentPage < FilmBoxFolderList.Count;
        }

        private void OnQueryPageSettings(object sender, QueryPageSettingsEventArgs e)
        {
            OnStatusUpdate($"Printing film {_currentPage + 1} of {FilmBoxFolderList.Count}");
            var filmBoxFolder = Path.Combine(FullPrintJobFolder, FilmBoxFolderList[_currentPage]);
            var filmSession = FilmSession.Load(Path.Combine(filmBoxFolder, "FilmSession.dcm"));
            _currentFilmBox = FilmBox.Load(filmSession, filmBoxFolder);

            e.PageSettings.Margins.Left = config.m_left;
            e.PageSettings.Margins.Right = config.m_right;
            e.PageSettings.Margins.Top = config.m_top;
            e.PageSettings.Margins.Bottom = config.m_bottom;

            e.PageSettings.Landscape = _currentFilmBox.FilmOrientation == "LANDSCAPE";
        }

        private void DeletePrintFolder()
        {
            var folderInfo = new DirectoryInfo(FullPrintJobFolder);
            if (folderInfo.Exists)
            {
                folderInfo.Delete(true);
            }
        }

        #endregion

        #region Notification Methods

        protected virtual void OnStatusUpdate(string info)
        {
            ExecutionStatus = Status.ToString();
            ExecutionStatusInfo = info;

            if (Status != PrintJobStatus.Failure)
            {
                Log.Info("Print Job {0} Status {1}: {2}", SOPInstanceUID.UID.Split('.').Last(), Status, info);

            }
            else
            {
                Log.Error("Print Job {0} Status {1}: {2}", SOPInstanceUID.UID.Split('.').Last(), Status, info);
            }
            if (StatusUpdate != null)
            {
                var args = new StatusUpdateEventArgs((ushort)Status, info, FilmSessionLabel, PrinterName);
                StatusUpdate(this, args);
            }
        }

        #endregion

    }
}
