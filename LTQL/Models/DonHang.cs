using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("DonHangs")]
    public class DonHang
    {
        [Key]
        public string MaDonHang { get; set; }
        public  string NgayDatHang { get; set; }
    }
}