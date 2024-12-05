using LukeSignupLogin.MVVM.Models;
using SQLite;
using System.Threading.Tasks;
namespace LukeSignupLogin.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
        }

        public SQLiteAsyncConnection GetDatabase() => _database;

        public Task<int> AddUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }
        public async Task InitializeAsync()
        {
            await _database.CreateTableAsync<User>();
        }
        public Task<User> GetUserByUsernameAsync(string username)
        {
            return _database.Table<User>().FirstOrDefaultAsync(u => u.Username == username);
        }

        public Task<User> GetUserByEmailAsync(string email)
        {
            return _database.Table<User>().FirstOrDefaultAsync(u => u.Email == email);
        }

        public Task<int> DeleteUserAsync(User user)
        {
            return _database.DeleteAsync(user);
        }

        public Task<int> UpdateUserAsync(User user)
        {
            return _database.UpdateAsync(user);
        }

        public Task<List<User>> GetAllUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }
    }
}
