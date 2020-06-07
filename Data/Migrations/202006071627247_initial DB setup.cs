namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialDBsetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        ItemName = c.String(nullable: false),
                        ItemDescription = c.String(nullable: false),
                        ItemPrice = c.String(nullable: false),
                        ItemWeightInPounds = c.Double(nullable: false),
                        ArmorCategory = c.Int(),
                        ArmorClass = c.String(),
                        StealthDisadvantage = c.Boolean(),
                        StrengthRequirement = c.String(),
                        WeaponCategory = c.Int(),
                        Damage = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Background_BackgroundId = c.Int(),
                        Character_CharacterId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Backgrounds", t => t.Background_BackgroundId)
                .ForeignKey("dbo.Characters", t => t.Character_CharacterId)
                .Index(t => t.Background_BackgroundId)
                .Index(t => t.Character_CharacterId);
            
            CreateTable(
                "dbo.Properties",
                c => new
                    {
                        PropertyId = c.Int(nullable: false, identity: true),
                        PropertyName = c.String(nullable: false),
                        PropertyDescription = c.String(nullable: false),
                        Item_ItemId = c.Int(),
                    })
                .PrimaryKey(t => t.PropertyId)
                .ForeignKey("dbo.Items", t => t.Item_ItemId)
                .Index(t => t.Item_ItemId);
            
            CreateTable(
                "dbo.Backgrounds",
                c => new
                    {
                        BackgroundId = c.Int(nullable: false, identity: true),
                        BackgroundName = c.String(nullable: false),
                        BackgroundDescription = c.String(nullable: false),
                        FeatureId = c.Int(nullable: false),
                        AlternateFeatureId = c.Int(),
                    })
                .PrimaryKey(t => t.BackgroundId)
                .ForeignKey("dbo.Features", t => t.AlternateFeatureId)
                .ForeignKey("dbo.Features", t => t.FeatureId, cascadeDelete: true)
                .Index(t => t.FeatureId)
                .Index(t => t.AlternateFeatureId);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureId = c.Int(nullable: false, identity: true),
                        FeatureName = c.String(nullable: false),
                        FeatureDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FeatureId);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        ClassId = c.Int(nullable: false, identity: true),
                        ClassName = c.String(nullable: false),
                        ClassDescription = c.String(nullable: false),
                        HitDie = c.String(nullable: false),
                        Feature_FeatureId = c.Int(),
                    })
                .PrimaryKey(t => t.ClassId)
                .ForeignKey("dbo.Features", t => t.Feature_FeatureId)
                .Index(t => t.Feature_FeatureId);
            
            CreateTable(
                "dbo.Characters",
                c => new
                    {
                        CharacterId = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        CharacterName = c.String(nullable: false),
                        CharacterRaceId = c.Int(nullable: false),
                        CharacterClassId = c.Int(nullable: false),
                        CharacterBackgroundId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CharacterId)
                .ForeignKey("dbo.Backgrounds", t => t.CharacterBackgroundId, cascadeDelete: true)
                .ForeignKey("dbo.Classes", t => t.CharacterClassId, cascadeDelete: true)
                .ForeignKey("dbo.Races", t => t.CharacterRaceId, cascadeDelete: true)
                .Index(t => t.CharacterRaceId)
                .Index(t => t.CharacterClassId)
                .Index(t => t.CharacterBackgroundId);
            
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        RaceId = c.Int(nullable: false, identity: true),
                        RaceName = c.String(nullable: false),
                        RaceDescription = c.String(nullable: false),
                        AbilityScoreIncrease = c.String(nullable: false),
                        HasDarkvision = c.Boolean(nullable: false),
                        RaceSpeed = c.String(nullable: false),
                        RaceSize = c.String(nullable: false),
                        Trait_TraitId = c.Int(),
                    })
                .PrimaryKey(t => t.RaceId)
                .ForeignKey("dbo.Traits", t => t.Trait_TraitId)
                .Index(t => t.Trait_TraitId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Traits",
                c => new
                    {
                        TraitId = c.Int(nullable: false, identity: true),
                        TraitName = c.String(nullable: false),
                        TraitDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TraitId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Races", "Trait_TraitId", "dbo.Traits");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Items", "Character_CharacterId", "dbo.Characters");
            DropForeignKey("dbo.Characters", "CharacterRaceId", "dbo.Races");
            DropForeignKey("dbo.Characters", "CharacterClassId", "dbo.Classes");
            DropForeignKey("dbo.Characters", "CharacterBackgroundId", "dbo.Backgrounds");
            DropForeignKey("dbo.Backgrounds", "FeatureId", "dbo.Features");
            DropForeignKey("dbo.Items", "Background_BackgroundId", "dbo.Backgrounds");
            DropForeignKey("dbo.Properties", "Item_ItemId", "dbo.Items");
            DropForeignKey("dbo.Backgrounds", "AlternateFeatureId", "dbo.Features");
            DropForeignKey("dbo.Classes", "Feature_FeatureId", "dbo.Features");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Races", new[] { "Trait_TraitId" });
            DropIndex("dbo.Characters", new[] { "CharacterBackgroundId" });
            DropIndex("dbo.Characters", new[] { "CharacterClassId" });
            DropIndex("dbo.Characters", new[] { "CharacterRaceId" });
            DropIndex("dbo.Classes", new[] { "Feature_FeatureId" });
            DropIndex("dbo.Backgrounds", new[] { "AlternateFeatureId" });
            DropIndex("dbo.Backgrounds", new[] { "FeatureId" });
            DropIndex("dbo.Properties", new[] { "Item_ItemId" });
            DropIndex("dbo.Items", new[] { "Character_CharacterId" });
            DropIndex("dbo.Items", new[] { "Background_BackgroundId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Traits");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Races");
            DropTable("dbo.Characters");
            DropTable("dbo.Classes");
            DropTable("dbo.Features");
            DropTable("dbo.Backgrounds");
            DropTable("dbo.Properties");
            DropTable("dbo.Items");
        }
    }
}
