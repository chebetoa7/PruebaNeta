using pruebaExamen.Services;
using pruebaExamen.View;
using System.Windows.Input;

namespace pruebaExamen.ViewModel
{
    public class HomeViewModel : BaseViewModel
    {
        
        #region Command
        public ICommand IniciaExamenCommand { get; set; }
        #endregion


        public HomeViewModel() 
        {
            
            IniciaExamenCommand = new Command(async () => await funtionIniciaExamenCommand());
        }

        private async Task funtionIniciaExamenCommand()
        {
            bool v = true;
            try 
            {
                 v = await NavigateAsync(MauiProgram.CreateMauiApp().Services.GetService<ListUserPage>());
            } catch (Exception exM) 
            {
                Console.WriteLine($"Error en funtionIniciaExamenCommand{v.ToString()}: -> {exM.Message}" );
            }
        }

    }
}
