using DependencyInjection_Refactoring_Step2;
using DependencyInjection_Refactoring_Step2_Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DependencyInjection_Refactoring_Step2_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AssertPartListCreatorReturnCorrectNumberOfParts()
        {
            // Arrange
            IDatabaseService databaseService = new DatabaseServiceThreeParts();
            PartListCreator p = new PartListCreator(databaseService);

            // Act 
            var parts = p.GetParts().ToArray();

            // Assert
            Assert.IsTrue(parts.Count() == 3);
        }

        [TestMethod]
        public void AssertPartListCreatorReturnCorrectNumberOfPartsWhenPartsAreNotPresents()
        {
            // Arrange
            IDatabaseService databaseService = new DatabaseServiceEmptyParts();
            PartListCreator p = new PartListCreator(databaseService);

            // Act 
            var parts = p.GetParts().ToArray();

            // Assert
            Assert.IsTrue(parts.Count() == 0);
        }
    }
}
