using ClinicService.Controllers;
using ClinicService.Models;
using ClinicService.Models.Requests;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicServiceTests
{
    public class ConsultationControllerTests
    {
        private ConsultationController _consultationController;
        private Mock<IConsultationRepository> _mockConsultationRepository;

        public ConsultationControllerTests()
        {
            _mockConsultationRepository = new Mock<IConsultationRepository>();
            _consultationController = new ConsultationController(_mockConsultationRepository.Object);
        }



        [Fact]
        public void GetAllConsultationTest()
        {
            List<Consultation> list = new List<Consultation>();

            list.Add(new Consultation());
            list.Add(new Consultation());
            list.Add(new Consultation());

            _mockConsultationRepository.Setup(repository =>
                repository.GetAll()).Returns(list);

            var operationResult = _consultationController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<List<Consultation>>(((OkObjectResult)operationResult.Result).Value);

            _mockConsultationRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());
        }


        public static readonly object[][] CorrectCreateConsultationData =
        {
            new object[] { 1, 1, new DateTime(2025, 3, 26), "сегодня" },
            new object[] { 1, 2, new DateTime(2025, 3, 27), "завтра" },
            new object[] { 2, 1, new DateTime(2025, 3, 28), "послезавтра" }
        };

        [Theory]
        [MemberData(nameof(CorrectCreateConsultationData))]
        public void CreateConsultationTest(int clientId, int petId, DateTime consultationDate, string description)
        {
            _mockConsultationRepository.Setup(repository =>
                repository.Create(It.IsAny<Consultation>())).Returns(1).Verifiable();

            _mockConsultationRepository.Setup(repository =>
                repository.Create(It.IsNotNull<Consultation>())).Returns(1).Verifiable();


            var operationResult = _consultationController.Create(new CreateConsultationRequest
            {
                ClientId = clientId,
                PetId = petId,
                ConsultationDate = consultationDate,
                Description = description                
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockConsultationRepository.Verify(repository =>
                repository.Create(It.IsAny<Consultation>()), Times.AtLeastOnce());

            _mockConsultationRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Consultation>()), Times.AtLeastOnce());
        }

        [Theory]
        [MemberData(nameof(CorrectCreateConsultationData))]
        public void DeleteConsultationTest(int clientId, int petId, DateTime consultationDate, string description)
        {
            _mockConsultationRepository.Setup(repository =>
                repository.Delete(It.IsAny<int>())).Returns(1).Verifiable();

            _mockConsultationRepository.Setup(repository =>
                repository.Delete(It.IsNotNull<int>())).Returns(1).Verifiable();


            var operationResult = _consultationController.Delete(1);

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockConsultationRepository.Verify(repository =>
                repository.Delete(It.IsAny<int>()), Times.AtLeastOnce());

            _mockConsultationRepository.Verify(repository =>
                repository.Delete(It.IsNotNull<int>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectUpdateConsultationData =
        {
            new object[] { 1, 1, 1, new DateTime(2025, 3, 26), "сегодня" },
            new object[] { 2, 1, 2, new DateTime(2025, 3, 27), "завтра" },
            new object[] { 3, 2, 1, new DateTime(2025, 3, 28), "послезавтра" }
        };


        [Theory]
        [MemberData(nameof(CorrectUpdateConsultationData))]
        public void UpdateConsultationTest(int consultationId, int clientId, int petId, DateTime consultationDate, string description)
        {
            _mockConsultationRepository.Setup(repository =>
                repository.Update(It.IsAny<Consultation>())).Returns(1).Verifiable();

            _mockConsultationRepository.Setup(repository =>
                repository.Update(It.IsNotNull<Consultation>())).Returns(1).Verifiable();


            var operationResult = _consultationController.Update(new UpdateConsultationRequest
            {
                ConsultationId = consultationId,
                ClientId = clientId,
                PetId = petId,
                ConsultationDate = consultationDate,
                Description = description
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockConsultationRepository.Verify(repository =>
                repository.Update(It.IsAny<Consultation>()), Times.AtLeastOnce());

            _mockConsultationRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Consultation>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectGetByIdConsultationData =
        {
            new object[] { new Consultation(), 1},
            new object[] { new Consultation(), 2},
            new object[] { new Consultation(), 3}
        };

        [Theory]
        [MemberData(nameof(CorrectGetByIdConsultationData))]
        public void GetByIdConsultationTest(Consultation consultation, int consultationId)
        {
            _mockConsultationRepository.Setup(repository =>
                repository.GetById(It.IsAny<int>())).Returns(consultation).Verifiable();

            _mockConsultationRepository.Setup(repository =>
                repository.GetById(It.IsNotNull<int>())).Returns(consultation).Verifiable();


            var operationResult = _consultationController.GetById(consultationId);

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<Consultation>(((OkObjectResult)operationResult.Result).Value);

            _mockConsultationRepository.Verify(repository =>
                repository.GetById(It.IsAny<int>()), Times.AtLeastOnce());

            _mockConsultationRepository.Verify(repository =>
                repository.GetById(It.IsNotNull<int>()), Times.AtLeastOnce());
        }
    }
}
