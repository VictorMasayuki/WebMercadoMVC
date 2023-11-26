using WebMercadoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace MercadoMVC.Controllers
{
    public class DadosController : Controller
    {
        private readonly Contexto contexto;

        public DadosController(Contexto context)
        {
            contexto = context;
        }

        public IActionResult Clientes()
        {
            contexto.Database.ExecuteSqlRaw("delete from clientes");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('clientes', RESEED, 0)");
            Random randnum = new Random();

            string[] vNomeMas = { "Almir", "Arthur", "Bruno", "Caio", "Mateus", "Caio Lima", "Mateus Nogueira", "Felipe", "Felipe Ferreira", "Bruno Oliveira" };
            string[] vNomeFem = { "Ana", "Beatriz", "Carla", "Maria", "Sofia", "Ana Maria", "Maria Lima", "Jessica", "Lisa", "Marisa" };
            string[] vEmail = { "email1@gmail.com", "email2@gmail.com", "email3@gmail.com", "email4@gmail.com", "email5@gmail.com" };

            for (int i = 0; i < 20; i++)
            {
                Cliente cliente = new Cliente();

                /*cliente.nome = "Nome " + (i+1).ToString();
                cliente.email = "Email " + (i+1).ToString() + "@gmail.com";*/

                cliente.nome = (i % 2 == 0) ? vNomeMas[i / 2] : vNomeFem[i / 2];
                cliente.email = vEmail[randnum.Next() % 5];
                contexto.Clientes.Add(cliente);
            }
            contexto.SaveChanges();

            return View(contexto.Clientes.OrderBy(o => o.id).ToList());
        }

        public IActionResult Produtos()
        {
            contexto.Database.ExecuteSqlRaw("delete from produtos");
            contexto.Database.ExecuteSqlRaw("DBCC CHECKIDENT('produtos', RESEED, 0)");
            Random randnum = new Random();

            string[] vNomeProduto = { "Arroz", "Feijão", "Carne Bovina", "Carne Suína", "Frango", "Peixe Tilápia", "Alface", "Coca-Cola", "Sprite", "Detergente Veja",
                                      "Detergente Bombril", "Miojo de Copo", "Miojo Instantâneo", "Arroz Doce", "Peixe Salmão", };

            for (int i = 0; i < 20; i++)
            {
                Produto produto = new Produto();

                produto.nome = vNomeProduto[randnum.Next() % 15];
                produto.preco = randnum.Next(1, 200);
                produto.qtde = randnum.Next(1, 200);
                contexto.Produtos.Add(produto);
            }
            contexto.SaveChanges();

            return View(contexto.Produtos.OrderBy(o => o.id).ToList());
        }
    }
}
