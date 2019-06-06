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
            Person person = new Person();
            person.Id = 1;
            person.Name = "Kevin Beye";
            person.Email = "kevin.beye1999@hotmail.com";
            person.Phone = "+31 6 11 06 17 88";

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
        public void DecryptWithCustomPassSuccess()
        {
            // Arrange
            PersonWithCustomPass person = new PersonWithCustomPass();
            person.Id = 1;
            person.Name = "Kevin Beye";
            person.Email = "kevin.beye1999@hotmail.com";
            person.Phone = "+31 6 11 06 17 88";

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
        public void DecryptWithoutPropertiesThrowsException()
        {
            // Arrange
            PersonWithoutProperties person = new PersonWithoutProperties();
            person.Id = 1;
            person.Name = "Kevin Beye";
            person.Email = "kevin.beye1999@hotmail.com";
            person.Phone = "+31 6 11 06 17 88";
            
            // Act / assert
            Assert.Throws<NoPropertiesException>(() => person.Decode());
        }
    }
}
