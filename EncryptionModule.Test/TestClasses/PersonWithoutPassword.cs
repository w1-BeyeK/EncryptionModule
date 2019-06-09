using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionModule.Test.TestClasses
{
    public class PersonWithoutPassword : Person
    {
        protected override Configuration GetConfiguration()
        {
            Configuration config = base.GetConfiguration();
            config.PassPhrase = string.Empty;

            return config;
        }
    }
}
