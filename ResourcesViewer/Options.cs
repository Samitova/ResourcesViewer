using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ResourcesViewer
{
    class Options
    {
         public string rootDirectory { set; get; }
         public bool isXmlFile { set; get; }
         public bool isMapFile { set; get; }
         public bool isResFile { set; get; }

       private static Options instance;

        private Options() {
            LoadConfiguration();
        }

        public static Options GetInstance() {
            if (instance == null)
                instance = new Options();
            return instance;
        }

         public void LoadConfiguration()
         {
             try
             {
                 rootDirectory = ConfigurationManager.AppSettings["rootDirectory"].ToString();
                 isXmlFile = Convert.ToBoolean(ConfigurationManager.AppSettings["isXmlExtentionFlag"]);
                 isResFile = Convert.ToBoolean(ConfigurationManager.AppSettings["isResExtentionFlag"]);
                 isMapFile = Convert.ToBoolean(ConfigurationManager.AppSettings["isMapExtentionFlag"]);
             }
             catch (ConfigurationErrorsException ex) {

             }
         }

        public void SaveConfiguration()
        {
            SetAppSettings("rootDirectory", rootDirectory); 
            SetAppSettings("isXmlExtentionFlag", isXmlFile.ToString()); 
            SetAppSettings("isResExtentionFlag", isResFile.ToString()); 
            SetAppSettings("isMapExtentionFlag", isMapFile.ToString());                     
        }

        private void SetAppSettings(string key, string value)
        {
            try
            {
                Configuration curConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = curConfig.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                curConfig.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(curConfig.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException ex)
            {

            }
        }
    }
}
