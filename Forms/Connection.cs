using Acco.Model;
using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acco.Forms
{
    public partial class Connection : DevExpress.XtraEditors.XtraForm
    {
      public  string databaseFilePath ;
      public string databaseName;
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

        //private bool DatabaseExists(string databaseName)
        //{
        //    string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            string query = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";
        //            SqlCommand command = new SqlCommand(query, connection);
        //            int count = (int)command.ExecuteScalar();
        //            return count > 0;
        //        }
        //        catch (SqlException ex)
        //        {
        //            // handle the exception here
        //            MessageBox.Show($"An error occurred while checking for the existence of the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //    }
        //}

        private void Browse_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "SQL Server Database (*.mdf)|*.mdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt_cr.Text = saveFileDialog.FileName;
            }
        }

        private void Creat_btn_Click(object sender, EventArgs e)
        {
            // Get database file path and name
             databaseFilePath = txt_cr.Text;
             databaseName = Path.GetFileNameWithoutExtension(databaseFilePath);

            // Create connection string with SQL Server authentication
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog={databaseName}";

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
                string createDatabaseQuery = $"CREATE DATABASE [{databaseName}] ON PRIMARY (NAME = {databaseName}, FILENAME = '{databaseFilePath}')";
                SqlCommand createCommand = new SqlCommand(createDatabaseQuery, connection);
                createCommand.ExecuteNonQuery();
            }

            MessageBox.Show($"Database created successfully.", "Database created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void attach_btn_Click(object sender, EventArgs e)
        {
            string databaseFilePath = txt_cr.Text;
            string databaseName = Path.GetFileNameWithoutExtension(databaseFilePath);
            string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30;";

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                // Attach the database
                string attachDatabaseQuery = $"CREATE DATABASE [{databaseName}] ON (FILENAME = '{databaseFilePath}') FOR ATTACH";
                SqlCommand attachCommand = new SqlCommand(attachDatabaseQuery, connection);
                attachCommand.ExecuteNonQuery();

                MessageBox.Show($"Database attached successfully.", "Database attached", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error attaching database: {ex.Message}", "Database attachment failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }



        //private void Creat_btn_Click(object sender, EventArgs e)
        //{
        //    string databaseFilePath = txt_cr.Text;
        //    string databaseName = Path.GetFileNameWithoutExtension(databaseFilePath);

        //    using (SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True"))
        //    {
        //        connection.Open();

        //        // Create the database
        //        string createDatabaseQuery = $"CREATE DATABASE [{databaseName}] ON PRIMARY (NAME = {databaseName}_data, FILENAME = '{databaseFilePath}') LOG ON (NAME = {databaseName}_log, FILENAME = '{Path.GetDirectoryName(databaseFilePath)}\\{databaseName}_log.ldf')";
        //        SqlCommand command = new SqlCommand(createDatabaseQuery, connection);
        //        command.ExecuteNonQuery();

        //        // Update the connection string for the new database
        //        string newConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog={databaseName};Integrated Security=True;Connect Timeout=30;";
        //        var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        //        var connectionStringSection = (ConnectionStringsSection)configuration.GetSection("connectionStrings");
        //        var connectionString = connectionStringSection.ConnectionStrings["Model1"].ConnectionString;
        //        connectionStringSection.ConnectionStrings["Model1"].ConnectionString = newConnectionString;
        //        configuration.Save(ConfigurationSaveMode.Modified);
        //        ConfigurationManager.RefreshSection("connectionStrings");

        //        MessageBox.Show($"Database created and connected successfully.", "Database created and connected", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}



        //private void Creat_btn_Click(object sender, EventArgs e)
        //{
        //    using (var db = new Model1())
        //    {
        //        // close the current database connection
        //        db.Database.Connection.Close();

        //        // get the database name from the text box
        //        string databaseName = txt_databasename.Text.Trim();

        //        // validate the database name
        //        if (string.IsNullOrEmpty(databaseName))
        //        {
        //            MessageBox.Show("Please enter a valid database name", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // select a file to save the database
        //        var saveFileDialog = new SaveFileDialog();
        //        saveFileDialog.Filter = "Database files (*.mdf)|*.mdf";
        //        saveFileDialog.RestoreDirectory = true;
        //        saveFileDialog.FileName = $"{databaseName}.mdf";
        //        if (saveFileDialog.ShowDialog() != DialogResult.OK)
        //        {
        //            return;
        //        }

        //        // specify the database path
        //        string databasePath = Path.GetDirectoryName(saveFileDialog.FileName);
        //        string databaseFile = Path.Combine(databasePath, $"{databaseName}_{Guid.NewGuid()}.mdf");

        //        // check if a database with the same name already exists
        //        if (DatabaseExists(databaseName))
        //        {
        //            MessageBox.Show($"Database with name {databaseName} already exists, please choose a different name", "Database already exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // grant modify permission to the current user for the folder containing the database file
        //        string folderPath = Path.GetDirectoryName(saveFileDialog.FileName);
        //        DirectoryInfo folder = new DirectoryInfo(folderPath);
        //        DirectorySecurity folderSecurity = folder.GetAccessControl();
        //        string user = Environment.UserDomainName + "\\" + Environment.UserName;
        //        folderSecurity.AddAccessRule(new FileSystemAccessRule(user, FileSystemRights.Modify, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.InheritOnly, AccessControlType.Allow));
        //        folder.SetAccessControl(folderSecurity);

        //        // create the new database
        //        string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databaseFile};Initial Catalog={databaseName};Integrated Security=True";
        //        using (SqlConnection connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            // create the database
        //            string createDatabaseQuery = $"CREATE DATABASE {databaseName} ON PRIMARY (NAME={databaseName}_data, FILENAME='{databaseFile}') LOG ON (NAME={databaseName}_log, FILENAME='{databasePath}\\{databaseName}_log.ldf')";
        //            SqlCommand command = new SqlCommand(createDatabaseQuery, connection);
        //            command.ExecuteNonQuery();


        //        }

        //        // open the new database connection
        //        db.Database.Connection.ConnectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={databaseFile};Initial Catalog={databaseName};Integrated Security=True";
        //        db.Database.Connection.Open();

        //        // close the database connection
        //        db.Database.Connection.Close();

        //        // display the path of the new database file
        //        MessageBox.Show($"Database created successfully. Database file path: {databaseFile}", "Database created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        //تحقق من وجود قاعدة بيانات بنفس الاسم
        private void radioBtn_creatnewdatabase_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtn_creatnewdatabase.Checked)
            {
                radioBtn_openolddatabase.Checked = false;
                groupControl1.Enabled = false;
                groupControl2.Enabled = false;

            }
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







        //private void serverComboBox_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    databaseComboBox.Items.Clear();

        //    string selectedServer = serverComboBox.Text;

        //    if (selectedServer == ".")
        //    {
        //        selectedServer = Environment.MachineName;
        //    }

        //    var connectionString = $"Data Source={selectedServer};Integrated Security=True;";

        //    try
        //    {
        //        using (var connection = new SqlConnection(connectionString))
        //        {
        //            connection.Open();

        //            DataTable databasesSchemaTable = connection.GetSchema("Databases");

        //            foreach (DataRow row in databasesSchemaTable.Rows)
        //            {
        //                string databaseName = row.Field<string>("database_name");

        //                databaseComboBox.Items.Add(databaseName);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error getting databases for server {selectedServer}: {ex.Message}");
        //    }
        //}
    }
}
