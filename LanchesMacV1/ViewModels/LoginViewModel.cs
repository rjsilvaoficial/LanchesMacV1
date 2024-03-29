﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Digite um usuário válido")]
        [Display(Name = "Usuário")]
        [StringLength(100, ErrorMessage = "O usuário possui no máximo 100 caracteres!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Digite uma senha válida")]
        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}

