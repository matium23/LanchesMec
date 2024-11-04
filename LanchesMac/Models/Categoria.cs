using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/* O Data Anotation Sao propriedades que determinam especificamente as funçoes dos atributos 
    ao serem mapeados para a Tabela
 */
namespace LanchesMac.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "E necessario digitar um nome")]
        [StringLength(80, ErrorMessage = "Maximo de 80 caracteres")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }


        [Required(ErrorMessage = "Informe o nome da categoria")]
        [StringLength(200, ErrorMessage = "Tamanho maximo ate 200 caracteres")]
        [Display(Name = "Descrião")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }


        /*
        A Categoria Lanches e uma categora de 1---* ou seja, uma categoria tem muitos lanches
        e ela ira servir para acessar a tabela Lanche de dentro da Tabela Categoria
        e uma Propriedade de navegação

         */
    }
}
