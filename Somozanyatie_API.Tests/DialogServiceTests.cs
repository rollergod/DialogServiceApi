using Microsoft.AspNetCore.Mvc;
using Moq;
using Samozanyatie_API.Application.Interfaces;
using Samozanyatie_API.Controllers;
using Samozanyatie_API.DAL.Interfaces;
using Samozanyatie_API.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Somozanyatie_API.Tests
{
    public class DialogServiceTests
    {
        private readonly Mock<IRGDRepository> repositoryMock = new Mock<IRGDRepository>();
        private readonly Mock<IGetDialog> dialogServiceMock = new Mock<IGetDialog>();
        private Guid IDClient1 = new Guid("4b6a6b9a-2303-402a-9970-6e71f4a47151");
        private Guid IDClient2 = new Guid("c72e5cb5-d6b4-4c0c-9992-d7ae1c53a820");
        private Guid IDClient3 = new Guid("7de3299b-2796-4982-a85b-2d6d1326396e");
        private Guid IDClient4 = new Guid("5abd15c0-e425-40e4-8a07-d2ec9d7c3855");

        [Fact]
        public void GetMethod_ReturnBadRequestWhenIdsAreNull()
        { 
            //Arrange
            repositoryMock.Setup(mock => mock.Init()).Returns(InitialData());
            dialogServiceMock.Setup(mock => mock.GetDialogId(null));
            var controller = new DialogController(dialogServiceMock.Object);

            //Act
            var result = controller.Get(null);

            //Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void GetMethod_ReturnNotFoundWhenIdsAreBad()
        {
            //Arrange
            var ids = new Guid[] { IDClient4 };
            repositoryMock.Setup(mock => mock.Init()).Returns(InitialData());
            dialogServiceMock.Setup(mock => 
                mock.GetDialogId(new Guid[] { IDClient4 }))
                .Returns("");
            var controller = new DialogController(dialogServiceMock.Object);

            //Act
            var result = controller.Get(ids);

            //Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public void GetMethod_ReturnStatusCode200WithDialogId()
        {
            //Arrange
            var ids = new Guid[] { IDClient1, IDClient2 };
            repositoryMock.Setup(mock => mock.Init()).Returns(InitialData());
            dialogServiceMock.Setup(mock => 
                mock.GetDialogId(ids))
                .Returns("19f6f751-7f8d-41fa-8261-709028650592");

            //Act
            var controller = new DialogController(dialogServiceMock.Object);
            var result = controller.Get(ids);

            //Assert
            Assert.IsType<OkObjectResult>(result);
            var id = result as OkObjectResult;
            Assert.Equal("19f6f751-7f8d-41fa-8261-709028650592", id.Value);
        }

        [Fact]
        public void GetMethod_ReturnStatusCode200WithTwoDialogsId()
        {
            //Arrange
            var ids = new Guid[] { IDClient1, IDClient2, IDClient3 };
            var resultValue = new string[] 
            { 
                "fcd6b112-1834-4420-bee6-70c9776f6378", 
                "123beb2f-c315-41a2-b2e5-f0324de55a9f" 
            };
            repositoryMock.Setup(mock => mock.Init()).Returns(InitialData());
            dialogServiceMock.Setup(mock =>
                mock.GetDialogId(ids))
                .Returns("fcd6b112-1834-4420-bee6-70c9776f6378\n123beb2f-c315-41a2-b2e5-f0324de55a9f");

            //Act
            var controller = new DialogController(dialogServiceMock.Object);
            var result = controller.Get(ids) as OkObjectResult;

            //Assert
            string value = (string)result.Value;
            var idArray = value.Split("\n");
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(idArray.Select(id => id),resultValue.Select(id => id));
        }



        public List<RGDialogsClients> InitialData()
        {
            List<RGDialogsClients> L1 = new List<RGDialogsClients>();

            Guid IDRGDialog1 = new Guid("fcd6b112-1834-4420-bee6-70c9776f6378");

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog1,
                IDClient = IDClient1
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog1,
                IDClient = IDClient2
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog1,
                IDClient = IDClient3
            });

            Guid IDRGDialog2 = new Guid("19f6f751-7f8d-41fa-8261-709028650592");

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog2,
                IDClient = IDClient1
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog2,
                IDClient = IDClient2
            });

            Guid IDRGDialog4 = new Guid("123beb2f-c315-41a2-b2e5-f0324de55a9f");

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog4,
                IDClient = IDClient1
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog4,
                IDClient = IDClient2
            });

            L1.Add(new RGDialogsClients
            {
                IDUnique = Guid.NewGuid(),
                IDRGDialog = IDRGDialog4,
                IDClient = IDClient3
            });

            return L1;

        }
    }
}

