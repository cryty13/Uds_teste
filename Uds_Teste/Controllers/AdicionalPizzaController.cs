using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Uds.Domain.Entities;
using Uds.Domain.Repositories;

namespace Uds_Teste.Controllers
{
    public class AdicionalPizzaController : Controller, IAdicionalPizzaRepository
    {
        private readonly IAdicionalPizzaRepository _repository;
        public AdicionalPizzaController(IAdicionalPizzaRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        [Route("Get/AdicionalPizza")]
        public IEnumerable<AdicionalPizza> Get()
        {
            return _repository.Get();
        }
        [HttpPost]
        [Route("Post/AdicionalPizza")]
        public Task<AdicionalPizza> Save(AdicionalPizza AdicionalPizza)
        {
            return _repository.Save(AdicionalPizza);
        }
    }
}