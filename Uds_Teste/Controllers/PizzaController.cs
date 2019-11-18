using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Uds.Domain.Entities;
using Uds.Domain.Queries;
using Uds.Domain.Repositories;

namespace Uds_Teste.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository _repository;
        public PizzaController(IPizzaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("Get/Pizza")]
        public IEnumerable<Pizza> Get()
        {
            return _repository.Get();
        }
        [HttpPost]
        [Route("Post/Calcular")]
        public Task<ResultCalcular> Calcular([FromBody]object objPizza)
        {
            Pizza pizza = JsonConvert.DeserializeObject<Pizza>(objPizza.ToString());
            return _repository.Calcular(pizza);
        }

        [HttpPost]
        [Route("Post/Pizza")]
        public Task<Pizza> Save([FromBody]object objPizza)
        {
            Pizza pizza = JsonConvert.DeserializeObject<Pizza>(objPizza.ToString());
            return _repository.Save(pizza);
        }
    }
}