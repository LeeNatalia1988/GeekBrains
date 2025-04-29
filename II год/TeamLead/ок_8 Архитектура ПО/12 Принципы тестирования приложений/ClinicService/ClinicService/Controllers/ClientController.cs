using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using ClinicService.Services.Impl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace ClinicService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;

        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "ClientCreate")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public ActionResult<int> Create([FromBody] CreateClientRequest createClientRequest)
        {
            int res = _clientRepository.Create(new Client
            {
                Document = createClientRequest.Document,
                SurName = createClientRequest.SurName,
                FirstName = createClientRequest.FirstName,
                Patronymic = createClientRequest.Patronymic,
                BirthDay = createClientRequest.BirthDay,
            });
            return Ok(res);
        }

        [HttpPost("update")]
        [SwaggerOperation(OperationId = "ClientUpdate")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public ActionResult<int> Update([FromBody] UpdateClientRequest updateClientRequest)
        {
            int res = _clientRepository.Update(new Client
            {
                ClientId = updateClientRequest.ClientId,
                Document = updateClientRequest.Document,
                SurName = updateClientRequest.SurName,
                FirstName = updateClientRequest.FirstName,
                Patronymic = updateClientRequest.Patronymic,
                BirthDay = updateClientRequest.BirthDay,
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "ClientDelete")]
        public ActionResult<int> Delete([FromQuery] int clientId)
        {
            int res = _clientRepository.Delete(clientId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "ClientGetAll")]
        public ActionResult<List<Client>> GetAll()
        {
            return Ok(_clientRepository.GetAll());
        }

        [HttpGet("get/{clientId}")]
        [SwaggerOperation(OperationId = "ClientGetById")]
        public ActionResult<Client> GetById([FromRoute] int clientId)
        {
            return Ok(_clientRepository.GetById(clientId));
        }
    }
}
