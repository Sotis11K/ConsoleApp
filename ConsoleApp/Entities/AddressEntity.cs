using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{
    internal class AddressEntity
    {
        [Key]
        public int Id { get; set; }
        public string StreetName { get; set; } = null;
        public string PostalCode { get; set; } = null;
        public string City { get; set; } = null;

    }
}
