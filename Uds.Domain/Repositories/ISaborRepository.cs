using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uds.Domain.Entities;

namespace Uds.Domain.Repositories
{
    public interface ISaborRepository
    {
        Task<Sabor> Save(Sabor sabor);
        IEnumerable<Sabor> Get();
    }
}
