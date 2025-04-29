namespace jcevallosS2A.Views;

public partial class login : ContentPage
{
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] pass = { "carlos123", "ana123", "jose123" };

    public login()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string clave = txtClave.Text;

        int index = Array.IndexOf(users, usuario);

        if (index >= 0 && pass[index] == clave)
        {
            await DisplayAlert("Bienvenido", $"Hola {usuario}", "OK");

            await Navigation.PushAsync(new vElementos(usuario));
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrecta", "OK");
        }
    }
}