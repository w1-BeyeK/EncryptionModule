using EncryptionModule.Exceptions;
using EncryptionModule.Test.TestClasses;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EncryptionModule.Test
{
    public class DecryptTest
    {
        [Fact]
        public void DecryptSuccess()
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
            person.Decode();

            // Assert
            Assert.Equal("Kevin Beye", person.Name);
            Assert.NotNull(person.Name);
            Assert.NotEmpty(person.Name);

            // Make sure only name is encrypted
            Assert.Equal("kevin.beye1999@hotmail.com", person.Email);
        }

        [Fact]
        public void DecryptWithCustomConfigSuccess()
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
            person.Decode();

            // Assert
            Assert.Equal("Kevin Beye", person.Name);
            Assert.NotNull(person.Name);
            Assert.NotEmpty(person.Name);

            // Make sure only name is encrypted
            Assert.Equal("kevin.beye1999@hotmail.com", person.Email);
        }

        [Fact]
        public void DecryptWithoutPasswordFail()
        {
            // Arrange
            PersonWithoutPassword person = new PersonWithoutPassword
            {
                Id = 1,
                Name = "Kevin Beye",
                Email = "kevin.beye1999@hotmail.com",
                Phone = "+31 6 11 06 17 88"
            };

            // Act / Assert
            Assert.Throws<ArgumentException>(() => person.Encode());
            Assert.Throws<ArgumentException>(() => person.Decode());
        }

        [Fact]
        public void DecryptWithoutPropertiesThrowsException()
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
            Assert.Throws<NoPropertiesException>(() => person.Decode());
        }
    }
}
