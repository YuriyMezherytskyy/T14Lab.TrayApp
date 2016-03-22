using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Tornado14.TrayApp
{
    internal class DAL
    {
        private string startupPath;
        private string networkFolder;
        private DirectoryInfo localConfigFolder;
        private DirectoryInfo networkConfigFolder;

        public List<ConfigFile> allConfigFiles { get; set; }

        public DAL(string startupPath, string networkFolder)
        {
            this.startupPath = startupPath;
            this.networkFolder = networkFolder;

            localConfigFolder = new DirectoryInfo(Path.Combine(startupPath, "profiles"));
            networkConfigFolder = new DirectoryInfo(Path.Combine(networkFolder, "TrayStarterProfile"));
            this.allConfigFiles = getAllConfigurationFiles();
        }

        private List<ConfigFile> getAllConfigurationFiles()
        {
            List<ConfigFile> allProfiles = new List<ConfigFile>();
            foreach (FileInfo configurationFile in localConfigFolder.GetFiles())
            {
                if (configurationFile.Extension == ".xml")
                {
                    allProfiles.Add(new ConfigFile()
                    {
                        IsNetworkConfigFile = false,
                        File = new FileInfo(configurationFile.FullName)
                    });
                }
            }

            if (networkConfigFolder.Exists)
            {
                foreach (FileInfo configurationFile in networkConfigFolder.GetFiles())
                {
                    if (configurationFile.Extension == ".xml")
                    {
                        allProfiles.Add(new ConfigFile()
                        {
                            IsNetworkConfigFile = true,
                            File = new FileInfo(configurationFile.FullName)
                        });
                    }
                }
            }

            return allProfiles;
        }
    }
}
