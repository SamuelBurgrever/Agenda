using CasosDeUso.PluginsInterfaces;
using CoreBusiness.Entidades;
using MinhaAgenda.Plugins.SqlLite;
using SQLite;


namespace SqlLite
{
    public class RepositorioContatosOBSSqlLite : IRepositorioDeContatosObs
    {

        private SQLiteAsyncConnection _database;

        public RepositorioContatosOBSSqlLite()
        {
            _database = new SQLiteAsyncConnection(Constantes._databasepath);
            _database.CreateTableAsync<ContatoObsercavao>().Wait();

        }

        public Task AdicionarContato(ContatoObsercavao contatoObsrvacao)
        {
            throw new NotImplementedException();
        }

        public Task AdicionarContato(object contatoObsrvacao)
        {
            throw new NotImplementedException();
        }

        public async Task AdicionarContatoAsync(ContatoObsercavao contatoObservacao)
        {
            await _database.InsertAsync(contatoObservacao);
        }
    }
}
