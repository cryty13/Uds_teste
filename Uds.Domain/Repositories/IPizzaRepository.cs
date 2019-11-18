using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uds.Domain.Entities;
using Uds.Domain.Queries;

namespace Uds.Domain.Repositories
{
    public interface IPizzaRepository
    {
        Task<Pizza> Save(Pizza pizza);
        Task<ResultCalcular> Calcular(Pizza pizza);
        IEnumerable<Pizza> Get();
    }
}
