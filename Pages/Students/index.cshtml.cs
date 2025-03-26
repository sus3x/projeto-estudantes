using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FiliTest.Data;
using FiliTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiliTest.Pages.Students
{
	public class IndexModel : PageModel
	{
		private readonly ApplicationDbContext _context;

		public IndexModel(ApplicationDbContext context)
		{
			_context = context;
		}

		public List<Student> Students { get; set; } = new();

		public async Task OnGetAsync()
		{
			Students = await _context.Students.ToListAsync();
		}
	}
}
