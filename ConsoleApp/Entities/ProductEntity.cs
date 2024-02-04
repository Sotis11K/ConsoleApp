using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Entities
{
    internal class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null;
        public decimal Price { get; set; }

        
        public int CategoryId { get; set; }
        public CategoryEntity Category { get; set; } = null;


    }
}
