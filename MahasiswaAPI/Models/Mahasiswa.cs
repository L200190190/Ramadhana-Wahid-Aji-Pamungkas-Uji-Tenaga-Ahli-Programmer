using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MahasiswaAPI.Models
{
    [Table("Tb_M_Mahasiswa")]
    public class Mahasiswa
    {
        [Key]
        public String Nobp { get; set; }
        public String Nama { get; set; }
        public String Alamat { get; set; }
        public String Nohp { get; set; }
        public JenisKelamin JenisKelamin { get; set; }

    }
    public enum JenisKelamin
    {
        Pria, 
        Wan
    }
}
