﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMvcProject.Domain.Dtos
{
    public class LoginDto
    {
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
