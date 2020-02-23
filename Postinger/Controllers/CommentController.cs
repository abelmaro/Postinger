using Microsoft.AspNetCore.Mvc;
using Postinger.DataAccess;
using Postinger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postinger.Controllers
{
    public class CommentController : Controller
    {
        private readonly PostContext _context;


        public CommentController(PostContext context)
        {
            _context = context;
        }

        public List<CommentsViewModel> GetComentariosByPostId(int id)
        {
            var comentarios = _context.Comment.Where(x => x.PostID == id).ToList(); 
            return comentarios;
        }

        public void AddComment([FromBody] CommentsViewModel vm)
        {
            var comment = new CommentsViewModel();
            comment.Comentario = vm.Comentario;
            comment.PostID = vm.PostID;
            comment.Usuario = 1;

            _context.Comment.Add(comment);
            _context.SaveChanges();
        }

    }
}
