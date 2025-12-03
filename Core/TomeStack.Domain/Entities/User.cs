using Microsoft.AspNetCore.Identity;
using TomeStack.Domain.Values;

namespace TomeStack.Domain.Entities
{
    public class User : IdentityUser
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public string ProfileImageUrl { get; set; } = StringValues.ServerPhotoPath + StringValues.DefaultProfileImage;
        public bool UserIsActive { get; set; } = true;

    }
}
