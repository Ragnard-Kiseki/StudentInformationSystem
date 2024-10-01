using Dapper;
using Microsoft.Data.Sqlite;
using Student_Information_System.Model;
using System.Configuration;

namespace Student_Information_System.Controller;

internal class DBController : IDisposable
{
    private readonly string connectionString;
    private SqliteConnection? connection;

    public DBController()
    {
        // Retrieve connection string from app.config
        connectionString = ConfigurationManager.ConnectionStrings["SISCon"].ConnectionString;
    }

    public SqliteConnection GetConnection()
    {
        connection = new SqliteConnection(connectionString);
        return connection;
    }

    public (UserRole? Role, Int64? UserId) ValidateUser(string username, string password)
    {
        using var connection = new SqliteConnection(connectionString);
        var query = "SELECT role, user_id FROM Users WHERE username = @Username AND password = @Password";
        var result = connection.QuerySingleOrDefault(query, new { Username = username, Password = password });

        if (result != null)
        {
            // Parse the user role and get the user ID
            var userRole = Enum.Parse<UserRole>(result.role);
            return (userRole, result.user_id);
        }

        return (null, null); // Return nulls if no user is found
    }

    public void Dispose()
    {
        // Dispose of the connection if it was created
        if (connection != null)
        {
            connection.Dispose();
            connection = null;
        }
    }

    public T Execute<T>(Func<SqliteConnection, T> action)
    {
        using var connection = GetConnection();
        connection.Open();
        return action(connection);
    }

}