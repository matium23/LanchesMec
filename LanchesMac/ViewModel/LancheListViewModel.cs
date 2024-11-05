using LanchesMac.Models;

namespace LanchesMac.ViewModel
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche>Lanches{get;set;} //ira receber os valores que vem da model
        public string CategoriaAtual {get;set;} // recebera a categoria vinda da model
    }
}
