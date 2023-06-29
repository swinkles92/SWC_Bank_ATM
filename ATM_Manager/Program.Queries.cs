using Microsoft.Data.Sqlite;
using SW.Shared;

partial class Program
{
    static SqliteConnection CreateConnection()
    {
        SqliteConnection sqlite_conn = new("" +
            "Data Source = " +
            "/Users/samuelwinkles/Documents/CSharpPrograms/swcbank.db;");
        try
        {
            sqlite_conn.Open();
            string selectQuery = "SELECT * FROM users";
        }
        catch(Exception ex) { }
        return sqlite_conn;
    }
    static void ReadData(SqliteConnection conn)
    {
        SqliteDataReader sqlite_datareader;
        SqliteCommand sqlite_cmd = conn.CreateCommand();
        sqlite_cmd.CommandText = "SELECT * FROM users";
        sqlite_datareader = sqlite_cmd.ExecuteReader();
        while(sqlite_datareader.Read())
        {
            string reader = sqlite_datareader.GetString(0);
            WriteLine(reader);
        }
        conn.Close();
    }
}

