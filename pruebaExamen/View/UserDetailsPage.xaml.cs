using pruebaExamen.Model;

namespace pruebaExamen.View;

public partial class UserDetailsPage : ContentPage
{
	public UserDetailsPage(UserModel user)
	{
		InitializeComponent();
        BindingContext = user;
    }
}