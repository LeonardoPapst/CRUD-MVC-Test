namespace CRUD_MVC_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoas",
                c => new
                    {
                        PessoaId = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        TelefoneRes = c.String(nullable: false),
                        Celular = c.String(),
                    })
                .PrimaryKey(t => t.PessoaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoas");
        }
    }
}
