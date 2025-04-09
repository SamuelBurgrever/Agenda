using CasosDeUso.Interface;

namespace MinhaAgenda.Views;

public partial class AdicionarContatoOBSPage : ContentPage
{
    private readonly IAdicionarContatoObsUseCase _adicionarContatoUseCase;
	public AdicionarContatoOBSPage(IAdicionarContatoObsUseCase adicionarContatoUseCase)
	{
		InitializeComponent();
        _adicionarContatoUseCase = adicionarContatoUseCase;
	}

	private async void contatoObsCtrl_OnSave(object sender, EventArgs e)
	{
		await _adicionarContatoUseCase.ExecutaAsync(new CoreBusiness.Entidades.ContatoObsercavao(contatosObsCtrl.Name, contatosObsCtrl.Email, contatosObsCtrl.Obs));
		await Shell.Current.GoToAsync($"//{nameof(ContatosObsPage)}");
	}

	private void contatoObsCtrl_OnCancel(object sender, EventArgs e)
	{
		Shell.Current.GoToAsync($"//{nameof(ContatosObsPage)}");
	}
    private void contatoObsCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Erro", e, "Ok");
    }
}