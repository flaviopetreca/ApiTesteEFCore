using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTesteEFCore.Models;
using ApiTesteEFCore.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTesteEFCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TesteController : ControllerBase
    {
        private readonly ITesteRepository _repositorio;
        public TesteController(ITesteRepository repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IEnumerable<Teste> GetAll()
        {
            return _repositorio.GetAll();
        }
    }
}

