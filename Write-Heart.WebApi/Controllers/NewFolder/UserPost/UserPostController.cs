using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Write_Heart.WebApi.Controllers.NewFolder.UserPost
{
    [Route("api/[controller]")]
    [ApiController]

    //private readonly IUserContentService _contentService;

    //public UserContentController(IUserContentService contentService)
    //{
    //    _contentService = contentService;
    //}
    public class UserPostController : ControllerBase
    {

        //public Task<UserPost>

        public UserPostController() { } 

        public ActionResult CreateUserPost()
        {
            return Ok("Created post");
        }
    }
}
