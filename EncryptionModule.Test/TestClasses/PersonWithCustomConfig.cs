using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionModule.Test.TestClasses
{
    class PersonWithCustomConfig : Person
    {
        protected override Configuration GetConfiguration()
        {
            return new Configuration("Test123", 128, 128, 500);
        }
    }
}
