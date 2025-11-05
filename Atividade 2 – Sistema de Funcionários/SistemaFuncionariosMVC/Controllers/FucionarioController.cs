using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SistemaFuncionariosMVC.Data;
using SistemaFuncionariosMVC.Models;

namespace SistemaFuncionariosMVC
{
    public class FucionarioController : Controller
    {
        private readonly AppDbContext _context;

        public FucionarioController(AppDbContext contextConstrutor)
        {
            _context = contextConstrutor;
        }

        //todo Listar
        //* async / await -> execulta a funcao de listar dentro do banco, porem permite que o sistema continue rodando enquanto isso acontece
        public async Task<IActionResult> index()
        {
            //* ToList - lista as informacoes dentro da tabela funcionario.
            var lista = await _context.TabelaFuncionario.ToListAsync();

            //* Retorna a view com a lista de funcionarios no index.
            return View(lista);
        }

        //todo Formulario de criacao
        [HttpGet] //* GEt - Listar (e como se fosse um select no banco) - retorna a lista de formulario vazio
        public IActionResult Criar() => View();

        //* Cadastrar as informacoes do formulario no banco de dados
        [HttpPost]
        public async Task<ActionResult> Criar(string nomeConstrutor, double salarioConstrutor, string CargoConstrutor)
        {
            Funcionario? novoFuncionario = null;

            if (CargoConstrutor == "Gerente")
            {
                novoFuncionario = new Gerente(nomeConstrutor, salarioConstrutor);
            }

            else if (CargoConstrutor == "Vendedor")
            {
                novoFuncionario = new Vendedor(nomeConstrutor, salarioConstrutor);
            }

            else
            {
                return BadRequest("Cargo invalido.");
            }

            _context.TabelaFuncionario.Add(novoFuncionario);
            await _context.SaveChangesAsync();

            return RedirectToAction("index");
        }

        //* Excluir
        public async Task<IActionResult> Delete(int id)
        {
            //* variavel que vai armazenar o registro de funcionario encontrado pelo id.
            //* Find(1) -> busca o registro pelo id 
            var funcionario = await _context.TabelaFuncionario.FindAsync(id);

            if (funcionario == null) return NotFound();

            //* Remove o registro do banco
            _context.TabelaFuncionario.Remove(funcionario);
            
            //! salva as alteracoes
            await _context.SaveChangesAsync();
            
            //! retorna para a action index que mostra a lista organizada de funcionarios
            return RedirectToAction("index");
        }
    }
}