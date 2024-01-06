using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoanThiTuyen_039.Models{
    [Table("SinhViens")]
    public class SinhVien{
        [Key]
        public string HoTen { get; set; }
        public string MaSinhVien { get; set; }
           [ForeignKey("LopHoc")]
        public String MaLop { get; set; }
        
    
    }
}