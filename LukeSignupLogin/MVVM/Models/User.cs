using SQLite;
namespace LukeSignupLogin.MVVM.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Unique]
        public string Username { get; set; }

        public string Password { get; set; }

        [Unique]
        public string Email { get; set; }
    }
}
