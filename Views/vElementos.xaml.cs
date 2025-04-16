namespace jcevallosS2A.Views;

public partial class vElementos : ContentPage
{
	public vElementos()
	{
		InitializeComponent();
	}

    private void bntPaises_Clicked(object sender, EventArgs e)
    {
		try
        {
			if (pkPaises.SelectedIndex == -1){
				DisplayAlert("Error", "El dato no existe", "Cerrar");
			
			}else { 

				string pais = pkPaises.Items[pkPaises.SelectedIndex].ToString();
				DisplayAlert("Paises", "El pais seleccionado es " + pais, "Cerrar");
            }
        }

		catch (Exception ex)
        {
			DisplayAlert("Error", ex.Message, "Cerrar");
        }
    }

    private void btnfecha_Clicked(object sender, EventArgs e)
    {
		string date = fecha.Date.ToString();
		DisplayAlert("Error", "La fecha seleccionada es " + date, "Cerrar");
    }
}