using System;
using System.Collections.Generic;
using System.Text;
using Uds.Domain.Entities;
using Uds.Domain.Repositories;
using Uds.Infra.StoreContext.DataContexts;
using Dapper;
using System.Linq;
using System.Threading.Tasks;
using System.Data;

namespace Uds.Infra.StoreContext.Repositories
{
    public class TamanhoRepository : ITamanhoRepository
    {
        private readonly UdsDataContext _context;
        public TamanhoRepository(UdsDataContext context)
        {
            _context = context;
        }


        public IEnumerable<Tamanho> Get()
        {
            return
                _context
                .Connection
                .Query<Tamanho>("SELECT [TamanhoId], [descricao],[Tempo], [Valor] FROM [Tamanho]", new { });
        }

        public Task<Tamanho> Save(Tamanho Tamanho)
        {
            _context.Connection.Execute("Tamanho_create",
              new
              {
                  Descricao = Tamanho.Descricao,
                  Tempo = Tamanho.Tempo,
                  Valor = Tamanho.Valor,
                 
              }, commandType: CommandType.StoredProcedure);

            return Task.FromResult<Tamanho>(Tamanho);
        }
    }
}
