using System;
using System.Collections.Generic;
using System.Text;

namespace EncryptionModule.Test
{
    public class Person : EntityBase
    {
        public Person() : base(new List<string>
        {
            "Name"
        })
        { }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
