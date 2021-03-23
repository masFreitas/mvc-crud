using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_crud.Data;
using System.Collections.Generic;
using mvc_crud.Models.DB;
using System.Linq;

namespace mvc_crud.Controllers
{
    public class PessoaController : Controller
    {
        private readonly ILogger<PessoaController> _logger;
        private readonly appContext _context;

        public PessoaController(ILogger<PessoaController> logger, appContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            IList<Pessoa> pessoas = _context.Pessoas.ToList();
            return View(pessoas);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo([Bind("Id,Nome,Nascimento,Email")]Pessoa novaPessoa)
        {
            _context.Pessoas.Add(novaPessoa);
            _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }
    }
}