﻿namespace QA.TelerikAcademy.Core.Data.Users
{
    public class User : IUser
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}