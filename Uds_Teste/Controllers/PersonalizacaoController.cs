using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uds.Domain.Entities;
using Uds.Domain.Repositories;

namespace Uds_Teste.Controllers
{
    public class PersonalizacaoController : Controller, IPersonalizacaoRepository
    {
        private readonly IPersonalizacaoRepository _repository;
        public PersonalizacaoController(IPersonalizacaoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("Get/Personalizacao")]
        public IEnumerable<Personalizacao> Get()
        {
            return _repository.Get();
        }
        [HttpPost]
        [Route("Post/Personalizacao")]
        public Task<Personalizacao> Save(Personalizacao Personalizacao)
        {
            return _repository.Save(Personalizacao);
        }
    }
}