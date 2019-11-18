using System;
using System.Collections.Generic;
using System.Text;
using Uds.Domain.Entities;
using Uds.Domain.Repositories;
using Uds.Infra.StoreContext.DataContexts;
using Dapper;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace Uds.Infra.StoreContext.Repositories
{
    public class AdicionalPizzaRepository : IAdicionalPizzaRepository
    {
        private readonly UdsDataContext _context;
        public AdicionalPizzaRepository(UdsDataContext context)
        {
            _context = context;
        }
        public IEnumerable<AdicionalPizza> Get()
        {
            return
                _context
                .Connection
                .Query<AdicionalPizza>("SELECT [AdicionalPizzaId], [PizzaId], [Descricao], [Tempo], [Valor], [QtdAdicional] FROM [AdicionalPizza]", new { });
        }

        public Task<AdicionalPizza> Save(AdicionalPizza adicionalPizza)
        {
            _context.Connection.Execute("Tamanho_create",
             new
             {
                 Descricao = adicionalPizza.Descricao,
                 QtdAdicional = adicionalPizza.QtdAdicional,
                 Tempo = adicionalPizza.Tempo,
                 Valor = adicionalPizza.Valor,
                 PizzaId = adicionalPizza.PizzaId,

             }, commandType: CommandType.StoredProcedure);

            return Task.FromResult<AdicionalPizza>(adicionalPizza);
        }
    }
}
