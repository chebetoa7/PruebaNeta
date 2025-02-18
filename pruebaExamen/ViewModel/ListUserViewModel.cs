using pruebaExamen.Model;
using pruebaExamen.Services;
using pruebaExamen.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace pruebaExamen.ViewModel
{
    public class ListUserViewModel : BaseViewModel
    {
        #region Vars
        private readonly UserService _userService;
        public ICommand UserSelectedCommand { get; }
        #endregion
        public ListUserViewModel() 
        {
            _userService = new UserService();
            UserSelectedCommand = new CommunityToolkit.Mvvm.Input.RelayCommand<UserModel>(OnUserSelected);
        }
        private async void OnUserSelected(UserModel user)
        {
            if (user == null)
                return;

            // Navegar a la página de detalles del usuario
            await NavigateAsync(new UserDetailsPage(user));
        }
        public async Task LoadUsersAsync()
        {
            Users = await _userService.GetUsersAsync();
        }
    }
}
