using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using sparkApp.Data;
using sparkApp.Models;
using sparkApp.Utility;

namespace sparkApp.Pages.ServiceTypes
{
    
    public class DetailsModel : PageModel
    {
        private readonly sparkApp.Data.ApplicationDbContext _context;

        public DetailsModel(sparkApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public ServiceType ServiceType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ServiceType = await _context.ServiceType.FirstOrDefaultAsync(m => m.Id == id);

            if (ServiceType == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
