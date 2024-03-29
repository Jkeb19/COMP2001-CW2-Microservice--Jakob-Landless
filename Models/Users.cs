﻿using System.ComponentModel.DataAnnotations;

namespace _2001_microservice.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public UserProfiles UserProfiles { get; set; }
        public UserPreferences UserPreferences { get; set; }

    }
}
