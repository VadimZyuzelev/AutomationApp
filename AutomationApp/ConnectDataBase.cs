using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AutomationApp
{
    class ConnectDataBase
    {
        private SqlConnection sqlConnection;
        private SqlConnectionStringBuilder stringBuilder;

        private void SetStringConnection()
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["AutomationApp.Properties.Settings.AutomationAppDBConnectionString"].ConnectionString);
        }

        public SqlConnection GetStringConnection()
        {
            return sqlConnection;
        }

        private string GetDataSource()
        {
            string DataSource;
            DataSource = ConfigurationManager.AppSettings.Get("DataSource");
            return DataSource;
        }

        private string GetInitialCatalog()
        {
            string InitialCatalog;
            InitialCatalog = ConfigurationManager.AppSettings.Get("InitialCatalog");
            return InitialCatalog;
        }

        public void CreateStringConnection(string UserID, string Password)
        {
            SetStringConnection();
            stringBuilder = new SqlConnectionStringBuilder(GetStringConnection().ConnectionString)
            {
                DataSource = GetDataSource(),
                InitialCatalog = GetInitialCatalog(),
                IntegratedSecurity = false,
                UserID = UserID,
                Password = Password
            };

            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConnectionStringsSection connectionStringsSection = (ConnectionStringsSection)configuration.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["AutomationApp.Properties.Settings.AutomationAppDBConnectionString"].ConnectionString = stringBuilder.ConnectionString;
            configuration.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

            SetStringConnection();
        }

        public void OpenConnection()
        {
            SetStringConnection();
            if (GetStringConnection().State != ConnectionState.Open)
            {
                GetStringConnection().Open();
            }  
        }

        public void CloseConnection()
        {
            SetStringConnection();
            if (GetStringConnection().State != ConnectionState.Closed)
            {
                GetStringConnection().Close();
                GetStringConnection().Dispose();
            }
        }

        public bool CheckOpenConnection()
        {
            if (GetStringConnection().State == ConnectionState.Open)
            {
                return true;
            }
            else
                return false;
        }
    }
}
