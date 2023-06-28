namespace SHGP.Repository
{
    public class DatabaseSettings
    {
        public static string ConnectionString { get; } = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SD.mdf;Integrated Security=True";
    }
}
