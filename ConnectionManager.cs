//using System;
//using System.Configuration;
//using System.IO;
//using System.Windows.Forms;

//namespace Acco
//{
 
//        public static class ConnectionManager
//        {
//            public static void UpdateConnectionString(string databaseName)
//            {
//                string connectionStringName = "Model1"; 

//                string newConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog={databaseName};Integrated Security=True;Connect Timeout=30;";

//                var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
//                ConnectionStringsSection connectionStringSection = null;

//                if (configuration.ConnectionStrings.ConnectionStrings.Count > 0)
//                {
//                    connectionStringSection = (ConnectionStringsSection)configuration.GetSection("connectionStrings");
//                }

//                if (connectionStringSection == null || connectionStringSection.ConnectionStrings[connectionStringName] == null)
//                {
//                    var connectionStringsSection = new ConnectionStringsSection();
//                    connectionStringsSection.ConnectionStrings.Add(new ConnectionStringSettings(connectionStringName, newConnectionString.Replace("|DataDirectory|", Path.GetDirectoryName(Application.ExecutablePath))));
//                    configuration.Sections.Add("connectionStrings", connectionStringsSection);
//                }
//                else
//                {
//                    connectionStringSection.ConnectionStrings[connectionStringName].ConnectionString = newConnectionString.Replace("Initial Catalog=master", $"Initial Catalog={databaseName}").Replace("|DataDirectory|", Path.GetDirectoryName(Application.ExecutablePath));
//                    configuration.Save(ConfigurationSaveMode.Modified);
//                    ConfigurationManager.RefreshSection("connectionStrings");
//                }

//                configuration.Save(ConfigurationSaveMode.Modified);
//                ConfigurationManager.RefreshSection("connectionStrings");
//            }
//        }
    
//}
