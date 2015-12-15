namespace Sinoptik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SubjParams", "Hedache", c => c.Short());
            AlterColumn("dbo.SubjParams", "RheumaticPain", c => c.Short());
            AlterColumn("dbo.SubjParams", "HeartPain", c => c.Short());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubjParams", "HeartPain", c => c.Short(nullable: false));
            AlterColumn("dbo.SubjParams", "RheumaticPain", c => c.Short(nullable: false));
            AlterColumn("dbo.SubjParams", "Hedache", c => c.Short(nullable: false));
        }
    }
}
