using Dicom.Printing;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Timers;
using System.Windows.Forms;

namespace Print_SCP
{

    public partial class V1 : Form
    {
        
 
        RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

          System.Timers.Timer aTimer;
        private int counter = 0;
        public int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                this.counter = value;
            }
        }
        public bool toFile = false;
        private bool on_off = false;

        public V1()
        {
            InitializeComponent();
            rkApp.SetValue("V1", Application.ExecutablePath);
            serverStart.BackColor = Color.Red;
            serverStart.Text = "STOPPED";

        }
       



        private void button1_Click(object sender, EventArgs e)
        {

            if (!on_off)
            {

                start_server();

            }
            else
            {
                stop_Server();
            }
        }

        private void RefreshPrinters()
        {
            this.Printers_List.BeginUpdate();
            this.Printers_List.Items.Clear();
            foreach (DicomPrintConfig config in Config_.Instance.Printers)
            {

                ListViewItem item = new ListViewItem(config.AETitle)
                {

                    SubItems = {
                        config.PrinterName,
                        config.PaperSource,
                        config.PreviewOnly.ToString(),
                        config.resolution.ToString()

                    },
                    Tag = config
                };
                this.Printers_List.Items.Add(item);
            }
            this.Printers_List.Sort();
            this.Printers_List.EndUpdate();
        }
        private void start_server()
        {
            on_off = true;
            serverStart.BackColor = Color.Green;
            serverStart.Text = "STARTED";
            int port = int.Parse(port_txt.Text);
            PrintService.Start(port);


        }

        private void stop_Server()
        {
            on_off = false;
            serverStart.BackColor = Color.Red;
            serverStart.Text = "STOPPED";
            PrintService.Stop();
        }

        private void V1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (on_off)
                PrintService.Stop();
            save();
            Encryption.ProtectConfiguration();
        }
        private void save()
        {
            Config_.Save();
            RefreshPrinters();
            Properties.Settings.Default.Port = int.Parse(port_txt.Text);
            Properties.Settings.Default.counter = counter;

        //    Properties.Settings.Default.port = int.Parse(port_txt.Text);

            Properties.Settings.Default.Save();
           
        }
        private void load()
        {
            Config_.Load();
            RefreshPrinters();

            counter = Properties.Settings.Default.counter;

            port_txt.Text = Properties.Settings.Default.Port.ToString();

          //  port_txt.Text= Properties.Settings.Default.port.ToString();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                toFile = true;
            else
                toFile = false;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DicomPrintConfig config = new DicomPrintConfig();
                if (new PrinterSettingsForm(config).ShowDialog(this) == DialogResult.OK)
                {
                    Config_.Instance.Printers.Add(config);
                    save();

                }
      

            }
        }



        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //Do the stuff you want to be done every hour;
            string res;

            res = FormReferenceHolder.Ver.Key_verification(Properties.Settings.Default.SN);
            Console.WriteLine(Properties.Settings.Default.days);
            if (Properties.Settings.Default.days == 0)
            {
                stop_Server();
                this.Invoke((Action)delegate () { Close(); });

            }
        }


        private void V1_Load(object sender, EventArgs e)
        {
           
            Encryption.UnProtectConfiguration();


            //// aTimer = new System.Timers.Timer(24*60 * 60 * 1000); //one hour in milliseconds
            aTimer = new System.Timers.Timer(12 * 1000);
            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            aTimer.Enabled = true;

            // aTimer = new System.Timers.Timer(24*60 * 60 * 1000); //one hour in milliseconds
            //aTimer = new System.Timers.Timer(24 * 60 * 60 * 1000);
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //aTimer.Enabled = true;


            load();
            string path = Application.StartupPath + @"\footer.txt";
            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);
                this.footer_txt.Text = reader.ReadLine();
                reader.Close();
            }
            start_server();
            //int minutes = 3 * 60 * 1000;
            //var timer = new System.Threading.Timer(save_counter, null, 0, minutes);

        }

        private void save_counter(object state)
        {
            Properties.Settings.Default.counter = counter;
            Properties.Settings.Default.Save();
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Counter: " + counter);
        }



        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StreamWriter writer = new StreamWriter(Application.StartupPath + @"\footer.txt");
                writer.WriteLine(footer_txt.Text);
                writer.Close();
            }
        }

      
      

        private void lvPrinters_DoubleClick(object sender, EventArgs e)
        {
            if (this.Printers_List.SelectedItems.Count != 0)
            {
                if (new PrinterSettingsForm((DicomPrintConfig)this.Printers_List.SelectedItems[0].Tag).ShowDialog(this) == DialogResult.OK)
                {
                    save();
                }
                else
                {
                    load();
                }
            }
        }





        private void lvPrinters_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DicomPrintConfig config = new DicomPrintConfig();
                if (new PrinterSettingsForm(config).ShowDialog(this) == DialogResult.OK)
                {
                    Config_.Instance.Printers.Add(config);
                    save();

                }


            }
            if (e.KeyCode == Keys.Delete)
            {
                if ((this.Printers_List.SelectedItems.Count != 0) && (MessageBox.Show(this, "Are you sure you want to delete this?", "Delete Printer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.No))
                {
                    DicomPrintConfig tag = (DicomPrintConfig)this.Printers_List.SelectedItems[0].Tag;
                    Config_.Instance.Printers.Remove(tag);
                    save();
                }
            }


        }

        private void about_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Email: khaledyasser95@gmail.com", "About");
        }
    }
}
