using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class Item
    {
        public int Id { get; set; }
        [StringLength(200, ErrorMessage ="You did a bad thing")]
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Due { get; set; }
    }
}
