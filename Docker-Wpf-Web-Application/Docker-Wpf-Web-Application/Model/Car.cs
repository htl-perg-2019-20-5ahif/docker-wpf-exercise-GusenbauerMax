using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Docker_Wpf_Web_Application.Model
{
    public class Car
    {
        public int CarId { get; set; }

        [Required]
        [MaxLength(25)]
        public String Brand { get; set; }

        [Required]
        [MaxLength(50)]
        public String Model { get; set; }

        public List<Book> Books { get; set; }
    }
}
