using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acco
{
    internal class Startup
    {
        public static void Initialize()
        {
            string databaseFilePath = "datasa.txt";

            if (File.Exists(databaseFilePath))
            {
                string[] lines = File.ReadAllLines(databaseFilePath);

                if (lines.Length >= 2)
                {
                    string serverName_app = lines[0];
                    string databaseName_app = lines[1];

                    Properties.Settings.Default.serverName = serverName_app;
                    Properties.Settings.Default.databaseName = databaseName_app;

                    // قم بتحديث نص الاتصال في ملف التكوين
                    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    var connectionString = config.ConnectionStrings.ConnectionStrings["Model1"].ConnectionString;

                    var builder = new SqlConnectionStringBuilder(connectionString);
                    builder.DataSource = serverName_app;
                    builder.InitialCatalog = databaseName_app;

                    config.ConnectionStrings.ConnectionStrings["Model1"].ConnectionString = builder.ConnectionString;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("connectionStrings");
                }
                else
                {
                    MessageBox.Show("خطأ باسم قاعدة البيانات");
                }
            }
            else
            {
                MessageBox.Show("ملف الاتصال غير موجود .. يجب انشاء اتصال بقاعدة البيانات");
            }
        }

    }
}
