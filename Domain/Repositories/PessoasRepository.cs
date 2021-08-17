using System.Collections.Generic;
using System.Threading.Tasks;
using Cadastros.Domain.Models;

namespace Cadastros.Domain.Repositories {
    public interface PessoasRepository {
        Task<IEnumerable<Pessoas>> ListAsync();
        Task AddAsync(Pessoas pessoas);
        Task<Pessoas> FindByIdAsync(int id);
        void Update(Pessoas pessoas);
        void Remove(Pessoas pessoas);
    }
}