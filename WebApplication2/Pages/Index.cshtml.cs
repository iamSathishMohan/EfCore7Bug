using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly SMDBContext _context;
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, SMDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGet()
        {
            var users = await _context.AspNetUsers.Include(x => x.Roles).ToListAsync();
        }
    }
}