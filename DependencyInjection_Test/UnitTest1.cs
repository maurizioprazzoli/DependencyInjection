using DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace DependencyInjection_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AssertPartListCreatorReturnCorrectNumberOfParts()
        {
            // Arrange
            PartListCreator p = new PartListCreator();

            // Act 
            var parts = p.GetParts().ToArray();

            // Assert
            Assert.IsTrue(parts.Count() == 4);
        }

        [TestMethod]
        public void AssertPartListCreatorReturnCorrectNumberOfPartsWhenPartsAreNotPresents()
        {
            // Arrange
            PartListCreator p = new PartListCreator();

            // Act 
            var parts = p.GetParts().ToArray();

            // Assert
            Assert.IsTrue(parts.Count() == 0);
        }
    }
}
