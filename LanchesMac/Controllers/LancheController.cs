using LanchesMac.Repository.Interface;
using LanchesMac.ViewModel;
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
        
            var lancheListViewModel = new LancheListViewModel();

            // O lanche List view model recebera os valores vindo da model que serao exibidos na view
            lancheListViewModel.Lanches = _repository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";


            return View(lancheListViewModel);
        }
    }
}

