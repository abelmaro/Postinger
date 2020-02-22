using Microsoft.AspNetCore.Mvc;
using Postinger.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postinger.Models
{
    public class CommentsViewModel
    { 
        public int Id { get; set; }
        public string Comentario { get; set; }
        public virtual PostViewModel Post { get; set; }
        public int PostID { get; set; }
        public int Usuario { get; set; }
    }
}
