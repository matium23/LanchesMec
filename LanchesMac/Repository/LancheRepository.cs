using LanchesMac.Contexto;
using LanchesMac.Models;
using LanchesMac.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace LanchesMac.Repository
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        /*Nao foi preciso invocar o metod ToList() pois a propriedade Lanches ja retorna uma lista naturalmente*/
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(x => x.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => 
            _context.Lanches.Include(x => x.Categoria).Where(x => x.IsLanchePreferido);



        public Lanche GetLancheById(int LanhceId) => _context.Lanches.Include(x => x.Categoria).FirstOrDefault( x => x.LancheId == LanhceId); 
        
    }
}
