namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_DonHang : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.KhachHangs");
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        MaDonHang = c.String(nullable: false, maxLength: 128, unicode: false),
                        NgayDatHang = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.MaDonHang);
            
            AddColumn("dbo.KhachHangs", "SoDienThoai", c => c.String(maxLength: 15, unicode: false));
            AlterColumn("dbo.KhachHangs", "MaKhachHang", c => c.String(nullable: false, maxLength: 128, unicode: false));
            AddPrimaryKey("dbo.KhachHangs", "MaKhachHang");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.KhachHangs");
            AlterColumn("dbo.KhachHangs", "MaKhachHang", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.KhachHangs", "SoDienThoai");
            DropTable("dbo.DonHangs");
            AddPrimaryKey("dbo.KhachHangs", "MaKhachHang");
        }
    }
}
