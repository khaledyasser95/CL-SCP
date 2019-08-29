using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_SCP
{
    class Encryption
    {
        public static void ProtectConfiguration()
        {

            // Get the application configuration file.
            System.Configuration.Configuration config =
                ConfigurationManager.OpenExeConfiguration(
                ConfigurationUserLevel.PerUserRoamingAndLocal);

            // Define the Rsa provider name.
            string provider =
                "RsaProtectedConfigurationProvider";

            // Get the section to protect.
            ConfigurationSection connStrings =
                config.GetSection("userSettings/Print_SCP.Properties.Settings");


            if (connStrings != null)
            {
                if (!connStrings.SectionInformation.IsProtected)
                {
                    if (!connStrings.ElementInformation.IsLocked)
                    {
                        // Protect the section.
                        connStrings.SectionInformation.ProtectSection(provider);

                        //Properties.Settings.Default.counter = counter;
                        //Properties.Settings.Default.aet = aeTitles;
                        //Properties.Settings.Default.printers = printers;

                        connStrings.SectionInformation.ForceSave = true;
                        config.Save(ConfigurationSaveMode.Full);

                        Console.WriteLine("Section {0} is now protected by {1}",
                            connStrings.SectionInformation.Name,
                            connStrings.SectionInformation.ProtectionProvider.Name);

                    }
                    else
                        Console.WriteLine(
                             "Can't protect, section {0} is locked",
                             connStrings.SectionInformation.Name);
                }
                else
                    Console.WriteLine(
                        "Section {0} is already protected by {1}",
                        connStrings.SectionInformation.Name,
                        connStrings.SectionInformation.ProtectionProvider.Name);

            }
            else
                Console.WriteLine("Can't get the section {0}",
                    connStrings.SectionInformation.Name);

        }

        public static void UnProtectConfiguration()
        {

            // Get the application configuration file.
            System.Configuration.Configuration config =
                 ConfigurationManager.OpenExeConfiguration(
                 ConfigurationUserLevel.PerUserRoamingAndLocal);

            // Get the section to unprotect.
            ConfigurationSection connStrings =
                config.GetSection("userSettings/Print_SCP.Properties.Settings");

            if (connStrings != null)
            {
                if (connStrings.SectionInformation.IsProtected)
                {
                    if (!connStrings.ElementInformation.IsLocked)
                    {
                        // Unprotect the section.
                        connStrings.SectionInformation.UnprotectSection();

                        connStrings.SectionInformation.ForceSave = true;
                        config.Save(ConfigurationSaveMode.Full);

                        Console.WriteLine("Section {0} is now unprotected.",
                            connStrings.SectionInformation.Name);

                    }
                    else
                        Console.WriteLine(
                             "Can't unprotect, section {0} is locked",
                             connStrings.SectionInformation.Name);
                }
                else
                    Console.WriteLine(
                        "Section {0} is already unprotected.",
                        connStrings.SectionInformation.Name);

            }
            else
                Console.WriteLine("Can't get the section {0}",
                    connStrings.SectionInformation.Name);

        }
    }
}
