using MySql.Data.MySqlClient;

namespace MyStore
{
    class BussinessLogic
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "db_storemanager";
        string _id = "root"; 
        string _pw = "nonamed2971!"; 
        string _connectionAddress = "";

        MySqlConnection mysql;
        public MySqlConnection MySql
        {
            get { return mysql; }
        }

        public void openDB()
        {
            _connectionAddress = string.Format("server='{0}';port='{1}';database='{2}';user='{3}';password='{4}'", _server, _port, _database, _id, _pw);
            mysql = new MySqlConnection(_connectionAddress);
            mysql.Open();
        }

        public void closeDB()
        {
            mysql.Close();
        }
    }
}

