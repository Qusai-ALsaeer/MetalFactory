using Acco.Migrations;
using Acco.Model;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Acco.Forms
{
    public partial class Connection : DevExpress.XtraEditors.XtraForm
    {
      public string databaseFilePath ;
      public string databaseName;
      private string localServerName;

        //<add name = "Model1" connectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\data2023.mdf;Integrated Security=True;Connect Timeout=30;MultipleActiveResultSets=True" providerName="System.Data.SqlClient" />

        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            //if (File.Exists("connectData.txt"))
            //{
            //    try
            //    {
            //        var data = File.ReadAllText("connectData.txt");
            //        var dataArray = data.Split(',');
            //        serverComboBox.Text = dataArray[0];
            //        databaseComboBox.Text = dataArray[1];
            //        userTextBox.Text = dataArray[2];
            //        passwordTextBox.Text = dataArray[3];
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error reading connectData.txt file: {ex.Message}");
            //    }
            //}


            //localAuthRadioButton.Checked= true;
            //networkAuthRadioButton.Checked = false;
            //// استخراج السيرفرات المحلية
            //var localServers = Dns.GetHostEntry(Dns.GetHostName()).AddressList
            //    .Where(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            //    .Select(ip => ip.ToString());

            //// استخراج السيرفرات في الشبكة المحلية
            //var networkServers = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources()
            //    .AsEnumerable()
            //    .Where(row => row["InstanceName"] != DBNull.Value)
            //    .Select(row => $"{row["ServerName"]}\\{row["InstanceName"]}")
            //    .Distinct();

            //// دمج السيرفرات المحلية وفي الشبكة المحلية
            //var servers = localServers.Concat(networkServers);

            //// تعبئة ComboBox بقائمة السيرفرات
            //serverComboBox.Items.AddRange(servers.ToArray());
            //serverComboBox_SelectedValueChanged(sender, e);

        }


        private void Browse_btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                // قم بتنفيذ الإجراء الذي ترغب فيه باستخدام المسار المحدد
                // على سبيل المثال، تحديث النص في TextBox
                txt_cr.Text = selectedPath;
            }

        }

        private void Creat_btn_Click(object sender, EventArgs e)
        {
            // Get database file path and name
            databaseFilePath = txt_cr.Text;
            databaseName = txt_newDataName.Text;
            localServerName = comb_server_local.Text;

            string databaseFullPath = Path.Combine(databaseFilePath, databaseName);

            // Create connection string with SQL Server authentication
            string connectionString = $"Data Source={localServerName};Initial Catalog=master;Integrated Security=True";

            // Create the new database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Check if the database already exists
                string checkDatabaseQuery = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";
                SqlCommand checkCommand = new SqlCommand(checkDatabaseQuery, connection);
                int databaseCount = (int)checkCommand.ExecuteScalar();

                if (databaseCount > 0)
                {
                    MessageBox.Show($"Database '{databaseName}' already exists.", "Database creation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Create the new database
                string createDatabaseQuery = $"CREATE DATABASE [{databaseName}] ON PRIMARY (NAME = '{databaseName}', FILENAME = '{databaseFullPath}')";
                SqlCommand createCommand = new SqlCommand(createDatabaseQuery, connection);
                createCommand.ExecuteNonQuery();
            }

            // Create the database file
            string databaseContent = $"{localServerName}\r\n{databaseName}";
            File.WriteAllText("datasa.txt", databaseContent);

            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
             connectionString = config.ConnectionStrings.ConnectionStrings["Model1"].ConnectionString;

            var builder = new SqlConnectionStringBuilder(connectionString);
            builder.DataSource = localServerName;
            builder.InitialCatalog = databaseName;

            config.ConnectionStrings.ConnectionStrings["Model1"].ConnectionString = builder.ConnectionString;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");



            // تنفيذ الـ migrations
            using (var dbContext = new Model1())
            {
                // إضافة migration جديدة
                dbContext.Database.Initialize(false);
                var migrator = new DbMigrator(new Migrations.Configuration());
                migrator.Configuration.TargetDatabase = new DbConnectionInfo(connectionString, "System.Data.SqlClient");
                migrator.Configuration.CommandTimeout = 600;
                migrator.Update();
            }

            MessageBox.Show($"Database created successfully.", "Database created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //    private void Creat_btn_Click(object sender, EventArgs e)
        //    {
        //        // Get database file path and name
        //        string databaseName = txt_newDataName.Text;
        //        string localServerName = comb_server_local.Text;

        //        // Generate random database file name
        //        string databaseFileName = $"{databaseName}_{Guid.NewGuid().ToString()}.mdf";

        //        // Specify the database file path
        //        string databaseFilePath = Path.Combine(@"D:\C Sharp App\old data\New folder", databaseFileName);

        //        // Create connection string with SQL Server authentication
        //        string connectionString = $"Data Source={localServerName};Initial Catalog=master;Integrated Security=True";

        //        // Create the new database
        //        using (var context = new Model1(connectionString))
        //        {
        //            // Check if the database already exists
        //            bool databaseExists = context.Database.SqlQuery<int>($"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'").SingleOrDefault() > 0;

        //            if (!databaseExists)
        //            {
        //                // Create the new database
        //                context.Database.Create();

        //                // Enable Code First Migrations
        //                var configuration = new DbMigrationsConfiguration<Model1>
        //                {
        //                    AutomaticMigrationsEnabled = true,
        //                    AutomaticMigrationDataLossAllowed = true
        //                };
        //                var migrator = new DbMigrator(configuration);
        //                migrator.Update();
        //            }
        //            else
        //            {
        //                MessageBox.Show($"Database '{databaseName}' already exists.", "Database creation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return;
        //            }
        //        }

        //        // Create the database file
        //        string databaseContent = $"{localServerName}\r\n{databaseName}";
        //        string filePath = Path.Combine(Application.StartupPath, "datasa.txt");

        //        if (File.Exists(filePath))
        //        {
        //            // Delete the existing file
        //            File.Delete(filePath);
        //        }

        //        // Write the database content to the file
        //        File.WriteAllText(filePath, databaseContent);

        //        // Update connection string in App.config
        //        string appConfigPath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
        //        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //        var connectionStringsSection = config.ConnectionStrings;

        //        // Get the current connection string
        //        string currentConnectionString = connectionStringsSection.ConnectionStrings["MyDbContext"].ConnectionString;

        //        // Replace the server and database names in the connection string
        //        string updatedConnectionString = currentConnectionString.Replace($"Server={localServerName};", $"Server={localServerName};");
        //        updatedConnectionString = updatedConnectionString.Replace($"Database=MyDatabase;", $"Database={databaseName};");

        //        // Update the connection string
        //        connectionStringsSection.ConnectionStrings["MyDbContext"].ConnectionString = updatedConnectionString;
        //        config.Save(ConfigurationSaveMode.Modified);

        //        // Refresh the application configuration
        //        ConfigurationManager.RefreshSection("MyDbContext");
        //        MessageBox.Show($"Database created successfully and connection string updated.", "Database created", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //}



        //private void Creat_btn_Click(object sender, EventArgs e)
        //{
        //    // Get database file path and name
        //    databaseName = txt_newDataName.Text;
        //    localServerName = comb_server_local.Text;

        //    // Generate random database file name
        //    string databaseFileName = $"{databaseName}_{Guid.NewGuid().ToString()}.mdf";

        //    // Specify the database file path
        //    databaseFilePath = Path.Combine(@"D:\C Sharp App\old data\New folder", databaseFileName);

        //    // Create connection string with SQL Server authentication
        //    string connectionString = $"Data Source={localServerName};Initial Catalog=master;Integrated Security=True";

        //    // Create the new database
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Check if the database already exists
        //        string checkDatabaseQuery = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";
        //        SqlCommand checkCommand = new SqlCommand(checkDatabaseQuery, connection);
        //        int databaseCount = (int)checkCommand.ExecuteScalar();

        //        if (databaseCount > 0)
        //        {
        //            MessageBox.Show($"Database '{databaseName}' already exists.", "Database creation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        // Create the new database
        //        string createDatabaseQuery = $"CREATE DATABASE [{databaseName}] ON PRIMARY (NAME = '{databaseName}', FILENAME = '{databaseFilePath}')";
        //        SqlCommand createCommand = new SqlCommand(createDatabaseQuery, connection);
        //        createCommand.ExecuteNonQuery();
        //    }

        //    // Create the database file
        //    string databaseContent = $"{localServerName}\r\n{databaseName}";
        //    File.WriteAllText("datasa.txt", databaseContent);

        //    // Update connection string in App.config
        //    string appConfigPath = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
        //    var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //    var connectionStringsSection = config.ConnectionStrings;

        //    // Get the current connection string
        //    string currentConnectionString = connectionStringsSection.ConnectionStrings["Model1"].ConnectionString;

        //    // Parse the current connection string to extract the server and database names
        //    var builder = new SqlConnectionStringBuilder(currentConnectionString);
        //    string oldServerName = builder.DataSource;
        //    string oldDatabaseName = builder.InitialCatalog;

        //    // Replace the server and database names in the connection string
        //    string updatedConnectionString = currentConnectionString.Replace($"Server={oldServerName};", $"Server={localServerName};");
        //    updatedConnectionString = updatedConnectionString.Replace($"Database={oldDatabaseName};", $"Database={databaseName};");

        //    // Update the connection string
        //    connectionStringsSection.ConnectionStrings["Model1"].ConnectionString = updatedConnectionString;
        //    config.Save(ConfigurationSaveMode.Modified);

        //    // Refresh the application configuration
        //    ConfigurationManager.RefreshSection("Model1");
        //    MessageBox.Show($"Database created successfully and connection string updated.", "Database created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}
        private void radioBtn_creatnewdatabase_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_creatnewdatabase.Checked)
            {
                radioBtn_openolddatabase.Checked = false;
                groupControl1.Enabled = false;
                groupControl2.Enabled = false;

            }
            // استدعاء دالة تجلب اسم السيرفر المحلي
            string localServerName = GetLocalServerName();

            // تحديث قيمة الكومبوبوكس بالاسم المحلي للسيرفر
            comb_server_local.Text = localServerName;
        }
        private string GetLocalServerName()
        {
            // دالة لجلب اسم السيرفر المحلي

            return System.Environment.MachineName;
        }
        private void radioBtn_openolddatabase_CheckedChanged(object sender, EventArgs e)
        {
            groupControl1.Enabled = true;
            groupControl2.Enabled = true;


        }
        private void ServerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // حذف جميع العناصر في قائمة قواعد البيانات
         
        }
        private void serverComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            //databaseComboBox.Items.Clear();

            //string selectedServer = serverComboBox.Text;

            //if (selectedServer == ".")
            //{
            //    selectedServer = Environment.MachineName;
            //}

            //var connectionString = $"Data Source={selectedServer};";

            //if (localAuthRadioButton.Checked)
            //{
            //    connectionString += "Integrated Security=True;";
            //}
            //else if (networkAuthRadioButton.Checked)
            //{
            //    connectionString += $"User Id={userTextBox.Text};Password={passwordTextBox.Text};";
            //}

            //try
            //{
            //    using (var connection = new SqlConnection(connectionString))
            //    {
            //        connection.Open();

            //        DataTable databasesSchemaTable = connection.GetSchema("Databases");

            //        foreach (DataRow row in databasesSchemaTable.Rows)
            //        {
            //            string databaseName = row.Field<string>("database_name");

            //            databaseComboBox.Items.Add(databaseName);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error getting databases for server {selectedServer}: {ex.Message}");
            //}
        }
        private void localAuthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (localAuthRadioButton.Checked)
            {
                networkAuthRadioButton.Checked = false;
            }
        }
        private void networkAuthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (networkAuthRadioButton.Checked)
            {
                localAuthRadioButton.Checked = false;
            }
        }
        private void connectButton_Click_1(object sender, EventArgs e)
        {
            var server = serverComboBox.Text;
            var database = databaseComboBox.Text;
            var user = userTextBox.Text;
            var password = passwordTextBox.Text;

            try
            {
                using (var db = new Model1($"Server={server};Database={database};User Id={user};Password={password}"))
                {
                    db.Database.Connection.Open();
                    db.Database.Connection.Close();
                }

                var data = $"{server},{database},{user},{password}";
                File.WriteAllText("connectData.txt", data);

                MessageBox.Show("Connection successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
           this. Close();
        }


    }
}
