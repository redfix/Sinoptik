namespace Sinoptik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 4000),
                        DateBirthday = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        IsRheumaticSufferer = c.Boolean(nullable: false),
                        IsHearhSufferer = c.Boolean(nullable: false),
                        IsNeuroticSufferer = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        WeatherId = c.Int(nullable: false),
                        SubjParamsId = c.Int(nullable: false),
                        ObjParamsId = c.Int(nullable: false),
                        SANTestId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.ObjParams", t => t.ObjParamsId, cascadeDelete: true)
                .ForeignKey("dbo.SANParams", t => t.SANTestId, cascadeDelete: true)
                .ForeignKey("dbo.SubjParams", t => t.SubjParamsId, cascadeDelete: true)
                .ForeignKey("dbo.Weather", t => t.WeatherId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.WeatherId)
                .Index(t => t.SubjParamsId)
                .Index(t => t.ObjParamsId)
                .Index(t => t.SANTestId);
            
            CreateTable(
                "dbo.ObjParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeartRate = c.Short(nullable: false),
                        SistolicBloodPressure = c.Short(nullable: false),
                        DiastolicBloodPressure = c.Short(nullable: false),
                        BodyTemp = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SANParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SANFeeling = c.Short(nullable: false),
                        SANPassivActiv = c.Short(nullable: false),
                        SANMood = c.Short(nullable: false),
                        SANFullForceExhausted = c.Short(nullable: false),
                        SANRestedTired = c.Short(nullable: false),
                        SANSlepyHorny = c.Short(nullable: false),
                        SANDesireToWork = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubjParams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hedache = c.Short(nullable: false),
                        RheumaticPain = c.Short(nullable: false),
                        HeartPain = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Weather",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateAndTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Local = c.String(),
                        Temp = c.Short(nullable: false),
                        Pressure = c.Short(nullable: false),
                        Cloudly = c.Short(nullable: false),
                        RainFall = c.Short(nullable: false),
                        Geomagnetic = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Exams", "WeatherId", "dbo.Weather");
            DropForeignKey("dbo.Exams", "SubjParamsId", "dbo.SubjParams");
            DropForeignKey("dbo.Exams", "SANTestId", "dbo.SANParams");
            DropForeignKey("dbo.Exams", "ObjParamsId", "dbo.ObjParams");
            DropForeignKey("dbo.Exams", "ClientId", "dbo.Clients");
            DropIndex("dbo.Exams", new[] { "SANTestId" });
            DropIndex("dbo.Exams", new[] { "ObjParamsId" });
            DropIndex("dbo.Exams", new[] { "SubjParamsId" });
            DropIndex("dbo.Exams", new[] { "WeatherId" });
            DropIndex("dbo.Exams", new[] { "ClientId" });
            DropTable("dbo.Weather");
            DropTable("dbo.SubjParams");
            DropTable("dbo.SANParams");
            DropTable("dbo.ObjParams");
            DropTable("dbo.Exams");
            DropTable("dbo.Clients");
        }
    }
}
