using System.Threading.Tasks;
using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _db;

        public VillaAPIController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<VillaDTO>>> GetVillas()
        {
            return Ok(await _db.Villas.ToListAsync());
        }

        [HttpGet("{id:int}",Name = "GetVilla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        //[ProducesResponseType(200, Type = typeof(VillaDTO))]
        public async Task<ActionResult<VillaDTO>> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = await _db.Villas.FirstOrDefaultAsync(v => v.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            return Ok(villa);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<VillaDTO>> CreateVilla([FromBody]VillaCreateDTO createDTO)
        {
            //if(!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            if (await _db.Villas.FirstOrDefaultAsync(e => e.Name.ToLower() == createDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("CustomError", "Villa already exists!");
                return BadRequest(ModelState);
            }
            if (createDTO == null)
            {
                return BadRequest(createDTO);
            }
            //if (createDTO.Id > 0)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError);
            //}

            Villa model = new()
            {
                //Id = createDTO.Id,
                Name = createDTO.Name,
                Details = createDTO.Details,
                Sqft = createDTO.Sqft,
                Occupancy = createDTO.Occupancy,
                Rate = createDTO.Rate,
                ImageUrl = createDTO.ImageUrl,
                Amenity = createDTO.Amenity
            };
            await _db.Villas.AddAsync(model);
            await _db.SaveChangesAsync();

            return CreatedAtRoute("GetVilla", new {id = model.Id}, model);
        }

        [HttpDelete("{id}",Name = "DeleteVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> DeleteVilla(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var villa = await _db.Villas.FirstOrDefaultAsync(u => u.Id == id);
            if (villa == null)
            {
                return NotFound();
            }
            _db.Villas.Remove(villa);
            await _db.SaveChangesAsync();
            return NoContent();
        }

        [HttpPut("{id}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateVilla(int id, [FromBody]VillaUpdateDTO updateDTO)
        {
            if (updateDTO == null || id != updateDTO.Id)
            {
                return BadRequest();
            }
            //var villa = VillaStore.villaList.FirstOrDefault(u => u.Id == id);
            //villa.Name = villaDTO.Name;
            //villa.Sqft = villaDTO.Sqft;
            //villa.Occupancy = villaDTO.Occupancy;

            Villa model = new()
            {
                Id = updateDTO.Id,
                Name = updateDTO.Name,
                Details = updateDTO.Details,
                Sqft = updateDTO.Sqft,
                Occupancy = updateDTO.Occupancy,
                Rate = updateDTO.Rate,
                ImageUrl = updateDTO.ImageUrl,
                Amenity = updateDTO.Amenity
            };
            _db.Villas.Update(model);
            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpPatch("{id}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdatePartialVilla(int id,JsonPatchDocument<VillaUpdateDTO> patchUpdateDTO)
        {
            if(patchUpdateDTO == null || id == 0)
            {
                return BadRequest();
            }
            var villa = await _db.Villas.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);

            VillaUpdateDTO villaUpdateDTO = new()
            {
                Id = villa.Id,
                Name = villa.Name,
                Details = villa.Details,
                Sqft = villa.Sqft,
                Occupancy = villa.Occupancy,
                Rate = villa.Rate,
                ImageUrl = villa.ImageUrl,
                Amenity = villa.Amenity
            };

            if (villa == null)
            {
                return BadRequest();
            }

            patchUpdateDTO.ApplyTo(villaUpdateDTO, ModelState);

            Villa model = new()
            {
                Id = villaUpdateDTO.Id,
                Name = villaUpdateDTO.Name,
                Details = villaUpdateDTO.Details,
                Sqft = villaUpdateDTO.Sqft,
                Occupancy = villaUpdateDTO.Occupancy,
                Rate = villaUpdateDTO.Rate,
                ImageUrl = villaUpdateDTO.ImageUrl,
                Amenity = villaUpdateDTO.Amenity
            };
            _db.Villas.Update(model);
            await _db.SaveChangesAsync();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
