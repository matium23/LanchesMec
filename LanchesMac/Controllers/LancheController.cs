using LanchesMac.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

/*Se por acaso ouvre erro na hora de exibir a view, verificar a versao do entetyFrameWork 
 ou o diretorio das pastas View e Controller
 */

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _repository;
        public LancheController(ILancheRepository repository)
        {
            _repository = repository;
        }

        public IActionResult List()
        {
            var lanches = _repository.Lanches;
            return View(lanches);
        }
    }
}

