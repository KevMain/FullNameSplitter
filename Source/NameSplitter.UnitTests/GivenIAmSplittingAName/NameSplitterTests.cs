using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NameSplitter.TEst.GivenIAmSplittingAName
{
    [TestClass]
        public class WhenTheNameIsEmpty
        {
            [TestMethod]
            public void ThenFirstnameAndSurnameAreBothEmpty()
            {
                // Arrange
                var nameSplitter = new NameSplitter();

                // Act
                var nameParts = nameSplitter.GetNamePartsFromName("");

                // Assert
                Assert.AreEqual("", nameParts.FirstName);
                Assert.AreEqual("", nameParts.Surname);
            }      
        }
       
    
}
