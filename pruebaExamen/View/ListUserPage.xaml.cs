
using pruebaExamen.ViewModel;

namespace pruebaExamen.View;

public partial class ListUserPage : ContentPage
{
    private readonly ListUserViewModel viewModel_;
    public ListUserPage(ListUserViewModel viewModel)
	{
		InitializeComponent();
        viewModel_ = viewModel;
        BindingContext = viewModel;
        LoadUsers();
    }
    private async void LoadUsers()
    {
        await viewModel_.LoadUsersAsync();
    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        if (sender is Border border)
        {
            if (int.TryParse(border.ClassId, out int userId))
            {
                var selectedUser = viewModel_.Users.FirstOrDefault(u => u.id == userId);

                if (selectedUser != null)
                {
                    await Navigation.PushAsync(new UserDetailsPage(selectedUser));
                }
            }
        }
    }
}