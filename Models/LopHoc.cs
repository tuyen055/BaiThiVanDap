using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoanThiTuyen_039.Models{
    [Table("LopHocs")]
    public class LopHoc{
        [Key]
        public string  MaLop { get; set; }
        public string TenLop { get; set; }
        public string DiaChi { get; set; }
          public ICollection<SinhVien>? SinhVien { get; set; }

    }
}