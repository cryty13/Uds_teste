using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uds.Domain.Entities;

namespace Uds.Domain.Repositories
{
    public interface IAdicionalPizzaRepository
    {
        Task<AdicionalPizza> Save(AdicionalPizza adicionalPizza);
        IEnumerable<AdicionalPizza> Get();
    }
}
