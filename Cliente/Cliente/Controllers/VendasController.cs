using Cliente.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Cliente.Controllers
{
    [Route("api/vendas")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly List<VendasModel> ListaDeVendas = null;

        public VendasController()
        {
            ListaDeVendas = new List<VendasModel>
            {
                new VendasModel
                {
                    Codigo = 1,
                    Item = new List<ItemDaVendaModel>
                    {
                        new ItemDaVendaModel
                        {
                            Codigo = 10,
                            Descricao = "sabonete",
                            Valor = 10.50M
                        },
                        new ItemDaVendaModel
                        {
                            Codigo = 25,
                            Descricao = "arroz",
                            Valor = 25.03M
                        }
                    }
                },
                new VendasModel
                {
                    Codigo = 2,
                    Item = new List<ItemDaVendaModel>
                    {
                        new ItemDaVendaModel
                        {
                            Codigo = 12,
                            Descricao = "maionese",
                            Valor = 4.50M
                        },
                        new ItemDaVendaModel
                        {
                            Codigo = 22,
                            Descricao = "feijao",
                            Valor = 8.03M
                        }
                    }
                }
            };
        }

        [HttpGet]
        [Route("buscar")]
        public IEnumerable<VendasModel> Buscar(int item)
        {
            return ListaDeVendas.Where(a => a.Codigo == item);
        }

        [HttpPost]
        [Route("salvar")]
        public void Salvar(VendasModel vendas)
        {

        }
    }
}