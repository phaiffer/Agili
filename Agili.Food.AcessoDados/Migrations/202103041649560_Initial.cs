namespace Agili.Food.AcessoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cadastro",
                c => new
                    {
                        IdCardapio = c.Int(nullable: false, identity: true),
                        NomeFornecedor = c.String(nullable: false, maxLength: 100),
                        NomePedido = c.String(nullable: false, maxLength: 50),
                        Tipo = c.String(nullable: false),
                        Valor = c.Single(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdCardapio);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cadastro");
        }
    }
}
