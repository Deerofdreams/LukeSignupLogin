using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LukeSignupLogin.MVVM.Models;
namespace LukeSignupLogin.MVVM.ViewModel
{
    public class UserViewModel
    {
        public ObservableCollection<User> Users { get; set; }

        public UserViewModel()
        {
            Users = new ObservableCollection<User>();
            LoadUsersAsync();
        }

        private async Task LoadUsersAsync()
        {
            var users = await App.Database.GetAllUsersAsync();
            Users.Clear();
            foreach (var user in users)
            {
                Users.Add(user);
            }
        }

        public async Task AddUserAsync(User newUser)
        {
            await App.Database.AddUserAsync(newUser);
            Users.Add(newUser);
        }
    }
}
