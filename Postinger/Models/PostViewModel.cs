using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postinger.Models
{
    public class PostViewModel
    {
        public int Id { get; set; }
        public string PostName { get; set; }
        public string Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
    }
}
