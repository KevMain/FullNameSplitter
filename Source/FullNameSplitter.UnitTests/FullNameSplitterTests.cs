using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FullNameSplitter.UnitTests
{
    [TestClass]
    public class GivenIAmSplittingAName
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

        [TestClass]
        public class WhenTheNameHasNoSpaces
        {
            [TestMethod]
            public void ThenFirstnameIsSetAndSurnameIsEmpty()
            {
                // Arrange
                var nameSplitter = new NameSplitter();

                // Act
                var nameParts = nameSplitter.GetNamePartsFromName("Bob");

                // Assert
                Assert.AreEqual("Bob", nameParts.FirstName);
                Assert.AreEqual("", nameParts.Surname);
            }
        }

        [TestClass]
        public class WhenTheNameHasOneSpace
        {
            [TestMethod]
            public void ThenFirstnameIsFirstWordAndSurnameIsSecondWord()
            {
                // Arrange
                var nameSplitter = new NameSplitter();

                // Act
                var nameParts = nameSplitter.GetNamePartsFromName("Bob Smith");

                // Assert
                Assert.AreEqual("Bob", nameParts.FirstName);
                Assert.AreEqual("Smith", nameParts.Surname);
            }
        }

        [TestClass]
        public class WhenTheNameHasMoreThanOneSpace
        {
            [TestMethod]
            public void ThenFirstnameIsAllWordsExceptLasttWordAndSurnameIsLastWord()
            {
                // Arrange
                var nameSplitter = new NameSplitter();

                // Act
                var nameParts = nameSplitter.GetNamePartsFromName("Bob TheMan Smith");

                // Assert
                Assert.AreEqual("Bob TheMan", nameParts.FirstName);
                Assert.AreEqual("Smith", nameParts.Surname);
            }
        }
    }
}