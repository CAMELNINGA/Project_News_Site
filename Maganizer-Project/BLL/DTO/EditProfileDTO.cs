﻿using Maganizer_Project.BLL.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Maganizer_Project.BLL.DTO
{
    public class EditProfileDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSiteUrl { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string About { get; set; }
        public byte[] Avatar { get; set; }
    }
}
