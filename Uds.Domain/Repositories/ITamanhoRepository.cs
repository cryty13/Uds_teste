using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uds.Domain.Entities;

namespace Uds.Domain.Repositories
{
    public interface ITamanhoRepository
    {
        Task<Tamanho> Save(Tamanho tamanho);
        IEnumerable<Tamanho> Get();
    }
}
