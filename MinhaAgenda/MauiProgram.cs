// Aqui ele está importando as bibliotecas para usar no código
using CasosDeUso;
using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging; 
using MinhaAgenda.Plugins.SqlLite; // Aqui ele está pegando o banco de dados
using MinhaAgenda.Views; // E aqui ele pega as telas que foram feitas

namespace MinhaAgenda
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            // Aqui a gente tá criando um constructor:
            var builder = MauiApp.CreateBuilder();

            // Aqui ele está pegando uma das ferramenteas que importamos ali em cima e configurando elas:
            builder.UseMauiApp<App>().UseMauiCommunityToolkit();

            // Aqui ele está definindo as fontes:
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            
#if DEBUG
            builder.Logging.AddDebug();// Criando um Debug:
#endif

            // Aqui a gente já está criando os serviços que vamos estar usando, no caso, isso seria uma injeção de dependencia

            builder.Services.AddSingleton<IRepositorioDeContatos, RepositorioContatosSqlLite>(); // Nesse serviço ele está registrando os repositórios do contato(SQLite)

            // Aqui vamos configurar as regras de negócio

            builder.Services.AddSingleton<IVisualizarContatosUseCase, VisualizarContatosUseCase>();// - Visualizar contatos

            builder.Services.AddSingleton<IApagarContatoUseCase, ApagarContatosUseCase>();// - Apagar contatos

            builder.Services.AddSingleton<IAdicionarContatoUseCase, AdicionarContatoUseCase>();  // - Adicionar contatos
            
            builder.Services.AddSingleton<IEditarContatoUseCase, EditarContatoUseCase>();// - Editar contatos

            // Aqui ele registra as telas do APP

            builder.Services.AddSingleton<ContatosPage>(); // - Sendo a página principal
          
            builder.Services.AddSingleton<EditarContatoPage>();  // - A pagina para editar o contato
            
            builder.Services.AddSingleton<AdicionarContatoPage>();// - E a pagina para adicionar o contato

            
            return builder.Build();// Usando todas as configurações a cima, ele cria o nosso app
        }
    }
}