﻿using MovieBooking.API.Models;

namespace MovieBooking.API.Interfaces.IBusiness
{
    public interface IIdentityBusiness
    {
        public void CreatePasswordHashSalt(string password, out byte[] passwordHash, out byte[] passwordSalt);
        public bool AuthorizeUser(string password, byte[] passwordHash, byte[] passwordSalt);
        public string CreateToken(User user);
    }
}
