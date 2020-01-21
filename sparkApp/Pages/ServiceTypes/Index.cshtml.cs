using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sparkApp.Data;
using sparkApp.Models;

namespace sparkApp
{
    public class IndexModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IList<ServiceType> ServiceType { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ServiceType = await _db.ServiceType.ToListAsync();
            return Page();

        }
    }
}