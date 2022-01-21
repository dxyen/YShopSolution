using System;
using Microsoft.AspNetCore.Identity;

namespace YShopSolution.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
