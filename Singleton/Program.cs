// Manual demonstration of how Singleton works

// Create an instance of the class
var con1 = DbConnection.Instance;
con1.Connect();

Console.WriteLine();

// Create another instance of the class
var con2 = DbConnection.Instance;
con2.Connect();

public class DbConnection
{
    private static DbConnection? instance;
    private static byte numberOfInstance;

    public static DbConnection Instance
    {
        get
        {
            if (instance is null)
            {
                instance = new DbConnection();

                // Incremental number to check how many instances are created per property call
                numberOfInstance++;
            }
            return instance;
        }
    }

    private DbConnection()
    {

    }

    public void Connect()
    {
        Console.WriteLine($"Connection established\nNumber of connections: {numberOfInstance}");
    }
}