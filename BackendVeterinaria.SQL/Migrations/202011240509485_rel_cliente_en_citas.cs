namespace BackendVeterinaria.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rel_cliente_en_citas : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Cita", "IdCliente");
            AddForeignKey("dbo.Cita", "IdCliente", "dbo.Cliente", "Codigo", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cita", "IdCliente", "dbo.Cliente");
            DropIndex("dbo.Cita", new[] { "IdCliente" });
        }
    }
}
