using EncryptionModule.Exceptions;
using EncryptionModule.Test.TestClasses;
using System;
using Xunit;

namespace EncryptionModule.Test
{
    public class EncryptionTest
    {
        [Fact]
        public void TestSuccess()
        {
            // Arrange
            Person person = new Person
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act
            person.Encode();

            // Assert
            Assert.NotEqual("Kevin Beye", person.Name);
            Assert.NotNull(person.Name);
            Assert.NotEmpty(person.Name);

            // Make sure only name is encrypted
            Assert.Equal("kevin.beye1999@hotmail.com", person.Email);
        }

        [Fact]
        public void TestCustomConfigSuccess()
        {
            // Arrange
            PersonWithCustomConfig person = new PersonWithCustomConfig
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act
            person.Encode();

            // Assert
            Assert.NotEqual("Kevin Beye", person.Name);
            Assert.NotNull(person.Name);
            Assert.NotEmpty(person.Name);

            // Make sure only name is encrypted
            Assert.Equal("kevin.beye1999@hotmail.com", person.Email);
        }

        [Fact]
        public void PersonWithNonExistingPropertiesFail()
        {
            PersonWithNonExistingProperties person = new PersonWithNonExistingProperties
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act / assert
            Assert.Throws<ArgumentNullException>(() => person.Encode());
        }

        [Fact]
        public void EncryptWithoutPropertiesThrowsException()
        {
            // Arrange
            PersonWithoutProperties person = new PersonWithoutProperties
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act / assert
            Assert.Throws<NoPropertiesException>(() => person.Encode());
        }
    }
}
