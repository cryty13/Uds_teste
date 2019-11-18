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
    public class PersonalizacaoRepository : IPersonalizacaoRepository
    {
        private readonly UdsDataContext _context;
        public PersonalizacaoRepository(UdsDataContext context)
        {
            _context = context;
        }
        public IEnumerable<Personalizacao> Get()
        {
            return
                _context
                .Connection
                .Query<Personalizacao>("SELECT [PersonalizacaoId], [Descricao],[Valor], [Tempo] FROM [Personalizacao]", new { });
        }

        public Task<Personalizacao> Save(Personalizacao Personalizacao)
        {
            _context.Connection.Execute("Personalizacao_create",
              new
              {
                  Descricao = Personalizacao.Descricao,
                  Tempo = Personalizacao.Tempo,
                  Valor = Personalizacao.Valor,

              }, commandType: CommandType.StoredProcedure);

            return Task.FromResult<Personalizacao>(Personalizacao);
        }
    }
}
