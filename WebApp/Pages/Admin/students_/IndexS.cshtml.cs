using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp.Data;
using WebApp.Model;

namespace WebApp.Pages.Admin
{
    [Authorize]
    public class IndexSModel : PageModel
    {
        private readonly WebApp.Data.DataContext _context;

        public IndexSModel(WebApp.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.students.ToListAsync();
        }
    }
}
