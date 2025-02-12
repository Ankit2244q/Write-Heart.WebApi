using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Write_Heart.Application.Business.Service.UserPosts;
using Write_Heart.Domain.Entities;
using Write_Heart.Services.Services.UserPostService;

namespace Write_Heart.WebApi.Controllers.NewFolder.UserPost
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserPostController : ControllerBase
    {
        private readonly UserPostService _userPostService;
        public UserPostController(UserPostService userPostService) 
        {
            _userPostService = userPostService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserPosts>>> GetAllUserPosts()
        {
            var userPosts = await _userPostService.GetAllAsync();
            return Ok(userPosts);

        }
    }
}
