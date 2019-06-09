using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionModule.Test.TestClasses
{
    class PersonWithCustomPass : EntityBase
    {
        public PersonWithCustomPass() : base()
        {
            protectedValues = new List<string>
            {
                "Name"
            };
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
