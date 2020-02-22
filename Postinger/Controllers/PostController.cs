using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Postinger.DataAccess;
using Postinger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postinger.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //[Authorize]
    public class PostController : Controller
    {
        private readonly PostContext _context;
        private readonly ILogger<PostController> _logger;

        public PostController(PostContext context, ILogger<PostController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Post()
        {
            var postDb = _context.Post.ToList();
            return View(postDb);
        }

        //[HttpPost]
        public void AddNewPost([FromBody] PostViewModel postData)
        {
            if (postData != null)
            {
                _context.Add(postData);
                _context.SaveChanges();
            }
        }

        //[HttpGet]
        //[AllowAnonymous]
        public List<PostViewModel> GetAll()
        {
            var post = _context.Post.ToList();

            return post;
        } 

        public List<CommentsViewModel> GetComentariosByPostId(int id)
        {
            var comentarios = _context.Comment.Where(x => x.PostID == id).ToList();
            return comentarios;
        }
    }
}
