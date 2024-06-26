﻿using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public UserTypeEnum Role { get; set; } = UserTypeEnum.CUSTOMER;
    }
    public class ReturnLoginViewModel
    {
        public Guid Id { get; set; }

        public string UserName { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public List<string> Roles { get; set; } = new List<string>();
        public string Token { get; set; } = default!;
        public DateTime Expiration { get; set; }
    }
    public class LoginViewModel
    {
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
