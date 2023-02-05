using AspNetCoreMvcIdentity.Data;
using AspNetCoreMvcIdentity.Models;
using AspNetCoreMvcIdentity.Models.ApplicationUserViewModels;
using AspNetCoreMvcIdentity.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvcIdentity.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUser _user;
        private readonly IUpload _upload;

        public ProfileController(UserManager<ApplicationUser> userManager, IApplicationUser user, IUpload upload)
        {
            _userManager = userManager;
            _user = user;
           // _upload = upload;
        }



        public IActionResult Details(long id)
        {
            var user = _user.GetById(id);
            var userRoles = _userManager.GetRolesAsync(user).Result;
            var model = new ProfileModel()
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserRating = user.Rating.ToString(),
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
                MemberSince = user.MemberSince,
                IsAdmin = userRoles.Contains("Admin")
            };
            return View(model);
        }
        //[HttpPost]
        //public async Task<IActionResult> UploadProfileImage(IFormFile file)
        //{
        //    var userId = _userManager.GetUserId(User);
        //}


        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var profiles = _user.GetAll().Select(u => new ProfileModel
            {
                UserId = u.Id,
                Email = u.Email,
                UserName = u.UserName,
                ProfileImageUrl = u.ProfileImageUrl,
                UserRating = u.Rating.ToString(),
                MemberSince = u.MemberSince

            });

            var model = new ProfileListModel
            {
                Profiles = profiles
            };
            return View(model);

        }
        [HttpPost]
        public async Task<IActionResult> UploadProfileImage(IFormFile file)
        {
            var userId = _userManager.GetUserId(User);

            //Connect to Azure Storage Container
            //Get Blob Container

            //Parse the Content Disposition response header
            //Grab the filename

            //Get a reference to a Block Blob
            //On that block blob, upload our file

            //Set the user's profile image to the received URI

            //Redirect to user's profile page
            return null;
        }
    }
}