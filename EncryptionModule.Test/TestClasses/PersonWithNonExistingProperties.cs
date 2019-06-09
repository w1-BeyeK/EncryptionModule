using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionModule.Test.TestClasses
{
    public class PersonWithNonExistingProperties : Person
    {
        public PersonWithNonExistingProperties()
        {
            protectedValues = new List<string>
            {
                "idonotexist"
            };
        }
    }
}
