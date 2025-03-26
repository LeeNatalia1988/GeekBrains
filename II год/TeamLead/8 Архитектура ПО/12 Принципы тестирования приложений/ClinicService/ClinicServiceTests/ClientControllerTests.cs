using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    public class ClientControllerTests
    {
        private ClientController _clientController;
        private Mock<IClientRepository> _mockClientRepository;

        public ClientControllerTests()
        {
            _mockClientRepository = new Mock<IClientRepository>();
            _clientController = new ClientController(_mockClientRepository.Object);
        }

        [Fact]
        public void GetAllClientTest()
        {
            // [1.1] Подготовка данных для тестирования

            // [1.2] 

            List<Client> list = new List<Client>();

            list.Add(new Client());
            list.Add(new Client());
            list.Add(new Client());

            _mockClientRepository.Setup(repository =>
                repository.GetAll()).Returns(list);

            // [2] Исполнение тестируемого метода

            var operationResult = _clientController.GetAll();

            // [3] Подготовка эталонного результата и проверка результата

            Assert.IsType<OkObjectResult>(operationResult.Result); //проверка что вернул http200

            Assert.IsAssignableFrom<List<Client>>(((OkObjectResult)operationResult.Result).Value);

            _mockClientRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce()); //проверяет вызывался ли метод getAll в репозитории хотя бы раз
        }


        public static readonly object[][] CorrectCreateClientData =
        {
            new object[] { new DateTime(1985, 5, 20), "1234 123456", "Иванов", "Андрей", "Сергеевич" },
            new object[] { new DateTime(1975, 5, 20), "1234 123457", "Петров", "Андрей", "Сергеевич" },
            new object[] { new DateTime(1995, 5, 20), "1234 123458", "Сидоров", "Андрей", "Сергеевич" },
        };

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void CreateClientTest(DateTime birthDay, string document, string surName, string firstName, string patronymic)
        {
            _mockClientRepository.Setup(repository =>
                repository.Create(It.IsAny<Client>())).Returns(1).Verifiable();

            _mockClientRepository.Setup(repository =>
                repository.Create(It.IsNotNull<Client>())).Returns(1).Verifiable();


            var operationResult = _clientController.Create(new CreateClientRequest
            {
                BirthDay = birthDay,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockClientRepository.Verify(repository =>
                repository.Create(It.IsAny<Client>()), Times.AtLeastOnce());

            _mockClientRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        [Theory]
        [MemberData(nameof(CorrectCreateClientData))]
        public void DeleteClientTest(DateTime birthDay, string document, string surName, string firstName, string patronymic)
        {
            _mockClientRepository.Setup(repository =>
                repository.Delete(It.IsAny<int>())).Returns(1).Verifiable();

            _mockClientRepository.Setup(repository =>
                repository.Delete(It.IsNotNull<int>())).Returns(1).Verifiable();


            var operationResult = _clientController.Delete(1);

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockClientRepository.Verify(repository =>
                repository.Delete(It.IsAny<int>()), Times.AtLeastOnce());

            _mockClientRepository.Verify(repository =>
                repository.Delete(It.IsNotNull<int>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectUpdateClientData =
        {
            new object[] { 1, new DateTime(1985, 5, 20), "1234 123456", "Иванов", "Андрей", "Сергеевич" },
            new object[] { 2, new DateTime(1975, 5, 20), "1234 123457", "Петров", "Андрей", "Сергеевич" },
            new object[] { 3, new DateTime(1995, 5, 20), "1234 123458", "Сидоров", "Андрей", "Сергеевич" },
        };


        [Theory]
        [MemberData(nameof(CorrectUpdateClientData))]
        public void UpdateClientTest(int clientId, DateTime birthDay, string document, string surName, string firstName, string patronymic)
        {
            _mockClientRepository.Setup(repository =>
                repository.Update(It.IsAny<Client>())).Returns(1).Verifiable();

            _mockClientRepository.Setup(repository =>
                repository.Update(It.IsNotNull<Client>())).Returns(1).Verifiable();


            var operationResult = _clientController.Update(new UpdateClientRequest
            {
                ClientId = clientId,
                BirthDay = birthDay,
                Document = document,
                SurName = surName,
                FirstName = firstName,
                Patronymic = patronymic
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockClientRepository.Verify(repository =>
                repository.Update(It.IsAny<Client>()), Times.AtLeastOnce());

            _mockClientRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Client>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectGetBuIdClientData =
        {
            new object[] { new Client(), 1},
            new object[] { new Client(), 2},
            new object[] { new Client(), 3}
        };

        [Theory]
        [MemberData(nameof(CorrectGetBuIdClientData))]
        public void GetByIdClientTest(Client client, int clientId)
        {
            _mockClientRepository.Setup(repository =>
                repository.GetById(It.IsAny<int>())).Returns(client).Verifiable();

            _mockClientRepository.Setup(repository =>
                repository.GetById(It.IsNotNull<int>())).Returns(client).Verifiable();


            var operationResult = _clientController.GetById(clientId);

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<Client>(((OkObjectResult)operationResult.Result).Value);

            _mockClientRepository.Verify(repository =>
                repository.GetById(It.IsAny<int>()), Times.AtLeastOnce());

            _mockClientRepository.Verify(repository =>
                repository.GetById(It.IsNotNull<int>()), Times.AtLeastOnce());
        }
    }
}
