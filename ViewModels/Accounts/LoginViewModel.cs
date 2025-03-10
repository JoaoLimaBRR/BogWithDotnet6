﻿using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "E-mail invalido")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
