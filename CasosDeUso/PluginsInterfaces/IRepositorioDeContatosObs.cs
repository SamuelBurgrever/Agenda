using CoreBusiness.Entidades;

namespace CasosDeUso.PluginsInterfaces
{
    public interface IRepositorioDeContatosObs
    {
        Task AdicionarContato(ContatoObsercavao contatoObsrvacao);
        Task AdicionarContatoAsync(ContatoObsercavao contatoObservacao);
    }
}
