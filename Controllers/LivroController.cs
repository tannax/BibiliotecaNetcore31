using Biblioteca.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Biblioteca.Controllers
{
    public class LivroController : Controller
    {
        public IActionResult Cadastro()
        {
            Autenticacao.CheckLogin(this);
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Livro l)
        {
            LivroService livroService = new LivroService();

            if (l.Id == 0)
            {
                livroService.Inserir(l);
            }
            else
            {
                livroService.Atualizar(l);
            }

            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro, int pagina = 1, int itensPorPagina = 10)
        {
            Autenticacao.CheckLogin(this);
            FiltrosLivros objFiltro = null;
            if (!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosLivros();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }

            LivroService livroService = new LivroService();
            var livros = livroService.ListarTodos(objFiltro);

            // Calcular quantos itens pular para a página atual
            int itensParaPular = (pagina - 1) * itensPorPagina;

            // Selecionar a parte dos livros para a página atual
            var livrosPaginados = livros.Skip(itensParaPular).Take(itensPorPagina).ToList();

            // Calcular o número total de páginas
            int totalPaginas = (livros.Count + itensPorPagina - 1) / itensPorPagina;

            // Passar os dados necessários para a visualização
            ViewBag.PaginaAtual = pagina;
            ViewBag.TotalPaginas = totalPaginas;
            ViewBag.ItensPorPagina = itensPorPagina;

            return View(livrosPaginados);
        }



        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            LivroService ls = new LivroService();
            Livro l = ls.ObterPorId(id);
            return View(l);
        }
    }
}