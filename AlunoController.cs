using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIboletim.Domains;
using APIboletim.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIboletim.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {

        //Acesso à classe de banco 

        AlunoRepositorio repo = new AlunoRepositorio();


        // GET: api/Aluno
        [HttpGet]
        public List<Aluno> Get()
        {
            return repo.LerTodos();
        }


        // GET: api/Aluno/5
        [HttpGet("{id}")]
        public Aluno Get(int id)
        {
            return repo.BuscarPorId(id);
        }

        // POST: api/Aluno
        [HttpPost]
        public Aluno Post([FromBody] Aluno a)
        {
            return repo.Cadastrar(a);
        }

        // PUT: api/Aluno/5
        [HttpPut("{id}")]
        public Aluno Put(int id, [FromBody] Aluno a)
        {
            return repo.Alterar(a);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public Aluno Delete(Aluno a)
        {
            return repo.Excluir(a);
        }
    }
}
