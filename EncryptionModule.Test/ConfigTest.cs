using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EncryptionModule.Test
{
    public class ConfigTest
    {
        [Fact]
        public void ConfigTestSuccess()
        {
            // Arrange
            string testPass = "Test123";
            Configuration config;

            // Act 
            config = Configuration.WithPassword(testPass);


            // Assert
            Assert.Equal(testPass, config.PassPhrase);
            Assert.NotNull(config);
        }
    }
}
