using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

using PagedList.Core;


namespace TestMyMvc.Model
{
    public class GetFizzBuzz
    {
        [Range(1,1000)]
        [Required]
        public int Position { get; set; }
        public List<String> FizzBuzznum { get; set; }
    }
}
