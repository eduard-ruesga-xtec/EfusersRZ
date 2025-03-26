using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EfuserRz.Data;
using EfusersRz.Model;

namespace EfuserRz.Pages.users
{
    public class IndexModel : PageModel
    {
        private readonly EfuserRz.Data.ApplicationDbContext _context;

        public IndexModel(EfuserRz.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.Users
                .Include(u => u.Address).ToListAsync();
        }
    }
}
