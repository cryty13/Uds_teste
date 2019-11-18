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
    public class SaborRepository : ISaborRepository
    {
        private readonly UdsDataContext _context;
        public SaborRepository(UdsDataContext context)
        {
            _context = context;
        }


        public IEnumerable<Sabor> Get()
        {
            return
                _context
                .Connection
                .Query<Sabor>("SELECT [SaborId], [descricao],[Tempo] FROM [Sabor]", new { });
        }

        public Task<Sabor> Save(Sabor Sabor)
        {
            _context.Connection.Execute("Sabor_create",
            new
            {
                Descricao = Sabor.Descricao,
                Tempo = Sabor.Tempo,
            }, commandType: CommandType.StoredProcedure);

            return Task.FromResult<Sabor>(Sabor);

        }
    }
}
