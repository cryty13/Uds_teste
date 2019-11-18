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
using Uds.Domain.Queries;

namespace Uds.Infra.StoreContext.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly UdsDataContext _context;
        private readonly ISaborRepository _iSaborRepository;
        private readonly ITamanhoRepository _iTamanhoRepository;
        public PizzaRepository(UdsDataContext context, ISaborRepository iSaborRepository, ITamanhoRepository iTamanhoRepository)
        {
            _context = context;
            _iSaborRepository = iSaborRepository;
            _iTamanhoRepository = iTamanhoRepository;
        }
        public IEnumerable<Pizza> Get()
        {
            return
                _context
                .Connection
                .Query<Pizza>("SELECT [PizzaId], [Tamanho], [Sabor], [ValorTotal] , [TempoPreparo] FROM [Pizza]", new { });
        }

        public Task<ResultCalcular> Calcular(Pizza pizza)
        {
            try
            {
                ResultCalcular resultCalcular = new ResultCalcular();
                Sabor sabor = _iSaborRepository.Get().ToList().Where(x => x.Descricao == pizza.Sabor).FirstOrDefault();
                Tamanho tamanho = _iTamanhoRepository.Get().Where(x => x.Descricao == pizza.Tamanho).FirstOrDefault();
                if (pizza.adicionalPizza != null)
                {
                    foreach (var item in pizza.adicionalPizza)
                    {
                        pizza.TempoPreparo = pizza.TempoPreparo + item.Tempo;
                        pizza.ValorTotal = pizza.ValorTotal + item.Valor;
                    }
                }

                pizza.ValorTotal = pizza.ValorTotal + tamanho.Valor;
                if (sabor.Tempo != 0)
                    pizza.TempoPreparo = pizza.TempoPreparo + tamanho.Tempo + sabor.Tempo;
                else
                    pizza.TempoPreparo = pizza.TempoPreparo + tamanho.Tempo;

                resultCalcular.ValorTotal = pizza.ValorTotal;
                resultCalcular.TempoPreparo = pizza.TempoPreparo;
                return Task.FromResult<ResultCalcular>(resultCalcular);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Task<Pizza> Save(Pizza pizza)
        {
            try
            {
                _context.Connection.Execute("Pizza_create",
                new
                {
                    Tamanho = pizza.Tamanho,
                    Sabor = pizza.Sabor,
                    ValorTotal = pizza.ValorTotal,
                    TempoPreparo = pizza.TempoPreparo,
                }, commandType: CommandType.StoredProcedure); ;

                return Task.FromResult<Pizza>(pizza);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
