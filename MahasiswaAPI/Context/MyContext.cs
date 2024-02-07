using MahasiswaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MahasiswaAPI.Context
{
    public class MyContext(DbContextOptions<MyContext> options) : DbContext(options)
    {
        public DbSet<Mahasiswa> mahasiswas { get; set; }

    }
}
