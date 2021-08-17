using System.Collections.Generic;
using System.Threading.Tasks;
using Cadastros.Domain.Models;

namespace Cadastros.Domain.Services {
    public interface IPessoasService {
        Task<IEnumerable<Pessoas>> ListAsync();
    }
}