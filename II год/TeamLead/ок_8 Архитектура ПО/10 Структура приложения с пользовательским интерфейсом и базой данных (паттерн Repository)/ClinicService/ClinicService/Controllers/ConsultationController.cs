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
    public class ConsultationController : ControllerBase
    {
        private readonly IConsultationRepository _consultationRepository;

        public ConsultationController(IConsultationRepository consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }

        [HttpPost("create")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult Create([FromBody] CreateConsultationRequest createConsultationRequest)
        {
            int res = _consultationRepository.Create(new Consultation
            {
                ClientId = createConsultationRequest.ClientId,
                PetId = createConsultationRequest.PetId,
                ConsultationDate = createConsultationRequest.ConsultationDate,
                Description = createConsultationRequest.Description,
            });
            return Ok(res);
        }

        [HttpPost("update")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public IActionResult Update([FromBody] UpdateConsultationRequest updateConsultationRequest)
        {
            int res = _consultationRepository.Update(new Consultation
            {
                ConsultationId = updateConsultationRequest.ConsultationId,
                ClientId = updateConsultationRequest.ClientId,
                PetId = updateConsultationRequest.PetId,
                ConsultationDate = updateConsultationRequest.ConsultationDate,
                Description = updateConsultationRequest.Description,
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int consultationId)
        {
            int res = _consultationRepository.Delete(consultationId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_consultationRepository.GetAll());
        }

        [HttpGet("get/{petId}")]
        public IActionResult GetById([FromRoute] int consultationId)
        {
            return Ok(_consultationRepository.GetById(consultationId));
        }
    }
}
