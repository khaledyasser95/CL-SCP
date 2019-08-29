using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Print_SCP
{
    [Serializable]
    class Config_
    {

        public static Config_ Instance;

        private static string ConfigPath = (Application.StartupPath + @"\print.cfg");

        public List<DicomPrintConfig> Printers = new List<DicomPrintConfig>();

        public DicomPrintConfig FindPrinter(string aeTitle)
        {
            using (List<DicomPrintConfig>.Enumerator enumerator = this.Printers.GetEnumerator())
            {
                while (true)
                {
                    if (!enumerator.MoveNext())
                    {
                        break;
                    }
                    DicomPrintConfig current = enumerator.Current;
                    if (current.AETitle == aeTitle)
                    {
                        return current;
                    }
                }
            }
            return null;
        }

        public static Config_ Load()
        {
            if (File.Exists(ConfigPath))
            {
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream stream = new FileStream(ConfigPath, FileMode.Open))
                    {
                        Instance = (Config_)formatter.Deserialize(stream);
                    }
                }
                catch
                {
                    Instance = new Config_();
                }
            }
            else
            {
                Instance = new Config_();
                return Instance;
            }
            return Instance;
        }

        public static void Save()
        {
            if (ReferenceEquals(Instance, null))
            {
                Instance = new Config_();
            }
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = File.Create(ConfigPath))
                {
                    formatter.Serialize(stream, Instance);
                    stream.Flush();
                }
            }
            catch
            {
            }
        }

    }
}
