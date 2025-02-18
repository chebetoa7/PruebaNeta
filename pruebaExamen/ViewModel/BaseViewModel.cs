using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using pruebaExamen.Model;

namespace pruebaExamen.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        public async Task<bool> NavigateAsync(Page NextPage)
        {
            await Shell.Current.Navigation.PushAsync(NextPage);
            return true;
        }
        public async Task<bool> CloseNavigationAsync()
        {
            await Shell.Current.Navigation.PopAsync();
            return true;
        }

        // Propiedad Users
        private List<UserModel> _users;

        public List<UserModel> Users
        {
            get => _users;
            set
            {
                _users = value;
                OnPropertyChanged(); // Notificar que la propiedad ha cambiado
            }
        }

    }
}
