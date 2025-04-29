using ClinicService.Models.Requests;
using ClinicService.Models;
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerOperation(OperationId = "ConsultationCreate")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public ActionResult<int> Create([FromBody] CreateConsultationRequest createConsultationRequest)
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
        [SwaggerOperation(OperationId = "ConsultationUpdate")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public ActionResult<int> Update([FromBody] UpdateConsultationRequest updateConsultationRequest)
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
        [SwaggerOperation(OperationId = "ConsultationDelete")]
        public ActionResult<int> Delete([FromQuery] int consultationId)
        {
            int res = _consultationRepository.Delete(consultationId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "ConsultationGetAll")]
        public ActionResult<List<Consultation>> GetAll()
        {
            return Ok(_consultationRepository.GetAll());
        }

        [HttpGet("get/{ConsultationId}")]
        [SwaggerOperation(OperationId = "ConsultationGetById")]
        public ActionResult<Consultation> GetById([FromRoute] int consultationId)
        {
            return Ok(_consultationRepository.GetById(consultationId));
        }
    }
}
