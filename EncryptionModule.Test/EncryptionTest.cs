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
            Person person = new Person();
            person.Id = 1;
            person.Name = "Kevin Beye";
            person.Email = "kevin.beye1999@hotmail.com";
            person.Phone = "+31 6 11 06 17 88";

            // Act
            person.Encode();

            // Assert
            Assert.NotEqual("Kevin Beye", person.Name);
            Assert.NotNull(person.Name);
            Assert.NotEmpty(person.Name);

            // Make sure only name is encrypted
            Assert.Equal("kevin.beye1999@hotmail.com", person.Email);
        }
    }
}
