using MahasiswaAPI.Context;
using MahasiswaAPI.Models;
using MahasiswaAPI.Repository.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace MahasiswaAPI.Repository
{
    
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly MyContext myContext;
        public MahasiswaRepository(MyContext myContext) 
        {
            this.myContext = myContext;
        }
        public Mahasiswa Delete(string Nobp)
        {
            var findMahasiswa = myContext.mahasiswas.Find(Nobp);
            myContext.mahasiswas.Remove(findMahasiswa);
            myContext.SaveChanges();

            return findMahasiswa;

        }


        public IEnumerable<Mahasiswa> Get()
        {
            return myContext.mahasiswas.ToList();
        }

        public Mahasiswa Get(string Nobp)
        {
            var findMahasiswa = myContext.mahasiswas.Find(Nobp);

            return findMahasiswa;
        }

        public int Insert(Mahasiswa mahasiswa)
        {
            myContext.mahasiswas.Add(mahasiswa);
            myContext.SaveChanges();

            return 201;
        }

        public int Update(Mahasiswa mahasiswa)
        {
            var findMahasiswa = myContext.mahasiswas.Find(mahasiswa.Nobp);
            
            if(findMahasiswa == null)
            {
                return 400;
            }

            if(mahasiswa.Nama.Length > 0)
            {
                findMahasiswa.Nama = mahasiswa.Nama;
            }

            if(mahasiswa.Alamat.Length > 0)
            {
                findMahasiswa.Alamat = mahasiswa.Alamat;
            }

            if(mahasiswa.Nohp.Length > 0)
            {
                findMahasiswa.Nohp = mahasiswa.Nohp;
            }

            if(mahasiswa.JenisKelamin != null)
            {
                findMahasiswa.JenisKelamin = mahasiswa.JenisKelamin;
            }

            myContext.SaveChanges();

            return 200;
        }
    }
}
