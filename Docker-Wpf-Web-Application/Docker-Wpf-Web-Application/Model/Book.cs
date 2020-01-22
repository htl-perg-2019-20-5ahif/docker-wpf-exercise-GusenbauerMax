using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Docker_Wpf_Web_Application.Model
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int CarId { get; set; }

        public Car Car { get; set; }
    }
}
