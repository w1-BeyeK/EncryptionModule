using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionModule.Test.TestClasses
{
    class PersonWithoutProperties : EntityBase
    {
        public PersonWithoutProperties()
        { }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
