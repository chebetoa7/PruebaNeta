using pruebaExamen.ViewModel;

namespace pruebaExamen.View;

public partial class HomePage : ContentPage
{
    #region Vars
    public readonly HomeViewModel ViewModel; 
    #endregion
    public HomePage()
	{
		InitializeComponent();
        BindingContext = ViewModel = new HomeViewModel();
	}
}