using MahasiswaAPI.Models;

namespace MahasiswaAPI.Repository.Interface
{
    public interface IMahasiswaRepository
    {
        IEnumerable<Mahasiswa> Get();
        Mahasiswa Get(String Nobp);
        int Insert(Mahasiswa mahasiswa);
        int Update(Mahasiswa mahasiswa);
        Mahasiswa Delete(String Nobp);
    }
}
