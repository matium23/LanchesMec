using Microsoft.EntityFrameworkCore.Migrations;

namespace LanchesMac.Migrations
{
    public partial class PopularCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
               "VALUES('Normal','Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome,Descricao) " +
                "VALUES('Natural','Lanche feito com ingredientes integrais e naturais')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }


        //essa e uma alternativa de criar dados iniciais ao efeturar uma migration
        //fazendo uma migração vazia e colocando instruçoes SQL nos metudos UP e DOWN
        //Para nao dar conflito e preciso popular e migrar a tabela pai primeiro (Categoria)
        //Por causa de seu atributo de navegação 1 -> *

    }
}
