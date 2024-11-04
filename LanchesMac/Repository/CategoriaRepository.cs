using LanchesMac.Contexto;
using LanchesMac.Models;
using LanchesMac.Repository.Interface;

namespace LanchesMac.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext repository)
        {
            _context = repository;
        }


        /*
         o metodo ToList e dispensado pois a propriedade _contex.Categoria ja retorna uma lista
         */
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
