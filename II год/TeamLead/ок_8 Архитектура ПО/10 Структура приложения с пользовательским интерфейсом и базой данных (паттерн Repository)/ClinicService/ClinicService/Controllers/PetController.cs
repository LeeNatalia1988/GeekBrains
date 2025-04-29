using ClinicService.Models.Requests;
using ClinicService.Models;
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost("create")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult Create([FromBody] CreatePetRequest createPetRequest)
        {
            int res = _petRepository.Create(new Pet
            {
                ClientId = createPetRequest.ClientId,
                Name = createPetRequest.Name,
                BirthDay = createPetRequest.BirthDay,
            });
            return Ok(res);
        }

        [HttpPost("update")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult Update([FromBody] UpdatePetRequest updatePetRequest)
        {
            int res = _petRepository.Update(new Pet
            {
                PetId = updatePetRequest.PetId,
                ClientId = updatePetRequest.ClientId,
                Name = updatePetRequest.Name,
                BirthDay = updatePetRequest.BirthDay,
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int petId)
        {
            int res = _petRepository.Delete(petId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_petRepository.GetAll());
        }

        [HttpGet("get/{petId}")]
        public IActionResult GetById([FromRoute] int petId)
        {
            return Ok(_petRepository.GetById(petId));
        }
    }
}
