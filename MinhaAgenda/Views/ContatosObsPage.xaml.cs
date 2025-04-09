using CasosDeUso.Interface;
using CoreBusiness.Entidades;
using System.Collections.ObjectModel;

namespace MinhaAgenda.Views;

public partial class ContatosObsPage : ContentPage
{

            
    private async void btnAdicionar_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"{nameof(AdicionarContatoPage)}");
    }
}