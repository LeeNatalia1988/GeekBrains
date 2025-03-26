using ClinicService.Controllers;
using ClinicService.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
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
    public class PetControllerTests
    {
        private PetController _petController;
        private Mock<IPetRepository> _mockPetRepository;

        public PetControllerTests()
        {
            _mockPetRepository = new Mock<IPetRepository>();
            _petController = new PetController(_mockPetRepository.Object);
        }

        

        [Fact]
        public void GetAllPetTest()
        {
            List<Pet> list = new List<Pet>();

            list.Add(new Pet());
            list.Add(new Pet());
            list.Add(new Pet());

            _mockPetRepository.Setup(repository =>
                repository.GetAll()).Returns(list);

            var operationResult = _petController.GetAll();

            Assert.IsType<OkObjectResult>(operationResult.Result); 

            Assert.IsAssignableFrom<List<Pet>>(((OkObjectResult)operationResult.Result).Value);

            _mockPetRepository.Verify(repository =>
                repository.GetAll(), Times.AtLeastOnce());
        }


        public static readonly object[][] CorrectCreatePetData =
        {
            new object[] { 1, "Шарик", new DateTime(2005, 5, 20) },
            new object[] { 2, "Бобик", new DateTime(2006, 6, 21) },
            new object[] { 3, "Тузик", new DateTime(2007, 7, 22) }
        };

        [Theory]
        [MemberData(nameof(CorrectCreatePetData))]
        public void CreatePetTest(int clientId, string name, DateTime birthDay)
        {
            _mockPetRepository.Setup(repository =>
                repository.Create(It.IsAny<Pet>())).Returns(1).Verifiable();

            _mockPetRepository.Setup(repository =>
                repository.Create(It.IsNotNull<Pet>())).Returns(1).Verifiable();


            var operationResult = _petController.Create(new CreatePetRequest
            {
                ClientId = clientId,
                Name = name,
                BirthDay = birthDay
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockPetRepository.Verify(repository =>
                repository.Create(It.IsAny<Pet>()), Times.AtLeastOnce());

            _mockPetRepository.Verify(repository =>
                repository.Create(It.IsNotNull<Pet>()), Times.AtLeastOnce());
        }


        [Theory]
        [MemberData(nameof(CorrectCreatePetData))]
        public void DeletePetTest(int clientId, string name, DateTime birthDay)
        {
            _mockPetRepository.Setup(repository =>
                repository.Delete(It.IsAny<int>())).Returns(1).Verifiable();

            _mockPetRepository.Setup(repository =>
                repository.Delete(It.IsNotNull<int>())).Returns(1).Verifiable();


            var operationResult = _petController.Delete(1);

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockPetRepository.Verify(repository =>
                repository.Delete(It.IsAny<int>()), Times.AtLeastOnce());

            _mockPetRepository.Verify(repository =>
                repository.Delete(It.IsNotNull<int>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectUpdatePetData =
        {
            new object[] { 1, 1, "Тузик", new DateTime(2012, 3, 20) },
            new object[] { 1, 1, "Шарик", new DateTime(2013, 3, 21) },
            new object[] { 1, 1, "Бобик", new DateTime(2014, 3, 22) }
        };


        [Theory]
        [MemberData(nameof(CorrectUpdatePetData))]
        public void UpdatePetTest(int petId, int clientId, string name, DateTime birthDay)
        {
            _mockPetRepository.Setup(repository =>
                repository.Update(It.IsAny<Pet>())).Returns(1).Verifiable();

            _mockPetRepository.Setup(repository =>
                repository.Update(It.IsNotNull<Pet>())).Returns(1).Verifiable();


            var operationResult = _petController.Update(new UpdatePetRequest
            {
                PetId = petId,
                ClientId = clientId,
                Name = name,
                BirthDay = birthDay
            });

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<int>(((OkObjectResult)operationResult.Result).Value);

            _mockPetRepository.Verify(repository =>
                repository.Update(It.IsAny<Pet>()), Times.AtLeastOnce());

            _mockPetRepository.Verify(repository =>
                repository.Update(It.IsNotNull<Pet>()), Times.AtLeastOnce());
        }

        public static readonly object[][] CorrectGetBuIdPetData =
        {
            new object[] { new Pet(), 1},
            new object[] { new Pet(), 2},
            new object[] { new Pet(), 3}
        };

        [Theory]
        [MemberData(nameof(CorrectGetBuIdPetData))]
        public void GetByIdPetTest(Pet pet, int petId)
        {
            _mockPetRepository.Setup(repository =>
                repository.GetById(It.IsAny<int>())).Returns(pet).Verifiable();

            _mockPetRepository.Setup(repository =>
                repository.GetById(It.IsNotNull<int>())).Returns(pet).Verifiable();


            var operationResult = _petController.GetById(petId);

            Assert.IsType<OkObjectResult>(operationResult.Result);

            Assert.IsAssignableFrom<Pet>(((OkObjectResult)operationResult.Result).Value);

            _mockPetRepository.Verify(repository =>
                repository.GetById(It.IsAny<int>()), Times.AtLeastOnce());

            _mockPetRepository.Verify(repository =>
                repository.GetById(It.IsNotNull<int>()), Times.AtLeastOnce());
        }
    }
}
