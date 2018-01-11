﻿using Microsoft.AspNetCore.Identity;
using System;

namespace BlastAsia.DigiBook.Domain.Models
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public ApplicationRole()
        {
        }

        public ApplicationRole(string roleName) : base(roleName)
        {
        }
    }
}
