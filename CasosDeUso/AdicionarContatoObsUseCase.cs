

using CasosDeUso.Interface;
using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;

namespace CasosDeUso
{
    public class AdicionarContatoObsUseCase : IAdicionarContatoObsUseCase
    {
        private readonly IRepositorioDeContatosObs _contatoRepository;

        public AdicionarContatoObsUseCase(IRepositorioDeContatosObs contatoObsRepository)
        {
            _contatoRepository = contatoObsRepository;
        }

        public async Task ExecutaAsync(ContatoObsercavao contatoObsercavao)
        {
            await _contatoRepository.AdicionarContato(contatoObsercavao);
        }

    }
}
