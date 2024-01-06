using DoanThiTuyen_039.Models;
using Microsoft.EntityFrameworkCore;

namespace DoanThiTuyen_039.Data{
    public class ApplicationDbcontext : DbContext{
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options){}
        public DbSet<LopHoc> LopHoc {get;set;}
       
        

        

    }
}