namespace Sinoptik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCalmHornyIntoSANtest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SANParams", "SANCalmHorny", c => c.Short());
            AlterColumn("dbo.SANParams", "SANFeeling", c => c.Short());
            AlterColumn("dbo.SANParams", "SANPassivActiv", c => c.Short());
            AlterColumn("dbo.SANParams", "SANMood", c => c.Short());
            AlterColumn("dbo.SANParams", "SANFullForceExhausted", c => c.Short());
            AlterColumn("dbo.SANParams", "SANRestedTired", c => c.Short());
            AlterColumn("dbo.SANParams", "SANSlepyHorny", c => c.Short());
            AlterColumn("dbo.SANParams", "SANDesireToWork", c => c.Short());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SANParams", "SANDesireToWork", c => c.Short(nullable: false));
            AlterColumn("dbo.SANParams", "SANSlepyHorny", c => c.Short(nullable: false));
            AlterColumn("dbo.SANParams", "SANRestedTired", c => c.Short(nullable: false));
            AlterColumn("dbo.SANParams", "SANFullForceExhausted", c => c.Short(nullable: false));
            AlterColumn("dbo.SANParams", "SANMood", c => c.Short(nullable: false));
            AlterColumn("dbo.SANParams", "SANPassivActiv", c => c.Short(nullable: false));
            AlterColumn("dbo.SANParams", "SANFeeling", c => c.Short(nullable: false));
            DropColumn("dbo.SANParams", "SANCalmHorny");
        }
    }
}
