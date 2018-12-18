using System;
using System.Collections.Generic;
using System.Text;

namespace TestRepository.Model
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
