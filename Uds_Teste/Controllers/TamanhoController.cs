using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uds.Domain.Entities;
using Uds.Domain.Repositories;

namespace Uds_Teste.Controllers
{
    public class TamanhoController : Controller, ITamanhoRepository
    {
        private readonly ITamanhoRepository _repository;
        public TamanhoController(ITamanhoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("Get/Tamanho")]
        public IEnumerable<Tamanho> Get()
        {
            return _repository.Get();
        }
        [HttpPost]
        [Route("Post/Tamanho")]
        public Task<Tamanho> Save(Tamanho Tamanho)
        {
            return _repository.Save(Tamanho);
        }
    }
}