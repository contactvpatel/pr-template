using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Sample.NET.Core
{
    public class UserValidation :AbstractValidator<UserDTO>    
    {
        public UserValidation() 
        {
            RuleFor(x => x.Name).Length(0, 5);
            RuleFor(x => x.Email).EmailAddress();
            RuleFor(x => x.Gender).NotEmpty();
            RuleFor(x => x.Age).NotEmpty();
        }
    }
}
