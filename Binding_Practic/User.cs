using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding_Practic
{
    public class User
    {
        public Guid Id { get; set; }=Guid.NewGuid();
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Gender { get; set;}
        public string? Phone { get; set; }
        public string? ImageUrl { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfBirth { get; set; }

        public override string ToString()
            => $@"{FirstName}-{LastName}-{Gender}";
       
    }
}
