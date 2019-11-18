using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uds.Domain.Entities;

namespace Uds.Domain.Repositories
{
    public interface IPersonalizacaoRepository
    {
        Task<Personalizacao> Save(Personalizacao Personalizacao);
        IEnumerable<Personalizacao> Get();
    }
}
