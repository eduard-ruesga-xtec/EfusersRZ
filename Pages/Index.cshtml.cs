using EfuserRz.Data;
using EfusersRz.Model;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace EfuserRz.Pages
{
	public class IndexModel : PageModel
	{
		
		public User User { get; set; }

		private readonly ApplicationDbContext _context;

		public IndexModel(ApplicationDbContext context)
		{
			_context = context;
		}


		public void OnGet()
		{
			User = _context.Users.FirstOrDefault(u => u.Name == "Jacobo");
			
		
		}
	}
}
