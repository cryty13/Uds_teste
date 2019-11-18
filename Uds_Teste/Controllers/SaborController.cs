using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uds.Domain.Entities;
using Uds.Domain.Repositories;

namespace Uds_Teste.Controllers
{
    public class SaborController : Controller, ISaborRepository
    {
        private readonly ISaborRepository _repository;
        //private readonly CustomerHandler _handler;
        public SaborController(ISaborRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("Get/Sabor")]
        public IEnumerable<Sabor> Get()
        {
            return _repository.Get();
        }
        [HttpPost]
        [Route("Post/Sabor")]
        public Task<Sabor> Save(Sabor Sabor)
        {
            return _repository.Save(Sabor);
        }
    }
}