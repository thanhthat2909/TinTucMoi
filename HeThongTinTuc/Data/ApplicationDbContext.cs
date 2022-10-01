using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using HeThongTinTuc.Models;

namespace HeThongTinTuc.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<HeThongTinTuc.Models.chuyenmuc> chuyenmuc { get; set; }
        public DbSet<HeThongTinTuc.Models.bantin> bantin { get; set; }
    }
}
