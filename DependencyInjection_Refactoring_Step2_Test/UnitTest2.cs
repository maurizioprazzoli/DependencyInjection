using DependencyInjection_Refactoring_Step2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection_Refactoring_Step2_Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void AssertPartListCreatorReturnCorrectNumberOfParts()
        {
            // Arrange
            //IDatabaseService databaseService = new DatabaseServiceThreeParts();
            var databaseServiceMock = new Mock<IDatabaseService>();
            databaseServiceMock.Setup(d => d.GetParts())
                               .Returns(() => new string[] { "PART-1", "PART-2", "PART-3", "PART-4" });
            IDatabaseService databaseService = databaseServiceMock.Object;

            PartListCreator p = new PartListCreator(databaseService);

            // Act 
            var parts = p.GetParts().ToArray();

            // Assert
            Assert.IsTrue(parts.Count() == 4);
        }

        [TestMethod]
        public void AssertPartListCreatorReturnCorrectNumberOfPartsWhenPartsAreNotPresents()
        {
            // Arrange
            //IDatabaseService databaseService = new DatabaseServiceEmptyParts();
            var databaseServiceMock = new Mock<IDatabaseService>();
            databaseServiceMock.Setup(d => d.GetParts())
                               .Returns(() => null);
            IDatabaseService databaseService = databaseServiceMock.Object;

        PartListCreator p = new PartListCreator(databaseService);

        // Act 
        var parts = p.GetParts().ToArray();

        // Assert
        Assert.IsTrue(parts.Count() == 0);
        }
}
}
