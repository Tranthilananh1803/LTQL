namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_KhachHang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 50),
                        TenKhachHang = c.String(),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.KhachHangs");
        }
    }
}
