using NSE.Core.DomainObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NSE.Cliente.API.Models
{
    public interface IClientRepository : IRepository<Client>
    {
        void Adicionar(Client cliente);

        Task<IEnumerable<Client>> ObterTodos();
        Task<Client> ObterPorCpf(string cpf);
    }
}
