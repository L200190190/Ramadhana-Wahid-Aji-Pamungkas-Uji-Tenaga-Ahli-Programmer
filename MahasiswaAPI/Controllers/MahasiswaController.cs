using MahasiswaAPI.Context;
using MahasiswaAPI.Models;
using MahasiswaAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MahasiswaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private readonly MahasiswaRepository mahasiswaRepository;

        public MahasiswaController(MahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }
        //function Api Get
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(this.mahasiswaRepository.Get());
        }

        [HttpGet("mahasiswa")]
        public ActionResult Get(string id)
        {
            Mahasiswa findMahasiswa = mahasiswaRepository.Get(id);

            if (findMahasiswa == null)
            {
                return NotFound();
            }

            return Ok(findMahasiswa);
        }

        [HttpPost("tambah-mahasiswa")]
        public async Task<ActionResult<Mahasiswa>> PostMahasiswa(Mahasiswa mahasiswa) 
        {
            var tambahMahasiswa = mahasiswaRepository.Insert(mahasiswa);

            if(tambahMahasiswa != 201)
            {
                return BadRequest();
            }

            return Ok(CreatedAtAction(nameof(Get), new { id = mahasiswa.Nobp }, mahasiswa));
        }

        [HttpPut("edit-mahasiswa")]
        public async Task<ActionResult<Mahasiswa>> PutMahassiwa(Mahasiswa mahasiswa)
        {
            var updateMahasiswa = mahasiswaRepository.Update(mahasiswa);

            if (updateMahasiswa != 200)
            {
                return BadRequest();
            }

            return Ok(CreatedAtAction(nameof(Get), new { id = mahasiswa.Nobp }, mahasiswa));
        }

        [HttpDelete("delete-mahasiswa")]
        public async Task<ActionResult<Mahasiswa>> DeleteMahasiswa(string Nobp)
        {
            var deleteMahasiswa = mahasiswaRepository.Delete(Nobp);

            return Ok(CreatedAtAction(nameof(Get), new { id = Nobp }, deleteMahasiswa));
        }
    }
}
