using System.Collections.Generic;
using System.Threading.Tasks;
using Cadastros.Domain.Models;
using Cadastros.Domain.Services;
namespace Supermercado.API.Services
{
    public class PessoasService : IPessoasService
    {
        public Task<IEnumerable<Pessoas>> ListAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}