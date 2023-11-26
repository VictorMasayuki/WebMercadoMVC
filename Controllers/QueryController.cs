using Microsoft.AspNetCore.Mvc;
using WebMercadoMVC.Models;

namespace WebMercadoMVC.Controllers
{
    public class QueryController : Controller
    {
        private readonly Contexto contexto;

        public QueryController(Contexto context)
        {
            contexto = context;
        }

        public IActionResult Clientes(string filtro)
        {
            List<Cliente> lista = new List<Cliente>();

            lista = contexto.Clientes.OrderBy(n => n.nome).Where(n => n.nome.Contains(filtro)).ToList();

            return View(lista);
        }
        public IActionResult Pesquisa()
        {
            return View();
        }

        public IActionResult Produtos(string filtro)
        {
            List<Produto> lista = new List<Produto>();

            lista = contexto.Produtos.OrderBy(n => n.nome).Where(n => n.nome.Contains(filtro)).ToList();

            return View(lista);
        }
        public IActionResult PesquisaProd()
        {
            return View();
        }
    }
}
