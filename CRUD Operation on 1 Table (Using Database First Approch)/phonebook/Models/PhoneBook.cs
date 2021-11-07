using System;
using System.Collections.Generic;

#nullable disable

namespace phonebook.Models
{
    public partial class PhoneBook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Phno { get; set; }
        public string Address { get; set; }
    }
}
