using LukeSignupLogin.Services;
namespace LukeSignupLogin
{
    public partial class App : Application
    {
        public static DatabaseService Database { get; private set; }
        public App()
        {
            InitializeComponent();
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "YourDatabase.db3");
            Database = new DatabaseService(dbPath);
            Database.InitializeAsync().Wait();
            MainPage = new AppShell();
        }
    }
}
