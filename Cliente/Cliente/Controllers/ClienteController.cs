using Cliente.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Cliente.Controllers
{
    //[Authorize]
    [Route("api/cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly List<ClienteModel> listaDeClientes;

        public ClienteController()
        {
            listaDeClientes = new List<ClienteModel>
            {
                new ClienteModel { Codigo = 1, Nome = "renato" },
                new ClienteModel { Codigo = 2, Nome = "marcio" },
                new ClienteModel { Codigo = 3, Nome = "silva" },
            };
        }

        [HttpGet]
        [Route("buscar")]
        public IEnumerable<ClienteModel> Buscar()
        {
            return listaDeClientes;
        }

        [HttpGet]
        [Route("buscarItem")]
        public IEnumerable<ClienteModel> Buscar(int codigo)
        {
            return listaDeClientes.Where(a => a.Codigo == codigo);
        }

        [HttpPost]
        [Route("inserir")]
        public void Salvar(ClienteModel cliente)
        {
            listaDeClientes.Add(cliente);
        }

        [HttpPut]
        [Route("atualizar")]
        public void Atualizar(ClienteModel cliente)
        {
            var pesquisa = listaDeClientes.Where(a => a.Codigo == cliente.Codigo).FirstOrDefault();
            listaDeClientes.Remove(pesquisa);
            listaDeClientes.Add(cliente);
        }
    }
}